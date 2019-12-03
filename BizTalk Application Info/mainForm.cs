using Microsoft.BizTalk.ExplorerOM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace BizTalk_Filter_Finder
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            var configs = ConfigurationManager.AppSettings;
            serverTb.Text = configs["connServer"];
            catalogTb.Text = configs["connDB"];
            usernameTb.Text = configs["userDB"];
            passwordTb.Text = configs["passDB"];
        }

        #region Helper Functions
        private List<string> ParsedFilter(string filter)
        {
            List<string> filters = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(filter);
            XmlNodeList statementNodes = doc.SelectNodes("/Filter/Group/Statement");
            foreach (XmlNode node in statementNodes)
                //if filter is missing, add all
                if (searchtextTb.Text == string.Empty)
                    filters.Add(node.Attributes["Property"].Value + " " + ConvertOperator(node.Attributes["Operator"].Value) + " " + node.Attributes["Value"].Value);
                else
                {
                    //otherwise only show matches( ignore case)
                    if (node.Attributes["Value"].Value.ToUpper().Contains(searchtextTb.Text.ToUpper()))
                        filters.Add(node.Attributes["Property"].Value + " " + ConvertOperator(node.Attributes["Operator"].Value) + " " + node.Attributes["Value"].Value);
                }
                    return filters;
        }
        private string ConvertOperator(string opId)
        {
            switch (opId)
            {
                case "0": return "==";
                case "1": return "<";
                case "2": return "<=";
                case "3": return ">";
                case "4": return ">=";
                case "5": return "!=";
                case "6": return "Exists";
                default:
                    return "Unknown operator";
            }
        }
        #endregion

        #region Buttons handlers
        private void sendInfoTree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.C))
            {
                if (sendInfoTree.SelectedNode != null)
                    Clipboard.SetText(sendInfoTree.SelectedNode.Text.Substring(11, sendInfoTree.SelectedNode.Text.Length - 11));
                e.SuppressKeyPress = true;
            }
        }
        private void integratedSecCb_CheckedChanged(object sender, EventArgs e)
        {
            if (integratedSecCb.Checked)
                passwordTb.Enabled = usernameTb.Enabled = false;
            else
                passwordTb.Enabled = usernameTb.Enabled = true;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            #region Save to App.Config
            if (integratedSecCb.Checked)
            {
                settings["connServer"].Value = serverTb.Text;
                settings["connDB"].Value = catalogTb.Text;
                settings["connString"].Value = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" +
                    catalogTb.Text + ";Data Source=" + serverTb.Text;
            }
            else
            {
                settings["userDB"].Value = usernameTb.Text;
                settings["passDB"].Value = passwordTb.Text;
                settings["connServer"].Value = serverTb.Text;
                settings["connDB"].Value = catalogTb.Text;
                settings["connString"].Value = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" +
                    catalogTb.Text + ";Data Source=" + serverTb.Text +
                    ";UserName=" + usernameTb.Text + ";Password=" + passwordTb.Text;
            }
            #endregion

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
        private void connectbtn_Click(object sender, EventArgs e)
        {
            try
            { //Load all Applications
                applicationsCLb.Items.Clear();
                using (var expl = new BtsCatalogExplorer() { ConnectionString = ConfigurationManager.AppSettings["connString"].ToString() })
                {
                    ApplicationCollection orqs = expl.Applications;
                    foreach (Microsoft.BizTalk.ExplorerOM.Application app in orqs) //Load to CheckedListBox
                        applicationsCLb.Items.Add(app.Name);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void loadInfoBtn_Click(object sender, EventArgs e)
        {
            sendInfoTree.Nodes.Clear();
            orchestrationTree.Nodes.Clear();
            try
            {
                using (var expl = new BtsCatalogExplorer() { ConnectionString = ConfigurationManager.AppSettings["connString"].ToString() })
                {  //open connection
                    foreach (string item in applicationsCLb.CheckedItems)
                    {
                        TreeNode node = null;
                        if (sendInfoTree.Nodes.Find(item, false).Count() == 0)
                        {
                            //TreeNode node = sendInfoTree.Nodes.Add(item, item);
                            bool addapp = true;
                            foreach (SendPort port in expl.SendPorts)
                            {
                                #region SendPorts
                                if (port.Application.Name == item && !string.IsNullOrEmpty(port.Filter))
                                {
                                    var nodes = ParsedFilter(port.Filter);
                                    if (addapp)
                                    {
                                        node = sendInfoTree.Nodes.Add(item, item);
                                        addapp = false;
                                    }
                                    if (nodes.Count > 0)
                                    { 
                                        var sendNode = node.Nodes.Add(port.Name);
                                        if (port.PrimaryTransport != null)
                                            sendNode.Nodes.Add("Address: " + port.PrimaryTransport.Address);
                                        sendNode.Nodes.Add("Filter XML: " + port.Filter);
                                    
                                        foreach (var v in nodes)
                                            sendNode.Nodes.Add("Subscription: " + v);
                                        node.Expand();
                                    }
                                }
                                #endregion
                            }
                        }
                    }
                }

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["connString"].ToString().Replace("BiztalkMgmtDb", "BizTalkMsgBoxDb")))
                {
                    Assembly myAssembly = Assembly.Load("Microsoft.BizTalk.GlobalPropertySchemas");
                    foreach (string item in applicationsCLb.CheckedItems)
                    {
                        if (orchestrationTree.Nodes.Find(item, false).Count() == 0)
                        {
                            object predicateGroupId = GetPredicateGroupID(conn, item);
                            if (predicateGroupId != null)
                            {
                                #region Get predicates
                                TreeNode node = orchestrationTree.Nodes.Add(item, item);
                                string pGID = predicateGroupId.ToString();
                                SqlCommand comm = new SqlCommand();
                                SqlDataAdapter da = new SqlDataAdapter();
                                DataTable dt = new DataTable();
                                GetEqualsPredicates(conn, myAssembly, node, pGID, comm, da, dt);
                                GetPredicates(conn, myAssembly, node, pGID, comm, da, dt, "[BitwiseANDPredicates]");
                                GetPredicates(conn, myAssembly, node, pGID, comm, da, dt, "[EqualsPredicates2ndPass]");
                                GetPredicates(conn, myAssembly, node, pGID, comm, da, dt, "[ExistsPredicates]");
                                GetPredicates(conn, myAssembly, node, pGID, comm, da, dt, "[GreaterThanOrEqualsPredicates]");
                                GetPredicates(conn, myAssembly, node, pGID, comm, da, dt, "[GreaterThanPredicates]");
                                GetPredicates(conn, myAssembly, node, pGID, comm, da, dt, "[LessThanPredicates]");
                                GetPredicates(conn, myAssembly, node, pGID, comm, da, dt, "[LessThanOrEqualsPredicates]");
                                GetPredicates(conn, myAssembly, node, pGID, comm, da, dt, "[NotEqualsPredicates]");
                                node.Expand();
                                #endregion
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlex)
            { throw sqlex; }
            catch (Exception ex)
            { throw ex; }
        }
        private void selectAllCb_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllCb.Checked)
            {
                for (int i = 0; i < applicationsCLb.Items.Count; i++)
                    applicationsCLb.SetItemChecked(i, true);
            }
            else
            {
                for (int i = 0; i < applicationsCLb.Items.Count; i++)
                    applicationsCLb.SetItemChecked(i, false);
            }
        }
        #endregion

        #region Predicates Fetch
        private object GetPredicateGroupID(SqlConnection conn, string item)
        {
            SqlCommand comm = new SqlCommand()
            {
                CommandText = @"SELECT uidPredicateGroupID FROM [BizTalkMsgBoxDb].[dbo].[Subscription] where nvcName like '%" + item + @"%'",
                Connection = conn
            };
            comm.CommandType = System.Data.CommandType.Text;
            conn.Open();
            var ret = comm.ExecuteScalar();
            conn.Close();
            return ret;
        }
        private static void GetEqualsPredicates(SqlConnection conn, Assembly myAssembly, TreeNode node, string predicateGroupId,
           SqlCommand comm, SqlDataAdapter da, DataTable dt)
        {
            comm = new SqlCommand()
            {
                CommandText = @"  SELECT uidPredicateGroupID, vtValue, uidPropID, uidPredicateANDGroupID, uidPredicateORGroupID
                                              FROM [BizTalkMsgBoxDb].[dbo].[EqualsPredicates] as E WITH(NOLOCK) inner Join
                                              [BizTalkMsgBoxDb].[dbo].[PredicateGroup] as P WITH(NOLOCK)
                                              on  E.uidPredicateGroupID = P.uidPredicateANDGroupID
                                              where uidPredicateANDGroupID = '" + predicateGroupId + @"' or uidPredicateORGroupID = '" + predicateGroupId + "'",
                Connection = conn
            };
            comm.CommandType = System.Data.CommandType.Text;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            da = new SqlDataAdapter(comm);
            dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                var type = myAssembly.DefinedTypes.Where(a => a.GUID == Guid.Parse(row["uidPropID"].ToString()));
                if (type.FirstOrDefault().Name != "ReceivePortID")
                {
                    if (row["uidPredicateGroupID"].ToString() == row["uidPredicateANDGroupID"].ToString())
                        node.Nodes.Add("Orch Filter: " + type.FirstOrDefault().Name + " AND \"" + row["vtValue"] + "\"");
                    else
                        node.Nodes.Add("Orch Filter: " + type.FirstOrDefault().Name + " OR \"" + row["vtValue"] + "\"");
                }
            }
            conn.Close();
        }
        private static void GetPredicates(SqlConnection conn, Assembly myAssembly, TreeNode node, string predicateGroupId,
            SqlCommand comm, SqlDataAdapter da, DataTable dt, string table)
        {
            comm = new SqlCommand()
            {
                CommandText = @"SELECT uidPropID" + (table == "[ExistsPredicates]" ? "" : ", vtValue") + @" FROM [BizTalkMsgBoxDb].[dbo]." + table + @" WITH(NOLOCK) 
                    where uidPredicateGroupID = '" + predicateGroupId + @"'",
                Connection = conn
            };
            comm.CommandType = System.Data.CommandType.Text;
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            da = new SqlDataAdapter(comm);
            dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                var type = myAssembly.DefinedTypes.Where(a => a.GUID == Guid.Parse(row["uidPropID"].ToString()));
                node.Nodes.Add("Orch Filter: " + type.FirstOrDefault().Name + GetPredicateValue(table) + "\"" + row["vtValue"] + "\"");
            }
            conn.Close();
        }
        private static string GetPredicateValue(string table)
        {
            string value = "";
            switch (table)
            {
                case "[BitwiseANDPredicates]":
                    value = "&"; break;
                case "[EqualsPredicates2ndPass]":
                    value = "=="; break;
                case "[ExistsPredicates]":
                    value = "Exists"; break;
                case "[GreaterThanOrEqualsPredicates]":
                    value = ">="; break;
                case "[GreaterThanPredicates]":
                    value = ">"; break;
                case "[LessThanPredicates]":
                    value = "<"; break;
                case "[LessThanOrEqualsPredicates]":
                    value = "<="; break;
                case "[NotEqualsPredicates]":
                    value = "!="; break;
                default:
                    break;
            }
            return value;
        }
        #endregion

    }
}
