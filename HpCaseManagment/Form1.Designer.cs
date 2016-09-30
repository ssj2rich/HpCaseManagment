namespace HpCaseManagment
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRunProcess = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmailLayout = new System.Windows.Forms.Button();
            this.btnUserManagment = new System.Windows.Forms.Button();
            this.pnlUserManagment = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.chCheckCase = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.cbAllActive = new System.Windows.Forms.CheckBox();
            this.cbAllGroup = new System.Windows.Forms.CheckBox();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.cbGroupEmails = new System.Windows.Forms.CheckBox();
            this.cbSendEmail = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.tbExcelFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbExcelFileLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlProcessRunning = new System.Windows.Forms.Panel();
            this.btnSendEmails = new System.Windows.Forms.Button();
            this.lblSummery = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbCases = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnlEmailLayout = new System.Windows.Forms.Panel();
            this.lblPHlastActivity = new System.Windows.Forms.Label();
            this.lblPHcaseAge = new System.Windows.Forms.Label();
            this.lblPHuserTeam = new System.Windows.Forms.Label();
            this.lblPHcaseId = new System.Windows.Forms.Label();
            this.lblPHuserEmail = new System.Windows.Forms.Label();
            this.lblPHUserName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbEmailSingleFormat = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbGroupEmailFormat = new System.Windows.Forms.RichTextBox();
            this.btnSaveEmails = new System.Windows.Forms.Button();
            this.cbAutoPaste = new System.Windows.Forms.CheckBox();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.lblRepeatEnd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUserManagment.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlProcessRunning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnlEmailLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnRunProcess);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEmailLayout);
            this.panel1.Controls.Add(this.btnUserManagment);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnRunProcess
            // 
            this.btnRunProcess.BackColor = System.Drawing.Color.LightGreen;
            this.btnRunProcess.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunProcess.Location = new System.Drawing.Point(4, 3);
            this.btnRunProcess.Name = "btnRunProcess";
            this.btnRunProcess.Size = new System.Drawing.Size(221, 55);
            this.btnRunProcess.TabIndex = 3;
            this.btnRunProcess.Text = "Run Process";
            this.btnRunProcess.UseVisualStyleBackColor = false;
            this.btnRunProcess.Click += new System.EventHandler(this.btnRunProcess_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "Settings";
            this.pictureBox1.AccessibleName = "Settings";
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HpCaseManagment.Properties.Resources.a1228223;
            this.pictureBox1.Location = new System.Drawing.Point(1059, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btnEmailLayout
            // 
            this.btnEmailLayout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEmailLayout.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailLayout.Location = new System.Drawing.Point(460, 3);
            this.btnEmailLayout.Name = "btnEmailLayout";
            this.btnEmailLayout.Size = new System.Drawing.Size(221, 55);
            this.btnEmailLayout.TabIndex = 1;
            this.btnEmailLayout.Text = "Email Layout";
            this.btnEmailLayout.UseVisualStyleBackColor = false;
            this.btnEmailLayout.Click += new System.EventHandler(this.btnEmailLayout_Click);
            // 
            // btnUserManagment
            // 
            this.btnUserManagment.BackColor = System.Drawing.Color.LightBlue;
            this.btnUserManagment.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagment.Location = new System.Drawing.Point(233, 3);
            this.btnUserManagment.Name = "btnUserManagment";
            this.btnUserManagment.Size = new System.Drawing.Size(221, 55);
            this.btnUserManagment.TabIndex = 0;
            this.btnUserManagment.Text = "Users Managment";
            this.btnUserManagment.UseVisualStyleBackColor = false;
            this.btnUserManagment.Click += new System.EventHandler(this.btnUserManagment_Click);
            // 
            // pnlUserManagment
            // 
            this.pnlUserManagment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserManagment.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlUserManagment.Controls.Add(this.label6);
            this.pnlUserManagment.Controls.Add(this.lblTeam);
            this.pnlUserManagment.Controls.Add(this.chCheckCase);
            this.pnlUserManagment.Controls.Add(this.btnSave);
            this.pnlUserManagment.Controls.Add(this.tbEmail);
            this.pnlUserManagment.Controls.Add(this.lblUserName);
            this.pnlUserManagment.Controls.Add(this.cbAllActive);
            this.pnlUserManagment.Controls.Add(this.cbAllGroup);
            this.pnlUserManagment.Controls.Add(this.lbUsers);
            this.pnlUserManagment.Controls.Add(this.cbGroupEmails);
            this.pnlUserManagment.Controls.Add(this.cbSendEmail);
            this.pnlUserManagment.Controls.Add(this.label2);
            this.pnlUserManagment.Controls.Add(this.label1);
            this.pnlUserManagment.Location = new System.Drawing.Point(13, 91);
            this.pnlUserManagment.Name = "pnlUserManagment";
            this.pnlUserManagment.Size = new System.Drawing.Size(1114, 519);
            this.pnlUserManagment.TabIndex = 1;
            this.pnlUserManagment.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Team";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lblTeam.Location = new System.Drawing.Point(427, 236);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(0, 23);
            this.lblTeam.TabIndex = 11;
            // 
            // chCheckCase
            // 
            this.chCheckCase.AutoSize = true;
            this.chCheckCase.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chCheckCase.Location = new System.Drawing.Point(305, 193);
            this.chCheckCase.Name = "chCheckCase";
            this.chCheckCase.Size = new System.Drawing.Size(84, 27);
            this.chCheckCase.TabIndex = 10;
            this.chCheckCase.Text = "lo zocher";
            this.chCheckCase.UseVisualStyleBackColor = true;
            this.chCheckCase.CheckedChanged += new System.EventHandler(this.chCheckCase_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(304, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 39);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(431, 63);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(311, 28);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail_KeyDown);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(428, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 23);
            this.lblUserName.TabIndex = 7;
            // 
            // cbAllActive
            // 
            this.cbAllActive.AutoSize = true;
            this.cbAllActive.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllActive.Location = new System.Drawing.Point(806, 311);
            this.cbAllActive.Name = "cbAllActive";
            this.cbAllActive.Size = new System.Drawing.Size(165, 27);
            this.cbAllActive.TabIndex = 6;
            this.cbAllActive.Text = "Set All Users to active";
            this.cbAllActive.UseVisualStyleBackColor = true;
            this.cbAllActive.CheckedChanged += new System.EventHandler(this.cbAllActive_CheckedChanged);
            // 
            // cbAllGroup
            // 
            this.cbAllGroup.AutoSize = true;
            this.cbAllGroup.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllGroup.Location = new System.Drawing.Point(806, 343);
            this.cbAllGroup.Name = "cbAllGroup";
            this.cbAllGroup.Size = new System.Drawing.Size(216, 27);
            this.cbAllGroup.TabIndex = 5;
            this.cbAllGroup.Text = "Set All Users To Group Emails";
            this.cbAllGroup.UseVisualStyleBackColor = true;
            this.cbAllGroup.CheckedChanged += new System.EventHandler(this.cbAllGroup_CheckedChanged);
            // 
            // lbUsers
            // 
            this.lbUsers.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 28;
            this.lbUsers.Location = new System.Drawing.Point(4, 28);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(279, 340);
            this.lbUsers.TabIndex = 4;
            this.lbUsers.SelectedIndexChanged += new System.EventHandler(this.lbUsers_SelectedIndexChanged);
            // 
            // cbGroupEmails
            // 
            this.cbGroupEmails.AutoSize = true;
            this.cbGroupEmails.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroupEmails.Location = new System.Drawing.Point(304, 150);
            this.cbGroupEmails.Name = "cbGroupEmails";
            this.cbGroupEmails.Size = new System.Drawing.Size(224, 27);
            this.cbGroupEmails.TabIndex = 3;
            this.cbGroupEmails.Text = "Group Emails ? (if more then 1)";
            this.cbGroupEmails.UseVisualStyleBackColor = true;
            this.cbGroupEmails.CheckedChanged += new System.EventHandler(this.cbGroupEmails_CheckedChanged);
            // 
            // cbSendEmail
            // 
            this.cbSendEmail.AutoSize = true;
            this.cbSendEmail.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSendEmail.Location = new System.Drawing.Point(304, 107);
            this.cbSendEmail.Name = "cbSendEmail";
            this.cbSendEmail.Size = new System.Drawing.Size(174, 27);
            this.cbSendEmail.TabIndex = 2;
            this.cbSendEmail.Text = "Send Email ? (is active)";
            this.cbSendEmail.UseVisualStyleBackColor = true;
            this.cbSendEmail.CheckedChanged += new System.EventHandler(this.cbSendEmail_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.tbExcelFileName);
            this.pnlSettings.Controls.Add(this.label4);
            this.pnlSettings.Controls.Add(this.tbExcelFileLocation);
            this.pnlSettings.Controls.Add(this.label3);
            this.pnlSettings.Location = new System.Drawing.Point(13, 91);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(1025, 365);
            this.pnlSettings.TabIndex = 1;
            // 
            // tbExcelFileName
            // 
            this.tbExcelFileName.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.tbExcelFileName.Location = new System.Drawing.Point(217, 96);
            this.tbExcelFileName.Name = "tbExcelFileName";
            this.tbExcelFileName.Size = new System.Drawing.Size(402, 28);
            this.tbExcelFileName.TabIndex = 3;
            this.tbExcelFileName.Text = "ICS-Backlog.xls";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.label4.Location = new System.Drawing.Point(61, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Excel file Name";
            // 
            // tbExcelFileLocation
            // 
            this.tbExcelFileLocation.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.tbExcelFileLocation.Location = new System.Drawing.Point(217, 39);
            this.tbExcelFileLocation.Name = "tbExcelFileLocation";
            this.tbExcelFileLocation.Size = new System.Drawing.Size(402, 28);
            this.tbExcelFileLocation.TabIndex = 1;
            this.tbExcelFileLocation.Text = "C:\\projects\\HpCaseManagment\\HpCaseManagment\\data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.label3.Location = new System.Drawing.Point(61, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Excel file Location";
            // 
            // pnlProcessRunning
            // 
            this.pnlProcessRunning.Controls.Add(this.btnSendEmails);
            this.pnlProcessRunning.Controls.Add(this.lblSummery);
            this.pnlProcessRunning.Controls.Add(this.pictureBox2);
            this.pnlProcessRunning.Controls.Add(this.lbCases);
            this.pnlProcessRunning.Location = new System.Drawing.Point(12, 88);
            this.pnlProcessRunning.Name = "pnlProcessRunning";
            this.pnlProcessRunning.Size = new System.Drawing.Size(1025, 522);
            this.pnlProcessRunning.TabIndex = 4;
            // 
            // btnSendEmails
            // 
            this.btnSendEmails.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSendEmails.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSendEmails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSendEmails.Location = new System.Drawing.Point(626, 63);
            this.btnSendEmails.Name = "btnSendEmails";
            this.btnSendEmails.Size = new System.Drawing.Size(199, 64);
            this.btnSendEmails.TabIndex = 3;
            this.btnSendEmails.Text = "Send Emails";
            this.btnSendEmails.UseVisualStyleBackColor = false;
            this.btnSendEmails.Click += new System.EventHandler(this.btnSendEmails_Click);
            // 
            // lblSummery
            // 
            this.lblSummery.AutoSize = true;
            this.lblSummery.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lblSummery.Location = new System.Drawing.Point(24, 7);
            this.lblSummery.Name = "lblSummery";
            this.lblSummery.Size = new System.Drawing.Size(47, 23);
            this.lblSummery.TabIndex = 2;
            this.lblSummery.Text = "label5";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HpCaseManagment.Properties.Resources.Updating;
            this.pictureBox2.Location = new System.Drawing.Point(461, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbCases
            // 
            this.lbCases.FormattingEnabled = true;
            this.lbCases.Location = new System.Drawing.Point(24, 63);
            this.lbCases.Name = "lbCases";
            this.lbCases.Size = new System.Drawing.Size(483, 290);
            this.lbCases.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pnlEmailLayout
            // 
            this.pnlEmailLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEmailLayout.Controls.Add(this.lblRepeatEnd);
            this.pnlEmailLayout.Controls.Add(this.lblRepeat);
            this.pnlEmailLayout.Controls.Add(this.cbAutoPaste);
            this.pnlEmailLayout.Controls.Add(this.btnSaveEmails);
            this.pnlEmailLayout.Controls.Add(this.label8);
            this.pnlEmailLayout.Controls.Add(this.rtbGroupEmailFormat);
            this.pnlEmailLayout.Controls.Add(this.lblPHlastActivity);
            this.pnlEmailLayout.Controls.Add(this.lblPHcaseAge);
            this.pnlEmailLayout.Controls.Add(this.lblPHuserTeam);
            this.pnlEmailLayout.Controls.Add(this.lblPHcaseId);
            this.pnlEmailLayout.Controls.Add(this.lblPHuserEmail);
            this.pnlEmailLayout.Controls.Add(this.lblPHUserName);
            this.pnlEmailLayout.Controls.Add(this.label7);
            this.pnlEmailLayout.Controls.Add(this.label5);
            this.pnlEmailLayout.Controls.Add(this.rtbEmailSingleFormat);
            this.pnlEmailLayout.Location = new System.Drawing.Point(13, 82);
            this.pnlEmailLayout.Name = "pnlEmailLayout";
            this.pnlEmailLayout.Size = new System.Drawing.Size(1115, 525);
            this.pnlEmailLayout.TabIndex = 5;
            // 
            // lblPHlastActivity
            // 
            this.lblPHlastActivity.AutoSize = true;
            this.lblPHlastActivity.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lblPHlastActivity.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPHlastActivity.Location = new System.Drawing.Point(722, 214);
            this.lblPHlastActivity.Name = "lblPHlastActivity";
            this.lblPHlastActivity.Size = new System.Drawing.Size(166, 23);
            this.lblPHlastActivity.TabIndex = 8;
            this.lblPHlastActivity.Text = "#DaysSinceLastActivity#";
            this.lblPHlastActivity.Click += new System.EventHandler(this.copyToClip_Click);
            this.lblPHlastActivity.MouseHover += new System.EventHandler(this.toolTipPH_MouseHover);
            // 
            // lblPHcaseAge
            // 
            this.lblPHcaseAge.AutoSize = true;
            this.lblPHcaseAge.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lblPHcaseAge.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPHcaseAge.Location = new System.Drawing.Point(639, 214);
            this.lblPHcaseAge.Name = "lblPHcaseAge";
            this.lblPHcaseAge.Size = new System.Drawing.Size(79, 23);
            this.lblPHcaseAge.TabIndex = 7;
            this.lblPHcaseAge.Text = "#caseAge#";
            this.lblPHcaseAge.Click += new System.EventHandler(this.copyToClip_Click);
            this.lblPHcaseAge.MouseHover += new System.EventHandler(this.toolTipPH_MouseHover);
            // 
            // lblPHuserTeam
            // 
            this.lblPHuserTeam.AutoSize = true;
            this.lblPHuserTeam.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lblPHuserTeam.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPHuserTeam.Location = new System.Drawing.Point(540, 214);
            this.lblPHuserTeam.Name = "lblPHuserTeam";
            this.lblPHuserTeam.Size = new System.Drawing.Size(95, 23);
            this.lblPHuserTeam.TabIndex = 6;
            this.lblPHuserTeam.Text = " #userTeam#";
            this.lblPHuserTeam.Click += new System.EventHandler(this.copyToClip_Click);
            this.lblPHuserTeam.MouseHover += new System.EventHandler(this.toolTipPH_MouseHover);
            // 
            // lblPHcaseId
            // 
            this.lblPHcaseId.AutoSize = true;
            this.lblPHcaseId.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lblPHcaseId.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPHcaseId.Location = new System.Drawing.Point(468, 214);
            this.lblPHcaseId.Name = "lblPHcaseId";
            this.lblPHcaseId.Size = new System.Drawing.Size(68, 23);
            this.lblPHcaseId.TabIndex = 5;
            this.lblPHcaseId.Text = "#caseId#";
            this.lblPHcaseId.Click += new System.EventHandler(this.copyToClip_Click);
            this.lblPHcaseId.MouseHover += new System.EventHandler(this.toolTipPH_MouseHover);
            // 
            // lblPHuserEmail
            // 
            this.lblPHuserEmail.AutoSize = true;
            this.lblPHuserEmail.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lblPHuserEmail.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPHuserEmail.Location = new System.Drawing.Point(368, 214);
            this.lblPHuserEmail.Name = "lblPHuserEmail";
            this.lblPHuserEmail.Size = new System.Drawing.Size(96, 23);
            this.lblPHuserEmail.TabIndex = 4;
            this.lblPHuserEmail.Text = " #userEmail#";
            this.lblPHuserEmail.Click += new System.EventHandler(this.copyToClip_Click);
            this.lblPHuserEmail.MouseHover += new System.EventHandler(this.toolTipPH_MouseHover);
            // 
            // lblPHUserName
            // 
            this.lblPHUserName.AutoSize = true;
            this.lblPHUserName.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lblPHUserName.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPHUserName.Location = new System.Drawing.Point(279, 214);
            this.lblPHUserName.Name = "lblPHUserName";
            this.lblPHUserName.Size = new System.Drawing.Size(93, 23);
            this.lblPHUserName.TabIndex = 3;
            this.lblPHUserName.Text = "#userName#";
            this.lblPHUserName.Click += new System.EventHandler(this.copyToClip_Click);
            this.lblPHUserName.MouseHover += new System.EventHandler(this.toolTipPH_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.label7.Location = new System.Drawing.Point(27, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Use these placeholders for parameters :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(27, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "This is the normal email for a single case";
            // 
            // rtbEmailSingleFormat
            // 
            this.rtbEmailSingleFormat.AcceptsTab = true;
            this.rtbEmailSingleFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEmailSingleFormat.Location = new System.Drawing.Point(27, 55);
            this.rtbEmailSingleFormat.Name = "rtbEmailSingleFormat";
            this.rtbEmailSingleFormat.Size = new System.Drawing.Size(1056, 147);
            this.rtbEmailSingleFormat.TabIndex = 0;
            this.rtbEmailSingleFormat.Text = "";
            this.rtbEmailSingleFormat.TextChanged += new System.EventHandler(this.rtbEmailSingleFormat_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(23, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "This is the email for grouped cases";
            // 
            // rtbGroupEmailFormat
            // 
            this.rtbGroupEmailFormat.AcceptsTab = true;
            this.rtbGroupEmailFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbGroupEmailFormat.Location = new System.Drawing.Point(23, 291);
            this.rtbGroupEmailFormat.Name = "rtbGroupEmailFormat";
            this.rtbGroupEmailFormat.Size = new System.Drawing.Size(1056, 147);
            this.rtbGroupEmailFormat.TabIndex = 9;
            this.rtbGroupEmailFormat.Text = "";
            this.rtbGroupEmailFormat.TextChanged += new System.EventHandler(this.rtbEmailSingleFormat_TextChanged);
            // 
            // btnSaveEmails
            // 
            this.btnSaveEmails.BackColor = System.Drawing.Color.Khaki;
            this.btnSaveEmails.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveEmails.Location = new System.Drawing.Point(23, 454);
            this.btnSaveEmails.Name = "btnSaveEmails";
            this.btnSaveEmails.Size = new System.Drawing.Size(143, 51);
            this.btnSaveEmails.TabIndex = 11;
            this.btnSaveEmails.Text = "Save Emails";
            this.btnSaveEmails.UseVisualStyleBackColor = false;
            this.btnSaveEmails.Click += new System.EventHandler(this.btnSaveEmails_Click);
            // 
            // cbAutoPaste
            // 
            this.cbAutoPaste.AutoSize = true;
            this.cbAutoPaste.Checked = true;
            this.cbAutoPaste.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoPaste.Location = new System.Drawing.Point(815, 13);
            this.cbAutoPaste.Name = "cbAutoPaste";
            this.cbAutoPaste.Size = new System.Drawing.Size(178, 17);
            this.cbAutoPaste.TabIndex = 12;
            this.cbAutoPaste.Text = "Paste Placeholder when clicked";
            this.cbAutoPaste.UseVisualStyleBackColor = true;
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lblRepeat.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRepeat.Location = new System.Drawing.Point(894, 214);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(143, 23);
            this.lblRepeat.TabIndex = 13;
            this.lblRepeat.Text = "#caseRepeaterStart#";
            this.lblRepeat.Click += new System.EventHandler(this.copyToClip_Click);
            this.lblRepeat.MouseHover += new System.EventHandler(this.toolTipPH_MouseHover);
            // 
            // lblRepeatEnd
            // 
            this.lblRepeatEnd.AutoSize = true;
            this.lblRepeatEnd.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lblRepeatEnd.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRepeatEnd.Location = new System.Drawing.Point(894, 247);
            this.lblRepeatEnd.Name = "lblRepeatEnd";
            this.lblRepeatEnd.Size = new System.Drawing.Size(136, 23);
            this.lblRepeatEnd.TabIndex = 14;
            this.lblRepeatEnd.Text = "#caseRepeaterEnd#";
            this.lblRepeatEnd.Click += new System.EventHandler(this.copyToClip_Click);
            this.lblRepeatEnd.MouseHover += new System.EventHandler(this.toolTipPH_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1139, 622);
            this.Controls.Add(this.pnlProcessRunning);
            this.Controls.Add(this.pnlUserManagment);
            this.Controls.Add(this.pnlEmailLayout);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUserManagment.ResumeLayout(false);
            this.pnlUserManagment.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlProcessRunning.ResumeLayout(false);
            this.pnlProcessRunning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnlEmailLayout.ResumeLayout(false);
            this.pnlEmailLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmailLayout;
        private System.Windows.Forms.Button btnUserManagment;
        private System.Windows.Forms.Panel pnlUserManagment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckBox cbAllActive;
        private System.Windows.Forms.CheckBox cbAllGroup;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.CheckBox cbGroupEmails;
        private System.Windows.Forms.CheckBox cbSendEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chCheckCase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.TextBox tbExcelFileLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRunProcess;
        private System.Windows.Forms.TextBox tbExcelFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlProcessRunning;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox lbCases;
        private System.Windows.Forms.Label lblSummery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTeam;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnSendEmails;
        private System.Windows.Forms.Panel pnlEmailLayout;
        private System.Windows.Forms.RichTextBox rtbEmailSingleFormat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPHlastActivity;
        private System.Windows.Forms.Label lblPHcaseAge;
        private System.Windows.Forms.Label lblPHuserTeam;
        private System.Windows.Forms.Label lblPHcaseId;
        private System.Windows.Forms.Label lblPHuserEmail;
        private System.Windows.Forms.Label lblPHUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbGroupEmailFormat;
        private System.Windows.Forms.Button btnSaveEmails;
        private System.Windows.Forms.CheckBox cbAutoPaste;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.Label lblRepeatEnd;
    }
}

