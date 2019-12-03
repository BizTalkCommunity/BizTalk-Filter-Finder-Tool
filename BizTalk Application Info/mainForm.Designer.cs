namespace BizTalk_Filter_Finder
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.integratedSecCb = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.catalogTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serverTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchtextTb = new System.Windows.Forms.TextBox();
            this.selectAllCb = new System.Windows.Forms.CheckBox();
            this.loadInfoBtn = new System.Windows.Forms.Button();
            this.applicationsCLb = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sendInfoTree = new System.Windows.Forms.TreeView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.orchestrationTree = new System.Windows.Forms.TreeView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.integratedSecCb);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.usernameTb);
            this.groupBox1.Controls.Add(this.passwordTb);
            this.groupBox1.Controls.Add(this.catalogTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.serverTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.connectbtn);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Connection";
            // 
            // integratedSecCb
            // 
            this.integratedSecCb.AutoSize = true;
            this.integratedSecCb.Checked = true;
            this.integratedSecCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.integratedSecCb.Location = new System.Drawing.Point(12, 129);
            this.integratedSecCb.Name = "integratedSecCb";
            this.integratedSecCb.Size = new System.Drawing.Size(134, 17);
            this.integratedSecCb.TabIndex = 5;
            this.integratedSecCb.Text = "Use integrated security";
            this.integratedSecCb.UseVisualStyleBackColor = true;
            this.integratedSecCb.CheckedChanged += new System.EventHandler(this.integratedSecCb_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::BizTalk_Filter_Finder.Properties.Resources.save;
            this.saveBtn.Location = new System.Drawing.Point(188, 157);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(149, 40);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save ";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // usernameTb
            // 
            this.usernameTb.Enabled = false;
            this.usernameTb.Location = new System.Drawing.Point(83, 74);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(254, 20);
            this.usernameTb.TabIndex = 3;
            // 
            // passwordTb
            // 
            this.passwordTb.Enabled = false;
            this.passwordTb.Location = new System.Drawing.Point(83, 100);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(254, 20);
            this.passwordTb.TabIndex = 4;
            // 
            // catalogTb
            // 
            this.catalogTb.Location = new System.Drawing.Point(83, 48);
            this.catalogTb.Name = "catalogTb";
            this.catalogTb.Size = new System.Drawing.Size(254, 20);
            this.catalogTb.TabIndex = 2;
            this.catalogTb.Text = "BizTalkMgmtDB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mgmt DB:";
            // 
            // serverTb
            // 
            this.serverTb.Location = new System.Drawing.Point(83, 22);
            this.serverTb.Name = "serverTb";
            this.serverTb.Size = new System.Drawing.Size(254, 20);
            this.serverTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SQL Server:";
            // 
            // connectbtn
            // 
            this.connectbtn.BackColor = System.Drawing.Color.Transparent;
            this.connectbtn.Image = global::BizTalk_Filter_Finder.Properties.Resources.connect_database;
            this.connectbtn.Location = new System.Drawing.Point(6, 157);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(149, 40);
            this.connectbtn.TabIndex = 6;
            this.connectbtn.Text = "Connect";
            this.connectbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.connectbtn.UseVisualStyleBackColor = false;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.searchtextTb);
            this.groupBox2.Controls.Add(this.selectAllCb);
            this.groupBox2.Controls.Add(this.loadInfoBtn);
            this.groupBox2.Controls.Add(this.applicationsCLb);
            this.groupBox2.Location = new System.Drawing.Point(3, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 428);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BizTalk Applications";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Search text:";
            // 
            // searchtextTb
            // 
            this.searchtextTb.Location = new System.Drawing.Point(89, 390);
            this.searchtextTb.Name = "searchtextTb";
            this.searchtextTb.Size = new System.Drawing.Size(99, 20);
            this.searchtextTb.TabIndex = 11;
            // 
            // selectAllCb
            // 
            this.selectAllCb.AutoSize = true;
            this.selectAllCb.Location = new System.Drawing.Point(6, 352);
            this.selectAllCb.Name = "selectAllCb";
            this.selectAllCb.Size = new System.Drawing.Size(70, 17);
            this.selectAllCb.TabIndex = 4;
            this.selectAllCb.Text = "Select All";
            this.selectAllCb.UseVisualStyleBackColor = true;
            this.selectAllCb.CheckedChanged += new System.EventHandler(this.selectAllCb_CheckedChanged);
            // 
            // loadInfoBtn
            // 
            this.loadInfoBtn.Image = global::BizTalk_Filter_Finder.Properties.Resources.searchi;
            this.loadInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadInfoBtn.Location = new System.Drawing.Point(194, 372);
            this.loadInfoBtn.Name = "loadInfoBtn";
            this.loadInfoBtn.Size = new System.Drawing.Size(149, 38);
            this.loadInfoBtn.TabIndex = 10;
            this.loadInfoBtn.Text = "Search Filters";
            this.loadInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadInfoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadInfoBtn.UseVisualStyleBackColor = true;
            this.loadInfoBtn.Click += new System.EventHandler(this.loadInfoBtn_Click);
            // 
            // applicationsCLb
            // 
            this.applicationsCLb.FormattingEnabled = true;
            this.applicationsCLb.Location = new System.Drawing.Point(6, 13);
            this.applicationsCLb.Name = "applicationsCLb";
            this.applicationsCLb.Size = new System.Drawing.Size(337, 334);
            this.applicationsCLb.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(360, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 637);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Apps Ports Info";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sendInfoTree);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(661, 307);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Send Ports";
            // 
            // sendInfoTree
            // 
            this.sendInfoTree.Location = new System.Drawing.Point(6, 19);
            this.sendInfoTree.Name = "sendInfoTree";
            this.sendInfoTree.Size = new System.Drawing.Size(649, 282);
            this.sendInfoTree.TabIndex = 1;
            this.sendInfoTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendInfoTree_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.orchestrationTree);
            this.groupBox4.Location = new System.Drawing.Point(6, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(661, 298);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Orchestration Filters";
            // 
            // orchestrationTree
            // 
            this.orchestrationTree.Location = new System.Drawing.Point(6, 19);
            this.orchestrationTree.Name = "orchestrationTree";
            this.orchestrationTree.Size = new System.Drawing.Size(649, 269);
            this.orchestrationTree.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(1039, 387);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 236);
            this.panel4.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(1045, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1045, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 108);
            this.label5.TabIndex = 37;
            this.label5.Text = "BizTalk Server Filter Finder";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1252, 643);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "BizTalk Filter Finder";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox catalogTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.CheckBox integratedSecCb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox applicationsCLb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button loadInfoBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TreeView sendInfoTree;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TreeView orchestrationTree;
        private System.Windows.Forms.CheckBox selectAllCb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchtextTb;
    }
}

