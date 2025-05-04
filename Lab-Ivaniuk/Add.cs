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


                string sqlQuery = "INSERT INTO sqlkn24_2_iyua.vzeni" +
                    "(id_vch, first_name, last_name, address, phone, rating, sex, birthday)" +
                    "VALUES(@id, @firstName, @lastName, @city, @phone, @rating, @sex, @birthday)";

                MySqlCommand command = new MySqlCommand(sqlQuery, conection);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@rating", rating);
                command.Parameters.AddWithValue("@sex", sex);
                command.Parameters.AddWithValue("@birthday", birthday);

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
    }
}
