using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anpassung
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
        }

        private void Anpassung_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
        }

        private void leitung_verlust_Click(object sender, EventArgs e)
        {
            verlust_leitung Leitung_verlust = new verlust_leitung();

            Leitung_verlust.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            verlust_leitung Leitung_verlust = new verlust_leitung();

            Leitung_verlust.Show();
        }
    }
}
