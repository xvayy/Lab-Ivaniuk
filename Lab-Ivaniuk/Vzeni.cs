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
    public partial class Vzeni : Form
    {
        public Vzeni()
        {
            InitializeComponent();
        }

        private void Vzeni_Load(object sender, EventArgs e)
        {
            this.Height = 490;
            this.Width = 1015;

            h.bsl = new BindingSource();
            h.bsl.DataSource = h.myfunDt("SELECT * FROM sqlkn24_2_iyua.vzeni");
            dataGridView1.DataSource = h.bsl;
            bindingNavigator1.BindingSource = h.bsl;

            h.bsl.Sort = "address";
            DGWFormat();

            DataTable dtBorder = new DataTable();
            DataTable dtDistinct = new DataTable();
            dtBorder = h.myfunDt("SELECT MIN(birthday) AS min_birthday, MAX(birthday) AS max_birthday, MIN(rating) AS min_rank, MAX(rating) AS max_rank FROM sqlkn24_2_iyua.vzeni");
            dtDistinct = h.myfunDt("SELECT DISTINCT address FROM sqlkn24_2_iyua.vzeni");

            txtReitFrom.Text = dtBorder.Rows[0][2].ToString();
            txtReitTo.Text = dtBorder.Rows[0][3].ToString();

            //MessageBox.Show((dtBorder.Rows[0][0].ToString()));
            dtpFrom.Value = Convert.ToDateTime(dtBorder.Rows[0][0].ToString());
            dtpTo.Value = Convert.ToDateTime(dtBorder.Rows[0][1].ToString());

            comboBoxAdres.Items.Add("");
            for (int i = 0; i < dtDistinct.Rows.Count; i++)
            {
                comboBoxAdres.Items.Add(dtDistinct.Rows[i][0].ToString());
            }
            comboBoxAdres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.Items.Add("");
            comboBoxSex.Items.Add("Чоловік");
            comboBoxSex.Items.Add("Жінка");
            comboBoxSex.Text = "Чоловік";
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;


            comboBoxPhone.Items.Add("");
            comboBoxPhone.Items.Add("Vodafone");
            comboBoxPhone.Items.Add("Kyivstar");
            comboBoxPhone.Items.Add("Lifecell");
            comboBoxPhone.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        void DGWFormat() 
        {
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[0].HeaderText = "N";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (btnFind.Checked)
            {
                findLabeel.Visible = true;
                txtFind.Visible = true;
                txtFind.Focus();
            }
            else
            {
                CancelFind();
            }
        }
        
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                { 
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtFind.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
    
        private void txtFind_Leave(object sender, EventArgs e)
        {
            CancelFind();
            btnFind.Checked = false;

        }

        private void CancelFind()
        {
            findLabeel.Visible = false;
            txtFind.Visible = false;
            txtFind.Text = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.DarkViolet, 1);

            gfx.DrawLine(p, 0, 5, 5, 5); // Top horizontal line
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2); // Left vertical line
            gfx.DrawLine(p, 0, e.ClipRectangle.Height - 2, 5, e.ClipRectangle.Height - 2); // Bottom horizontal line
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2); // Right vertical line
        
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (btnFilter.Checked)
            {
                this.Height = 650;
                groupBox1.Visible = true;
            }
            else
            {
                this.Height = 490;
                groupBox1.Visible = false;
            }
        }

        private void btnFilterOk_Click(object sender, EventArgs e)
        {
            this.Width = 1015;
            pictureBox1.Image = null;

            string strFilter = "";
            strFilter += "id_vch > 0";
            if (txtLastName.Text != "")
            { 
                strFilter += " AND last_name LIKE '" + txtLastName.Text + "%'";
            }
            //MessageBox.Show(strFilter);


            // Рейтинг
            if ((txtReitFrom.Text != "") && (txtReitTo.Text != ""))
            {
                strFilter += " AND (rating >= " + txtReitFrom.Text.ToString().Replace(',', '.') + " AND rating <= " + txtReitTo.Text.ToString().Replace(',', '.') + ")";
                //MessageBox.Show(strFilter);
            }
            else if ((txtReitFrom.Text != "") && (txtReitTo.Text == ""))
                strFilter += " AND (rating >= " + txtReitFrom.Text.ToString().Replace(',', '.') + ")";
            else if ((txtReitFrom.Text == "") && (txtReitTo.Text != ""))
                strFilter += " AND (rating <= " + txtReitTo.Text.ToString().Replace(',', '.') + ")";

            // День народження
            strFilter += " AND (birthday >= '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' AND birthday <= '" + dtpTo.Value.ToString("yyyy-MM-dd") + "')";

            if (comboBoxAdres.Text != "") 
            {
                strFilter += " AND (address = '" + comboBoxAdres.Text + "')";

            }

            // Стать
            if (String.Equals(comboBoxSex.Text, "Чоловік"))
            {
                strFilter += " AND (sex = TRUE)";
            } else if (String.Equals(comboBoxSex.Text, "Жінка"))
            {
                strFilter += " AND (sex = FALSE)";
            }


            // Мобільний оператор
            if (String.Equals(comboBoxPhone.Text, "Vodafone"))
            {
                strFilter += " AND (phone LIKE '+38050%' OR phone LIKE '+38066%' OR phone LIKE '+38095%' OR phone LIKE '+38099%')";
            }
            else if (String.Equals(comboBoxPhone.Text, "Kyivstar"))
            {
                strFilter += " AND (phone LIKE '+38067%' OR phone LIKE '+38068%' OR phone LIKE '+38096%' OR phone LIKE '+38097%' OR phone LIKE '+38098%')";
            }
            else if (String.Equals(comboBoxPhone.Text, "Lifecell"))
            {
                strFilter += " AND (phone LIKE '+38063%' OR phone LIKE '+38073%' OR phone LIKE '+38093%')";
            }


            h.bsl.Filter = strFilter;
        }

        private void btnFilterCancel_Click(object sender, EventArgs e)
        {
            h.bsl.RemoveFilter();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
            h.bsl.DataSource = h.myfunDt("SELECT * FROM sqlkn24_2_iyua.vzeni");
            dataGridView1.DataSource = h.bsl;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            h.currentValue = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            Delete delete = new Delete();
            delete.ShowDialog();

            h.bsl.DataSource = h.myfunDt("SELECT * FROM sqlkn24_2_iyua.vzeni");
            dataGridView1.DataSource = h.bsl;
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            h.keyName = dataGridView1.Columns[0].Name;
            h.currentValue = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();

            int curColInx = dataGridView1.CurrentCellAddress.X;
            string curColName = dataGridView1.Columns[curColInx].Name;
            string newCurCellVal = e.Value.ToString();

            // Текстові значення — лапки
            if (curColName == "first_name" || curColName == "last_name" ||
                curColName == "address" || curColName == "phone")
            {
                newCurCellVal = "'" + newCurCellVal + "'";
            }

            // Дата — форматування і лапки
            else if (curColName == "birthday")
            {
                newCurCellVal = Convert.ToDateTime(newCurCellVal).ToString("yyyy-MM-dd");
                newCurCellVal = "'" + newCurCellVal + "'";
            }

            // Число з плаваючою комою (дійсне число) — крапка
            else if (curColName == "rating")
            {
                newCurCellVal = newCurCellVal.Replace(',', '.');
            }

            // BIT — перевіряється як 0 або 1, без лапок
            else if (curColName == "sex")
            {
                if (newCurCellVal != "0" && newCurCellVal != "1")
                    newCurCellVal = "0";
            }


            string sqlStr = "UPDATE sqlkn24_2_iyua.vzeni SET " + curColName + " = " + newCurCellVal +
                            " WHERE " + h.keyName + "=" + h.currentValue;

            MessageBox.Show(sqlStr);

            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            h.currentValue = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            EditVzeniTable edit = new EditVzeniTable();
            edit.ShowDialog();

            h.bsl.DataSource = h.myfunDt("SELECT * FROM sqlkn24_2_iyua.vzeni");
            dataGridView1.DataSource = h.bsl;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rIndx = e.RowIndex;
                int cIndx = dataGridView1.Columns["photo"].Index; // або замінити на точний індекс, якщо не знаєш ім'я

                if (rIndx >= 0 && dataGridView1.Rows[rIndx].Cells[cIndx].Value != DBNull.Value)
                {
                    byte[] masBytes = (byte[])dataGridView1.Rows[rIndx].Cells[cIndx].Value;
                    using (MemoryStream memImage = new MemoryStream(masBytes))
                    {
                        this.Width = 1240;
                        pictureBox1.Image = Image.FromStream(memImage);
                        this.pictureBox1.Location = new System.Drawing.Point(24, 0);
                        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                        //MessageBox.Show("PHOTOOOO");
                    }
                }
                else
                {
                    this.Width = 1240;
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\" + "no_photo.png");
                    this.pictureBox1.Location = new System.Drawing.Point(24, 120);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні зображення: " + ex.Message);
            }
        }


    }
}
