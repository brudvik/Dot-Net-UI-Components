namespace BCC.DotNetUI.Components.Test
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bccExtendedListView1 = new BCC.DotNetUI.Components.BCCExtendedListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStartLogTimer = new System.Windows.Forms.Button();
            this.btnPauseLogInput = new System.Windows.Forms.Button();
            this.btnResumeLogInput = new System.Windows.Forms.Button();
            this.btnStopLogTimer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLVAutoScroll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLVDisplayLimit = new System.Windows.Forms.TextBox();
            this.txtLVMaxPauseLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrLvLog = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bccExtendedComboBox1 = new BCC.DotNetUI.Components.BCCExtendedComboBox();
            this.btnCBData = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCBValue = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnStopLogTimer);
            this.tabPage1.Controls.Add(this.btnResumeLogInput);
            this.tabPage1.Controls.Add(this.btnPauseLogInput);
            this.tabPage1.Controls.Add(this.btnStartLogTimer);
            this.tabPage1.Controls.Add(this.bccExtendedListView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ListView";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bccExtendedListView1
            // 
            this.bccExtendedListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.bccExtendedListView1.EnableAutomaticScroll = false;
            this.bccExtendedListView1.FullRowSelect = true;
            this.bccExtendedListView1.GridLines = true;
            this.bccExtendedListView1.IgnoreDoubleClickCheck = false;
            this.bccExtendedListView1.LimitDisplayNumber = 0;
            this.bccExtendedListView1.Location = new System.Drawing.Point(12, 59);
            this.bccExtendedListView1.LogLevel = BCC.DotNetUI.Components.BCCExtendedListView.LoggingLevel.Debug;
            this.bccExtendedListView1.LogLevelColumnIndicator = 0;
            this.bccExtendedListView1.MaxNumberWhenPaused = 0;
            this.bccExtendedListView1.Name = "bccExtendedListView1";
            this.bccExtendedListView1.ReactToLogLevel = false;
            this.bccExtendedListView1.Size = new System.Drawing.Size(416, 372);
            this.bccExtendedListView1.TabIndex = 0;
            this.bccExtendedListView1.UseCompatibleStateImageBehavior = false;
            this.bccExtendedListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Event";
            this.columnHeader2.Width = 260;
            // 
            // btnStartLogTimer
            // 
            this.btnStartLogTimer.Location = new System.Drawing.Point(435, 58);
            this.btnStartLogTimer.Name = "btnStartLogTimer";
            this.btnStartLogTimer.Size = new System.Drawing.Size(202, 29);
            this.btnStartLogTimer.TabIndex = 1;
            this.btnStartLogTimer.Text = "Start Log Timer";
            this.btnStartLogTimer.UseVisualStyleBackColor = true;
            this.btnStartLogTimer.Click += new System.EventHandler(this.btnStartLogTimer_Click);
            // 
            // btnPauseLogInput
            // 
            this.btnPauseLogInput.Location = new System.Drawing.Point(434, 368);
            this.btnPauseLogInput.Name = "btnPauseLogInput";
            this.btnPauseLogInput.Size = new System.Drawing.Size(202, 29);
            this.btnPauseLogInput.TabIndex = 2;
            this.btnPauseLogInput.Text = "Pause Log Input";
            this.btnPauseLogInput.UseVisualStyleBackColor = true;
            this.btnPauseLogInput.Click += new System.EventHandler(this.btnPauseLogInput_Click);
            // 
            // btnResumeLogInput
            // 
            this.btnResumeLogInput.Location = new System.Drawing.Point(434, 403);
            this.btnResumeLogInput.Name = "btnResumeLogInput";
            this.btnResumeLogInput.Size = new System.Drawing.Size(202, 29);
            this.btnResumeLogInput.TabIndex = 3;
            this.btnResumeLogInput.Text = "Resume Log Input";
            this.btnResumeLogInput.UseVisualStyleBackColor = true;
            this.btnResumeLogInput.Click += new System.EventHandler(this.btnResumeLogInput_Click);
            // 
            // btnStopLogTimer
            // 
            this.btnStopLogTimer.Location = new System.Drawing.Point(435, 93);
            this.btnStopLogTimer.Name = "btnStopLogTimer";
            this.btnStopLogTimer.Size = new System.Drawing.Size(202, 29);
            this.btnStopLogTimer.TabIndex = 4;
            this.btnStopLogTimer.Text = "Stop Log Timer";
            this.btnStopLogTimer.UseVisualStyleBackColor = true;
            this.btnStopLogTimer.Click += new System.EventHandler(this.btnStopLogTimer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLVMaxPauseLog);
            this.groupBox1.Controls.Add(this.txtLVDisplayLimit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkLVAutoScroll);
            this.groupBox1.Location = new System.Drawing.Point(435, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 234);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Configuration:";
            // 
            // chkLVAutoScroll
            // 
            this.chkLVAutoScroll.AutoSize = true;
            this.chkLVAutoScroll.Location = new System.Drawing.Point(89, 25);
            this.chkLVAutoScroll.Name = "chkLVAutoScroll";
            this.chkLVAutoScroll.Size = new System.Drawing.Size(102, 17);
            this.chkLVAutoScroll.TabIndex = 0;
            this.chkLVAutoScroll.Text = "Automatic Scroll";
            this.chkLVAutoScroll.UseVisualStyleBackColor = true;
            this.chkLVAutoScroll.CheckedChanged += new System.EventHandler(this.chkLVAutoScroll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Limit display:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max pause log:";
            // 
            // txtLVDisplayLimit
            // 
            this.txtLVDisplayLimit.Location = new System.Drawing.Point(89, 50);
            this.txtLVDisplayLimit.Name = "txtLVDisplayLimit";
            this.txtLVDisplayLimit.Size = new System.Drawing.Size(47, 20);
            this.txtLVDisplayLimit.TabIndex = 3;
            this.txtLVDisplayLimit.Text = "0";
            this.txtLVDisplayLimit.TextChanged += new System.EventHandler(this.txtLVDisplayLimit_TextChanged);
            // 
            // txtLVMaxPauseLog
            // 
            this.txtLVMaxPauseLog.Location = new System.Drawing.Point(89, 76);
            this.txtLVMaxPauseLog.Name = "txtLVMaxPauseLog";
            this.txtLVMaxPauseLog.Size = new System.Drawing.Size(47, 20);
            this.txtLVMaxPauseLog.TabIndex = 4;
            this.txtLVMaxPauseLog.Text = "0";
            this.txtLVMaxPauseLog.TextChanged += new System.EventHandler(this.txtLVMaxPauseLog_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(628, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "0 = Unlimited";
            // 
            // tmrLvLog
            // 
            this.tmrLvLog.Interval = 1000;
            this.tmrLvLog.Tick += new System.EventHandler(this.tmrLvLog_Tick);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 44);
            this.label5.TabIndex = 6;
            this.label5.Text = "If max pause log threshold is reached, then the input will automatically be resum" +
    "ed.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCBValue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnCBData);
            this.groupBox2.Controls.Add(this.bccExtendedComboBox1);
            this.groupBox2.Location = new System.Drawing.Point(17, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 103);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extended ComboBox Example:";
            // 
            // bccExtendedComboBox1
            // 
            this.bccExtendedComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bccExtendedComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bccExtendedComboBox1.FormattingEnabled = true;
            this.bccExtendedComboBox1.Location = new System.Drawing.Point(17, 29);
            this.bccExtendedComboBox1.Name = "bccExtendedComboBox1";
            this.bccExtendedComboBox1.Size = new System.Drawing.Size(571, 21);
            this.bccExtendedComboBox1.TabIndex = 0;
            this.bccExtendedComboBox1.SelectedIndexChanged += new System.EventHandler(this.bccExtendedComboBox1_SelectedIndexChanged);
            // 
            // btnCBData
            // 
            this.btnCBData.Location = new System.Drawing.Point(16, 56);
            this.btnCBData.Name = "btnCBData";
            this.btnCBData.Size = new System.Drawing.Size(202, 29);
            this.btnCBData.TabIndex = 2;
            this.btnCBData.Text = "Load Test Data";
            this.btnCBData.UseVisualStyleBackColor = true;
            this.btnCBData.Click += new System.EventHandler(this.btnCBData_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Selected value:";
            // 
            // lblCBValue
            // 
            this.lblCBValue.AutoSize = true;
            this.lblCBValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBValue.Location = new System.Drawing.Point(312, 64);
            this.lblCBValue.Name = "lblCBValue";
            this.lblCBValue.Size = new System.Drawing.Size(11, 13);
            this.lblCBValue.TabIndex = 4;
            this.lblCBValue.Text = "-";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 503);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brudvik Custom Controls (BCC) - Test Application";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private BCCExtendedListView bccExtendedListView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLVMaxPauseLog;
        private System.Windows.Forms.TextBox txtLVDisplayLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLVAutoScroll;
        private System.Windows.Forms.Button btnStopLogTimer;
        private System.Windows.Forms.Button btnResumeLogInput;
        private System.Windows.Forms.Button btnPauseLogInput;
        private System.Windows.Forms.Button btnStartLogTimer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrLvLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCBValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCBData;
        private BCCExtendedComboBox bccExtendedComboBox1;
    }
}