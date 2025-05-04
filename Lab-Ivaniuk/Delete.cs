using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Ivaniuk
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        private void Delete_Load(object sender, EventArgs e)
        {
            textBox1.Text = h.keyName + " = " + h.currentValue;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlQuery = "DELETE FROM sqlkn24_2_iyua.vzeni WHERE " + textBox1.Text;


            if (MessageBox.Show("Ви впевнені, що хочете видалити запис", "Видаленнееея",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(h.ConStr))
                {
                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запис видалено", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
