﻿
namespace DBPROJECT
{
    partial class frmUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserProfile));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSMTPport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSMTPHOST = new System.Windows.Forms.TextBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pkrBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OldLace;
            this.groupBox2.Controls.Add(this.btnChangePwd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSMTPport);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSMTPHOST);
            this.groupBox2.Controls.Add(this.cbxGender);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pkrBirthdate);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtLoginName);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangePwd.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePwd.Image")));
            this.btnChangePwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePwd.Location = new System.Drawing.Point(24, 220);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(190, 29);
            this.btnChangePwd.TabIndex = 114;
            this.btnChangePwd.Text = "Change User Password";
            this.btnChangePwd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangePwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePwd.UseVisualStyleBackColor = true;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 113;
            this.label4.Text = "SMTP Port";
            // 
            // txtSMTPport
            // 
            this.txtSMTPport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMTPport.Location = new System.Drawing.Point(105, 115);
            this.txtSMTPport.Name = "txtSMTPport";
            this.txtSMTPport.Size = new System.Drawing.Size(299, 22);
            this.txtSMTPport.TabIndex = 2;
            this.txtSMTPport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableSaveButton);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 111;
            this.label3.Text = "SMTP Host";
            // 
            // txtSMTPHOST
            // 
            this.txtSMTPHOST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMTPHOST.Location = new System.Drawing.Point(105, 83);
            this.txtSMTPHOST.Name = "txtSMTPHOST";
            this.txtSMTPHOST.Size = new System.Drawing.Size(299, 22);
            this.txtSMTPHOST.TabIndex = 1;
            this.txtSMTPHOST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableSaveButton);
            // 
            // cbxGender
            // 
            this.cbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "FEMALE",
            "MALE"});
            this.cbxGender.Location = new System.Drawing.Point(105, 178);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(121, 24);
            this.cbxGender.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(11, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(11, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Birthdate";
            // 
            // pkrBirthdate
            // 
            this.pkrBirthdate.CustomFormat = "";
            this.pkrBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkrBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pkrBirthdate.Location = new System.Drawing.Point(105, 146);
            this.pkrBirthdate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.pkrBirthdate.Name = "pkrBirthdate";
            this.pkrBirthdate.Size = new System.Drawing.Size(121, 22);
            this.pkrBirthdate.TabIndex = 3;
            this.pkrBirthdate.Value = new System.DateTime(2023, 3, 19, 0, 0, 0, 0);
            this.pkrBirthdate.ValueChanged += new System.EventHandler(this.pkrBirthdate_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(105, 51);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 22);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableSaveButton);
            // 
            // txtLoginName
            // 
            this.txtLoginName.AcceptsReturn = true;
            this.txtLoginName.AcceptsTab = true;
            this.txtLoginName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginName.Location = new System.Drawing.Point(105, 19);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.ReadOnly = true;
            this.txtLoginName.Size = new System.Drawing.Size(299, 22);
            this.txtLoginName.TabIndex = 109;
            this.txtLoginName.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRefresh.ImageKey = "refresh-icon-png-40262-Windows.ico";
            this.btnRefresh.Location = new System.Drawing.Point(313, 218);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 29);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(220, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnableSaveButton);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login Name";
            // 
            // picBoxUser
            // 
            this.picBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUser.Image")));
            this.picBoxUser.Location = new System.Drawing.Point(76, 12);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(265, 183);
            this.picBoxUser.TabIndex = 25;
            this.picBoxUser.TabStop = false;
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadPhoto.Image")));
            this.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPhoto.Location = new System.Drawing.Point(76, 210);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(150, 29);
            this.btnLoadPhoto.TabIndex = 27;
            this.btnLoadPhoto.Text = "Load New Photo";
            this.btnLoadPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadPhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadPhoto.UseVisualStyleBackColor = true;
            this.btnLoadPhoto.Click += new System.EventHandler(this.btnLoadPhoto_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(241, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 29);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear Photo";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(426, 506);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoadPhoto);
            this.Controls.Add(this.picBoxUser);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserProfile";
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSMTPport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSMTPHOST;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker pkrBirthdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Button btnLoadPhoto;
        private System.Windows.Forms.Button btnClear;
    }
}