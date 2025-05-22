namespace Lab_Ivaniuk
{
    partial class EditVzeniTable
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancelEditting = new System.Windows.Forms.Button();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.txtColumnValue = new System.Windows.Forms.TextBox();
            this.txtWhereName = new System.Windows.Forms.TextBox();
            this.txtWhereValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вкажіть полe та його нове \r\nзначення";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Запишіть умову для яких записів\r\n робити заміну значень";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(212, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "SET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(212, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "WHERE";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(141, 208);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Замінити";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancelEditting
            // 
            this.btnCancelEditting.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelEditting.Location = new System.Drawing.Point(277, 208);
            this.btnCancelEditting.Name = "btnCancelEditting";
            this.btnCancelEditting.Size = new System.Drawing.Size(75, 23);
            this.btnCancelEditting.TabIndex = 7;
            this.btnCancelEditting.Text = "Скасувати";
            this.btnCancelEditting.UseVisualStyleBackColor = true;
            this.btnCancelEditting.Click += new System.EventHandler(this.btnCancelEditting_Click);
            // 
            // txtColumnName
            // 
            this.txtColumnName.Location = new System.Drawing.Point(302, 55);
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(100, 20);
            this.txtColumnName.TabIndex = 11;
            // 
            // txtColumnValue
            // 
            this.txtColumnValue.Location = new System.Drawing.Point(421, 55);
            this.txtColumnValue.Name = "txtColumnValue";
            this.txtColumnValue.Size = new System.Drawing.Size(100, 20);
            this.txtColumnValue.TabIndex = 12;
            // 
            // txtWhereName
            // 
            this.txtWhereName.Location = new System.Drawing.Point(296, 150);
            this.txtWhereName.Name = "txtWhereName";
            this.txtWhereName.Size = new System.Drawing.Size(100, 20);
            this.txtWhereName.TabIndex = 13;
            // 
            // txtWhereValue
            // 
            this.txtWhereValue.Location = new System.Drawing.Point(421, 150);
            this.txtWhereValue.Name = "txtWhereValue";
            this.txtWhereValue.Size = new System.Drawing.Size(100, 20);
            this.txtWhereValue.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "колонка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "колонка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "значення";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "значення";
            // 
            // EditVzeniTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 243);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWhereValue);
            this.Controls.Add(this.txtWhereName);
            this.Controls.Add(this.txtColumnValue);
            this.Controls.Add(this.txtColumnName);
            this.Controls.Add(this.btnCancelEditting);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditVzeniTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування записів у таблиці Vzeni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancelEditting;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.TextBox txtColumnValue;
        private System.Windows.Forms.TextBox txtWhereName;
        private System.Windows.Forms.TextBox txtWhereValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}