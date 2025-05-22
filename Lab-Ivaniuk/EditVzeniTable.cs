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
    public partial class EditVzeniTable : Form
    {
        public EditVzeniTable()
        {
            InitializeComponent();
        }

        private void btnCancelEditting_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            string sqlStr = "UPDATE sqlkn24_2_iyua.vzeni SET " +
                            txtColumnName.Text + " = " + "'" + txtColumnValue.Text + "'" +
                            " WHERE " + txtWhereName.Text + " = " +
                            txtWhereValue.Text;
            MessageBox.Show(sqlStr);
            if (MessageBox.Show("Ви впевнені що хочете замінити дані?", "Заміна", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(h.ConStr))
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            this.Close();
        }
    }
}
