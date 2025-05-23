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
    public partial class myBD : Form
    {
        public myBD()
        {
            InitializeComponent();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f1 = new About();
            f1.ShowDialog();
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calcul = new Calculator();
            calcul.ShowDialog();
        }

        private void myBD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void openTableBiocenologia_Click(object sender, EventArgs e)
        {
            
        }

        private void openTableVzeni_Click(object sender, EventArgs e)
        {
            Vzeni vzeni = new Vzeni();
            vzeni.ShowDialog();
        }

        private void myBD_Load(object sender, EventArgs e)
        {
            if (h.typeUser != 1)
            {
				адмініструванняToolStripMenuItem.Visible = false;
            }
		}

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser newUser = new AddNewUser();
			newUser.ShowDialog();
		}

        private void видалитиКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser delUser = new DeleteUser();
			delUser.ShowDialog();
		}

        private void змінитиПарольКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserPassword editPassword = new EditUserPassword();
			editPassword.ShowDialog();
		}

        private void змінитиТипДоступуКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserType editType = new EditUserType();
			editType.ShowDialog();
		}

        private void резервнеКопіюванняБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(h.ConStr);
            MySqlCommand cmd = new MySqlCommand("copyUsers", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
				cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Немає з'єднання з сервером!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Резервне копіювання успішно завершено!");

		}

        private void резервнеВідновленняБДToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MySqlConnection con = new MySqlConnection(h.ConStr);
            MySqlCommand cmd = new MySqlCommand("restoreUsers", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
				cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Немає з'єднання з сервером!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Резервне відновлення успішно завершено!");

		}
    }
}
