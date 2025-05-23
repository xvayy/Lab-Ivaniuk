namespace Lab_Ivaniuk
{
    partial class EditUserType
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTypeUser = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditTypeUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Користувач:";
            // 
            // cmbNameUser
            // 
            this.cmbNameUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameUser.FormattingEnabled = true;
            this.cmbNameUser.Location = new System.Drawing.Point(272, 54);
            this.cmbNameUser.Name = "cmbNameUser";
            this.cmbNameUser.Size = new System.Drawing.Size(121, 21);
            this.cmbNameUser.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Тип доступу";
            // 
            // cmbTypeUser
            // 
            this.cmbTypeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeUser.FormattingEnabled = true;
            this.cmbTypeUser.Location = new System.Drawing.Point(272, 120);
            this.cmbTypeUser.Name = "cmbTypeUser";
            this.cmbTypeUser.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeUser.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(235, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 36);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditTypeUser
            // 
            this.btnEditTypeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditTypeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTypeUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditTypeUser.Location = new System.Drawing.Point(105, 203);
            this.btnEditTypeUser.Name = "btnEditTypeUser";
            this.btnEditTypeUser.Size = new System.Drawing.Size(97, 36);
            this.btnEditTypeUser.TabIndex = 34;
            this.btnEditTypeUser.Text = "Змінити";
            this.btnEditTypeUser.UseVisualStyleBackColor = false;
            this.btnEditTypeUser.Click += new System.EventHandler(this.btnEditTypeUser_Click);
            // 
            // EditUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 273);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditTypeUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTypeUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNameUser);
            this.Name = "EditUserType";
            this.Text = "Змінити тип доступу користувача";
            this.Load += new System.EventHandler(this.EditUserType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNameUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTypeUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditTypeUser;
    }
}