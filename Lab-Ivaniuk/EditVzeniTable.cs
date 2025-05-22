using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string sqlStr;
            if ((checkBox1.Checked == true) && (checkBox2.Checked == false))
            {
                sqlStr = "UPDATE sqlkn24_2_iyua.vzeni SET " +
                                txtColumnName.Text + " = " + "'" + txtColumnValue.Text + "'" +
                                " WHERE " + txtWhereName.Text + " = " +
                                txtWhereValue.Text;
                MessageBox.Show(sqlStr);
                if (MessageBox.Show("Ви впевнені що хочете замінити дані?", "Заміна", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(h.ConStr))
                    {
                        MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                }

            }

            if ((checkBox1.Checked == false) && (checkBox2.Checked == true))
            {
                int fileSize;
                byte[] bytesArr;
                FileStream fs;
                string fileName;

                fileName = h.pathToPhoto;
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                fileSize = (Int32)fs.Length;
                bytesArr = new byte[fileSize];
                fs.Read(bytesArr, 0, fileSize);
                fs.Close();

                sqlStr = "UPDATE sqlkn24_2_iyua.vzeni SET photo = @File WHERE " + 
                         txtWhereName.Text + " = " + txtWhereValue.Text;

                MessageBox.Show(sqlStr);
                if (MessageBox.Show("Ви впевнені що хочете замінити дані?", "Заміна", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(h.ConStr))
                    {
                        MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                        cmd.Parameters.AddWithValue("@File", bytesArr);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                }
            }


            if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
            {
                int fileSize;
                byte[] bytesArr;
                FileStream fs;
                string fileName;

                fileName = h.pathToPhoto;
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                fileSize = (Int32)fs.Length;
                bytesArr = new byte[fileSize];
                fs.Read(bytesArr, 0, fileSize);
                fs.Close();

                sqlStr = "UPDATE sqlkn24_2_iyua.vzeni SET " +
                         txtColumnName.Text + " = " + "'" + txtColumnValue.Text + "'" + 
                         ", photo = @File WHERE " +
                         txtWhereName.Text + " = " + txtWhereValue.Text;

                MessageBox.Show(sqlStr);
                if (MessageBox.Show("Ви впевнені що хочете замінити дані?", "Заміна",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(h.ConStr))
                    {
                        MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                        cmd.Parameters.AddWithValue("@File", bytesArr);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                }
            }
            this.Close();
        }

        private void EditVzeniTable_Load(object sender, EventArgs e)
        {
            h.pathToPhoto = Application.StartupPath + @"\" + "scientist1.png";
            pictureBox1.Image = Image.FromFile(h.pathToPhoto);
            this.Width = 590;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // SET
                label1.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                label8.Visible = true;
                txtColumnName.Visible = true;
                txtColumnValue.Visible = true;

                // WHERE
                label2.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                txtWhereName.Visible = true;
                txtWhereValue.Visible = true;

                btnEdit.Visible = true;
            }
            else if (checkBox1.Checked == false)
            {

                // SET
                label1.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                label8.Visible = false;
                txtColumnName.Visible = false;
                txtColumnValue.Visible = false;

                // WHERE
                label2.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                txtWhereName.Visible = false;
                txtWhereValue.Visible = false;

                this.Width = 980;
                if (checkBox2.Checked == false)
                {
                    btnEdit.Visible = false;
                    this.Width = 590;
                }

                if (checkBox2.Checked == true)
                {
                    // WHERE
                    label2.Visible = true;
                    label4.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    txtWhereName.Visible = true;
                    txtWhereValue.Visible = true;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                // PHOTO
                panel2.Visible = true;
                pictureBox1.Visible = true;
                btnChosePhoto.Visible = true;
                label9.Visible = true;
                btnEdit.Visible = true;

                // WHERE
                label2.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                txtWhereName.Visible = true;
                txtWhereValue.Visible = true;

                this.Width = 980;
            }
            else if (checkBox2.Checked == false)
            {
                // PHOTO
                panel2.Visible = false;
                pictureBox1.Visible = false;
                btnChosePhoto.Visible = false;
                label9.Visible = false;

                // WHERE
                label2.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                txtWhereName.Visible = false;
                txtWhereValue.Visible = false;

                this.Width = 590;
                if (checkBox1.Checked == false)
                {
                    btnEdit.Visible = false;
                }
                if (checkBox1.Checked == true)
                {
                    label2.Visible = true;
                    label4.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    txtWhereName.Visible = true;
                    txtWhereValue.Visible = true;
                }
            }
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Виберіть фото";
            OFD.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            OFD.InitialDirectory = Application.StartupPath;

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                h.pathToPhoto = OFD.FileName;
                pictureBox1.Image = Image.FromFile(h.pathToPhoto);
            }
            else
            {
                MessageBox.Show("Виберіть фото!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
