namespace Lab_Ivaniuk
{
    partial class EditUserPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNameUser = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditUserPassword = new System.Windows.Forms.Button();
            this.txtPassword2User = new System.Windows.Forms.TextBox();
            this.txtPassword1User = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(78, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Користувач:";
            // 
            // cmbNameUser
            // 
            this.cmbNameUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameUser.FormattingEnabled = true;
            this.cmbNameUser.Location = new System.Drawing.Point(297, 77);
            this.cmbNameUser.Name = "cmbNameUser";
            this.cmbNameUser.Size = new System.Drawing.Size(121, 21);
            this.cmbNameUser.TabIndex = 28;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(251, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 36);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditUserPassword
            // 
            this.btnEditUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditUserPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditUserPassword.Location = new System.Drawing.Point(121, 276);
            this.btnEditUserPassword.Name = "btnEditUserPassword";
            this.btnEditUserPassword.Size = new System.Drawing.Size(97, 36);
            this.btnEditUserPassword.TabIndex = 26;
            this.btnEditUserPassword.Text = "Змінити";
            this.btnEditUserPassword.UseVisualStyleBackColor = false;
            this.btnEditUserPassword.Click += new System.EventHandler(this.btnEditUserPassword_Click);
            // 
            // txtPassword2User
            // 
            this.txtPassword2User.Location = new System.Drawing.Point(297, 188);
            this.txtPassword2User.Name = "txtPassword2User";
            this.txtPassword2User.Size = new System.Drawing.Size(119, 20);
            this.txtPassword2User.TabIndex = 33;
            this.txtPassword2User.UseSystemPasswordChar = true;
            // 
            // txtPassword1User
            // 
            this.txtPassword1User.Location = new System.Drawing.Point(299, 131);
            this.txtPassword1User.Name = "txtPassword1User";
            this.txtPassword1User.Size = new System.Drawing.Size(119, 20);
            this.txtPassword1User.TabIndex = 32;
            this.txtPassword1User.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(78, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 48);
            this.label4.TabIndex = 31;
            this.label4.Text = "Підтвердження\r\nпаролю";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(78, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Новий пароль";
            // 
            // EditUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 351);
            this.Controls.Add(this.txtPassword2User);
            this.Controls.Add(this.txtPassword1User);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNameUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditUserPassword);
            this.Name = "EditUserPassword";
            this.Text = "Зміна паролю користувача";
            this.Load += new System.EventHandler(this.EditUserPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNameUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditUserPassword;
        private System.Windows.Forms.TextBox txtPassword2User;
        private System.Windows.Forms.TextBox txtPassword1User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}