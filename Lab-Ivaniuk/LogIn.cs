using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Lab_Ivaniuk
{
    public partial class LogIn : Form
    {
        private string[,] matrix;
        private DataTable dt;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            h.ConStr = "server=194.44.236.9; database=sqlkn24_2_iyua; user=sqlkn24_2_iyua; password=kn24_iyua; charset=cp1251;";
            dt = h.myfunDt("SELECT * FROM Users");

            int kilkz = dt.Rows.Count;
            matrix = new string[kilkz, 4];

            for (int i = 0; i < kilkz; i++)
            {
                matrix[i, 0] = dt.Rows[i].Field<int>("Id").ToString();
                matrix[i, 1] = dt.Rows[i].Field<string>("UserName");
                matrix[i, 2] = dt.Rows[i].Field<int>("Type").ToString();
                matrix[i, 3] = dt.Rows[i].Field<string>("Password");
                cbxUser.Items.Add(matrix[i, 1]);
            }

            cbxUser.Text = matrix[0, 1];
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Focus();
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //textBox1.Text = h.EncryptedPassword_MD5(txtPassword.Text);
            //textBox1.Text = h.EncryptedPassword_SHA256(txtPassword.Text);

            Avtorization();
        }

        private void Avtorization()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (String.Equals(cbxUser.Text.ToUpper(), matrix[i, 1].ToUpper()))
                {
                    if (String.Equals(h.EncryptedPassword_MD5(txtPassword.Text), matrix[i, 3]))
                    {
                        this.Hide();
                        myBD f1 = new myBD();
                        f1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Введіть правильний пароль!", "Помилка авторизації",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter)
               Avtorization();
            else if (e.KeyCode == Keys.Escape)
                Application.Exit();

        }

        
    
    }
    public static class h
    {
        public static string ConStr;
        public static int typeUser;
        public static string nameUser;
        public static BindingSource bsl;
        public static string currentValue;
        public static string keyName;

        public static DataTable myfunDt(string commanding)
                {
                    DataTable dt = new DataTable();
                    using (MySqlConnection con = new MySqlConnection(h.ConStr))
                    {
                        MySqlCommand cmd = new MySqlCommand(commanding, con);
                        try
                        {
                            con.Open();
                            using (MySqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.HasRows)
                                {
                                    dt.Load(dr);
                                }
                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка з'єднання з SQL-сервером! Перевірте підключення до Інтернету...",
                                ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return dt;
                }

        public static string EncryptedPassword_MD5(string str)
        {
            if (string.Compare(str, "null", true) == 0) return "null";
            byte[] bytes = Encoding.Unicode.GetBytes(str);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }

        public static string EncryptedPassword_SHA256(string str) 
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(str));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


    }
}
