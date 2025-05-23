using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab_Ivaniuk
{
    public partial class EditUserPassword : Form
    {
        private DataTable dtUserName;

        public EditUserPassword()
        {
            InitializeComponent();
        }
        private void EditUserPassword_Load(object sender, EventArgs e)
        {
            dtUserName = h.myfunDt("SELECT * FROM Users");
            for (int i = 0; i < dtUserName.Rows.Count; i++)
            {
                cmbNameUser.Items.Add(dtUserName.Rows[i][1].ToString());
            }
            cmbNameUser.Text = dtUserName.Rows[0][1].ToString();
        }
        private void btnEditUserPassword_Click(object sender, EventArgs e)
        {
            if (String.Equals(txtPassword1User.Text, txtPassword2User.Text) && txtPassword1User.Text != "")
            {
                string sqlcmd = "UPDATE Users SET Password = '" +
                                h.EncryptedPassword_MD5(txtPassword1User.Text) +
                                "' WHERE UserName = '" + cmbNameUser.Text + "'";
                MySqlConnection con = new MySqlConnection(h.ConStr);
                MySqlCommand cmdAdd = new MySqlCommand(sqlcmd, con);
                con.Open();
                cmdAdd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Пароль користувача '" + cmbNameUser.Text +
                                "'\nуспішно змінено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Паролі не співпадають\n або не введені!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword1User.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
