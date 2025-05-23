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
    public partial class AddNewUser : Form
    {
        private DataTable dtUserName;
        private bool nUser;
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            dtUserName = h.myfunDt("SELECT * FROM Users");
        }

        private void txtNameUser_Leave(object sender, EventArgs e)
        {
            nUser = true;
            if (btnCancel.Focused)
            {
                this.Close();
            }
            else
            {
                for (int i = 0; i < dtUserName.Rows.Count; i++)
                {
                    if (String.Equals(txtNameUser.Text.Trim(), dtUserName.Rows[i][1].ToString())
                        || (String.Equals(txtNameUser.Text, "")))
                    {
                        nUser = false;
                        txtNameUser.Focus();
                        break;
                    }
                }
            }

            if (!nUser)
            {
                MessageBox.Show("Ім'я користувача не заповнено або вже існує!", "УВАГА!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameUser.Focus();
            }
        }

        private void txtTypeUser_Leave(object sender, EventArgs e)
        {
            int g;
            nUser = true;
            // якщо фокус на кнопці "вихід", тоді закриваємо форму
            if (btnCancel.Focused)
            {
                this.Close();
            }
            else // перевірка введеного типу користувача
            {
                if (!int.TryParse(txtTypeUser.Text, out g)) // не число
                {
                    nUser = false;
                    // MessageBox.Show("не число");
                }
                else if (g < 1 || g > 3) // число не в межах 1-3
                {
                    nUser = false;
                    // MessageBox.Show("не в межах");
                }
            }

            if (!nUser) // якщо поле не заповнене, текст або не 1-3, тоді фокус - у ньому
            {
                MessageBox.Show("Не вірний тип користувача!", "УВАГА!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTypeUser.Focus();
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (txtNameUser.Text != "") // Поле користувача не порожнє
            {
                if (txtTypeUser.Text != "") // Поле тип користувача не порожнє
                {
                    if (String.Equals(txtPassword1User.Text, txtPassword2User.Text)) // Паролі співпадають
                    {
                        string sqlcmd = "INSERT INTO Users (UserName, Type, Password) VALUES (@P1, @P2, @P3)";
                        MySqlConnection con = new MySqlConnection(h.ConStr);
                        MySqlCommand cmdAdd = new MySqlCommand(sqlcmd, con);
                        cmdAdd.Parameters.AddWithValue("@P1", txtNameUser.Text);
                        cmdAdd.Parameters.AddWithValue("@P2", txtTypeUser.Text);
                        cmdAdd.Parameters.AddWithValue("@P3", h.EncryptedPassword_MD5(txtPassword1User.Text));
                        con.Open();
                        cmdAdd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Нового користувача '" + txtNameUser.Text + "'\nуспішно додано!");
                        this.Close();
                    }
                    else // Паролі не співпадають
                    {
                        MessageBox.Show("Паролі не співпадають!\nВиправте паролі...", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword1User.Focus();
                    }
                }
                else // Виправити тип користувача
                {
                    MessageBox.Show("Тип доступу не заповнено!\nВиправте тип доступу...", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTypeUser.Focus();
                }
            }
            else // Виправити ім'я користувача
            {
                MessageBox.Show("Поле 'Користувач' не заповнено!\nВиправте будь-ласка ...", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameUser.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
