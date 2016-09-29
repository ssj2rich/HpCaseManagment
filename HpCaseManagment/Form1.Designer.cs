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
            this.btnUserManagment = new System.Windows.Forms.Button();
            this.btnEmailLayout = new System.Windows.Forms.Button();
            this.pnlUserManagment = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSendEmail = new System.Windows.Forms.CheckBox();
            this.cbGroupEmails = new System.Windows.Forms.CheckBox();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.cbAllGroup = new System.Windows.Forms.CheckBox();
            this.cbAllActive = new System.Windows.Forms.CheckBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlUserManagment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnEmailLayout);
            this.panel1.Controls.Add(this.btnUserManagment);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnUserManagment
            // 
            this.btnUserManagment.BackColor = System.Drawing.Color.LightBlue;
            this.btnUserManagment.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagment.Location = new System.Drawing.Point(3, 3);
            this.btnUserManagment.Name = "btnUserManagment";
            this.btnUserManagment.Size = new System.Drawing.Size(221, 44);
            this.btnUserManagment.TabIndex = 0;
            this.btnUserManagment.Text = "Users Managment";
            this.btnUserManagment.UseVisualStyleBackColor = false;
            // 
            // btnEmailLayout
            // 
            this.btnEmailLayout.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEmailLayout.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailLayout.Location = new System.Drawing.Point(230, 3);
            this.btnEmailLayout.Name = "btnEmailLayout";
            this.btnEmailLayout.Size = new System.Drawing.Size(221, 44);
            this.btnEmailLayout.TabIndex = 1;
            this.btnEmailLayout.Text = "Email Layout";
            this.btnEmailLayout.UseVisualStyleBackColor = false;
            // 
            // pnlUserManagment
            // 
            this.pnlUserManagment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserManagment.BackColor = System.Drawing.Color.Gainsboro;
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
            this.pnlUserManagment.Location = new System.Drawing.Point(13, 70);
            this.pnlUserManagment.Name = "pnlUserManagment";
            this.pnlUserManagment.Size = new System.Drawing.Size(1025, 386);
            this.pnlUserManagment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Email";
            // 
            // cbSendEmail
            // 
            this.cbSendEmail.AutoSize = true;
            this.cbSendEmail.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSendEmail.Location = new System.Drawing.Point(304, 105);
            this.cbSendEmail.Name = "cbSendEmail";
            this.cbSendEmail.Size = new System.Drawing.Size(174, 27);
            this.cbSendEmail.TabIndex = 2;
            this.cbSendEmail.Text = "Send Email ? (is active)";
            this.cbSendEmail.UseVisualStyleBackColor = true;
            // 
            // cbGroupEmails
            // 
            this.cbGroupEmails.AutoSize = true;
            this.cbGroupEmails.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroupEmails.Location = new System.Drawing.Point(304, 151);
            this.cbGroupEmails.Name = "cbGroupEmails";
            this.cbGroupEmails.Size = new System.Drawing.Size(224, 27);
            this.cbGroupEmails.TabIndex = 3;
            this.cbGroupEmails.Text = "Group Emails ? (if more then 1)";
            this.cbGroupEmails.UseVisualStyleBackColor = true;
            // 
            // lbUsers
            // 
            this.lbUsers.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 28;
            this.lbUsers.Location = new System.Drawing.Point(4, 21);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(279, 340);
            this.lbUsers.TabIndex = 4;
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
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(431, 65);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(311, 28);
            this.tbEmail.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(304, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 39);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1050, 468);
            this.Controls.Add(this.pnlUserManagment);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.pnlUserManagment.ResumeLayout(false);
            this.pnlUserManagment.PerformLayout();
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
    }
}

