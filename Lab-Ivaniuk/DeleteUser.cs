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
    public partial class DeleteUser : Form
    {
        private DataTable dtUserName;

        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            dtUserName = h.myfunDt("SELECT * FROM Users");
            for (int i = 0; i < dtUserName.Rows.Count; i++)
            {
                cmbNameUser.Items.Add(dtUserName.Rows[i][1].ToString());
            }
            cmbNameUser.Text = dtUserName.Rows[0][1].ToString();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int countAdm = 0; // кількість адміністраторів
            for (int i = 0; i < dtUserName.Rows.Count; i++)
            {
                if (int.Parse(dtUserName.Rows[i][2].ToString()) == 1)
                    countAdm += 1;
            }
            // перевірка чи єдиний адмін
            if (countAdm > 1)
            {
                string sqlcmd = "DELETE FROM Users WHERE UserName = '" + cmbNameUser.Text + "'";
                MySqlConnection con = new MySqlConnection(h.ConStr);
                MySqlCommand cmdAdd = new MySqlCommand(sqlcmd, con);
                con.Open();
                cmdAdd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Користувача '" + cmbNameUser.Text + "'\nуспішно видалено!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ви не можете видалити користувача '" +
                                cmbNameUser.Text + "'!\nЦе єдиний адміністратор!", "Увага!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbNameUser.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
