using MySql.Data.MySqlClient;
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

namespace Lab_Ivaniuk
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conection = new MySqlConnection(h.ConStr))
            { 
                string id = txtID.Text;
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string city = txtCity.Text;
                string phone = txtPhone.Text;
                string rating = txtRating.Text;
                bool sex = txtSex.Text == "Чоловік";
                string birthday = txtBirthday.Text;

                string strFileName = h.pathToPhoto;
                FileStream fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);

                int fileSize = (Int32)fs.Length;
                byte[] bytesArr = new byte[fileSize];
                fs.Read(bytesArr, 0, fileSize);
                fs.Close();


                string sqlQuery = "INSERT INTO sqlkn24_2_iyua.vzeni" +
                    "(id_vch, first_name, last_name, address, phone, rating, sex, birthday, photo)" +
                    "VALUES(@id, @firstName, @lastName, @city, @phone, @rating, @sex, @birthday, @photo)";

                MySqlCommand command = new MySqlCommand(sqlQuery, conection);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@rating", rating);
                command.Parameters.AddWithValue("@sex", sex);
                command.Parameters.AddWithValue("@birthday", birthday);

                command.Parameters.AddWithValue("@photo", bytesArr);


                conection.Open();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Дані успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conection.Close();
                    this.Close();
                }
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {
            h.pathToPhoto = Application.StartupPath + @"\" + "scientist1.png";
            pictureBox1.Image = Image.FromFile(h.pathToPhoto);
        }

        private void btnChosePhoto_Click(object sender, EventArgs e)
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
