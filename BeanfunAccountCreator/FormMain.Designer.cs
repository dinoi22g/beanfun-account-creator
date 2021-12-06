namespace BeanfunAccountCreator
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lsvAccount = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaxAccountCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labNowNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRestartNetworkAccountCount = new System.Windows.Forms.TextBox();
            this.chkAutoRestartNetwork = new System.Windows.Forms.CheckBox();
            this.btnRestartNetwork = new System.Windows.Forms.Button();
            this.cbNetworkName = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnRunSingle = new System.Windows.Forms.Button();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvAccount
            // 
            this.lsvAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvAccount.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvAccount.FullRowSelect = true;
            this.lsvAccount.Location = new System.Drawing.Point(12, 12);
            this.lsvAccount.Name = "lsvAccount";
            this.lsvAccount.Size = new System.Drawing.Size(477, 332);
            this.lsvAccount.TabIndex = 0;
            this.lsvAccount.UseCompatibleStateImageBehavior = false;
            this.lsvAccount.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "帳號";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "密碼";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "狀態";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "訊息";
            this.columnHeader4.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.編輯ToolStripMenuItem,
            this.刪除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 82);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.新增ToolStripMenuItem.Text = "新增(&A)";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.編輯ToolStripMenuItem.Text = "編輯(&E)";
            this.編輯ToolStripMenuItem.Click += new System.EventHandler(this.編輯ToolStripMenuItem_Click);
            // 
            // 刪除ToolStripMenuItem
            // 
            this.刪除ToolStripMenuItem.Name = "刪除ToolStripMenuItem";
            this.刪除ToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.刪除ToolStripMenuItem.Text = "刪除(&D)";
            this.刪除ToolStripMenuItem.Click += new System.EventHandler(this.刪除ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 382);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 279);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(469, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "設置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaxAccountCount);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 53);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "其它";
            // 
            // txtMaxAccountCount
            // 
            this.txtMaxAccountCount.Location = new System.Drawing.Point(122, 20);
            this.txtMaxAccountCount.Name = "txtMaxAccountCount";
            this.txtMaxAccountCount.Size = new System.Drawing.Size(87, 25);
            this.txtMaxAccountCount.TabIndex = 3;
            this.txtMaxAccountCount.Text = "2";
            this.txtMaxAccountCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "帳號創建上限";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labNowNumber);
            this.groupBox2.Controls.Add(this.txtAccountNumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAccountPrefix);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 94);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "創建規則";
            // 
            // labNowNumber
            // 
            this.labNowNumber.AutoSize = true;
            this.labNowNumber.ForeColor = System.Drawing.Color.Red;
            this.labNowNumber.Location = new System.Drawing.Point(18, 61);
            this.labNowNumber.Name = "labNowNumber";
            this.labNowNumber.Size = new System.Drawing.Size(96, 15);
            this.labNowNumber.TabIndex = 6;
            this.labNowNumber.Text = "*目前到 50 號";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(43, 21);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(36, 25);
            this.txtAccountNumber.TabIndex = 5;
            this.txtAccountNumber.Text = "50";
            this.txtAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "從　　　　開始遞增";
            // 
            // txtAccountPrefix
            // 
            this.txtAccountPrefix.Location = new System.Drawing.Point(239, 18);
            this.txtAccountPrefix.Name = "txtAccountPrefix";
            this.txtAccountPrefix.Size = new System.Drawing.Size(101, 25);
            this.txtAccountPrefix.TabIndex = 3;
            this.txtAccountPrefix.Text = "user";
            this.txtAccountPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "帳號前綴";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRestartNetworkAccountCount);
            this.groupBox1.Controls.Add(this.chkAutoRestartNetwork);
            this.groupBox1.Controls.Add(this.btnRestartNetwork);
            this.groupBox1.Controls.Add(this.cbNetworkName);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "網絡";
            // 
            // txtRestartNetworkAccountCount
            // 
            this.txtRestartNetworkAccountCount.Location = new System.Drawing.Point(143, 51);
            this.txtRestartNetworkAccountCount.Name = "txtRestartNetworkAccountCount";
            this.txtRestartNetworkAccountCount.Size = new System.Drawing.Size(31, 25);
            this.txtRestartNetworkAccountCount.TabIndex = 3;
            this.txtRestartNetworkAccountCount.Text = "3";
            this.txtRestartNetworkAccountCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkAutoRestartNetwork
            // 
            this.chkAutoRestartNetwork.AutoSize = true;
            this.chkAutoRestartNetwork.Location = new System.Drawing.Point(69, 53);
            this.chkAutoRestartNetwork.Name = "chkAutoRestartNetwork";
            this.chkAutoRestartNetwork.Size = new System.Drawing.Size(209, 19);
            this.chkAutoRestartNetwork.TabIndex = 2;
            this.chkAutoRestartNetwork.Text = "每執行　　　個帳號後重啟";
            this.chkAutoRestartNetwork.UseVisualStyleBackColor = true;
            // 
            // btnRestartNetwork
            // 
            this.btnRestartNetwork.Location = new System.Drawing.Point(214, 23);
            this.btnRestartNetwork.Name = "btnRestartNetwork";
            this.btnRestartNetwork.Size = new System.Drawing.Size(64, 24);
            this.btnRestartNetwork.TabIndex = 1;
            this.btnRestartNetwork.Text = "重啟";
            this.btnRestartNetwork.UseVisualStyleBackColor = true;
            this.btnRestartNetwork.Click += new System.EventHandler(this.btnRestartNetwork_Click);
            // 
            // cbNetworkName
            // 
            this.cbNetworkName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNetworkName.FormattingEnabled = true;
            this.cbNetworkName.Location = new System.Drawing.Point(6, 24);
            this.cbNetworkName.Name = "cbNetworkName";
            this.cbNetworkName.Size = new System.Drawing.Size(203, 23);
            this.cbNetworkName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(469, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(463, 244);
            this.txtLog.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(261, 350);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(111, 26);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "一鍵執行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRunSingle
            // 
            this.btnRunSingle.Location = new System.Drawing.Point(378, 350);
            this.btnRunSingle.Name = "btnRunSingle";
            this.btnRunSingle.Size = new System.Drawing.Size(111, 26);
            this.btnRunSingle.TabIndex = 4;
            this.btnRunSingle.Text = "執行單個";
            this.btnRunSingle.UseVisualStyleBackColor = true;
            this.btnRunSingle.Click += new System.EventHandler(this.btnRunSingle_Click);
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(12, 350);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(111, 26);
            this.btnRemoveAll.TabIndex = 5;
            this.btnRemoveAll.Text = "刪除全部";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 675);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRunSingle);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lsvAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "樂豆自動建帳號";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.ListView lsvAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnRunSingle;
        private System.Windows.Forms.ComboBox cbNetworkName;
        private System.Windows.Forms.TextBox txtRestartNetworkAccountCount;
        private System.Windows.Forms.CheckBox chkAutoRestartNetwork;
        private System.Windows.Forms.Button btnRestartNetwork;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAccountPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaxAccountCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labNowNumber;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.Button btnRemoveAll;
    }
}

