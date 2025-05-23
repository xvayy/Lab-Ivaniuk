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
    public partial class EditUserType : Form
    {
        private DataTable dtUserName;

        public EditUserType()
        {
            InitializeComponent();
        }
        private void EditUserType_Load(object sender, EventArgs e)
        {
            dtUserName = h.myfunDt("SELECT * FROM Users");
            for (int i = 0; i < dtUserName.Rows.Count; i++)
            {
                cmbNameUser.Items.Add(dtUserName.Rows[i][1].ToString());
            }
            cmbNameUser.Text = dtUserName.Rows[0][1].ToString();

            cmbTypeUser.Items.Add("1");
            cmbTypeUser.Items.Add("2");
            cmbTypeUser.Items.Add("3");

            
        }

        private void btnEditTypeUser_Click(object sender, EventArgs e)
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
                string sqlcmd = "UPDATE Users SET Type = '" + cmbTypeUser.Text +
                                "' WHERE UserName = '" + cmbNameUser.Text + "'";
                MySqlConnection con = new MySqlConnection(h.ConStr);
                MySqlCommand cmdAdd = new MySqlCommand(sqlcmd, con);
                con.Open();
                cmdAdd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Тип користувача '" + cmbNameUser.Text + "'\nуспішно змінено!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ви не можете змінити тип користувача '" +
                                cmbNameUser.Text + "'!\nЦе єдиний адміністратор!", "Увага!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTypeUser.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
