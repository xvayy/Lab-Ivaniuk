﻿using System;
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
            Calcul calcul = new Calcul();
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
    }
}
