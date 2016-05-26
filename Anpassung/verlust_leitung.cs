using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using helper;

namespace Anpassung
{
    public partial class verlust_leitung : Form
    {
        verlust_leitung_class verlust_leitung_class = new verlust_leitung_class();

        /*
        Engineering engineering = new Engineering();
        Engineering loadr = new Engineering();
        Engineering loadi = new Engineering();
        Engineering voltagek = new Engineering();
        Engineering powerr = new Engineering();
        */

        public verlust_leitung()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set error flag invisible
            label10.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set error flag invisible
            label10.Visible = false;
            try
            {
                // Delete all existing rows
                while (dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }

                // Set values to object
                verlust_leitung_class.setUq(Convert.ToDouble(textBox1.Text));
                verlust_leitung_class.setLength(Convert.ToDouble(textBox2.Text) * 1000);
                verlust_leitung_class.setArea(Convert.ToDouble(textBox3.Text));
                verlust_leitung_class.setDeltaI(Convert.ToDouble(textBox5.Text));
                verlust_leitung_class.setNumbers(Convert.ToInt32(textBox4.Text));

                // Calculate values
                for (int y = 0; y <= verlust_leitung_class.getNumbers() - 1; y++)
                {
                    verlust_leitung_class.setValue(y);

                    dataGridView1.Rows.Add( Convert.ToString(verlust_leitung_class.getI()),
                                            Convert.ToString(verlust_leitung_class.getR()),
                                            Convert.ToString(verlust_leitung_class.getPl()),
                                            Convert.ToString(verlust_leitung_class.getUk())
                                            );
                }
            }
            catch (Exception)
            {
                // Set error flag visible
                label10.Visible = true;
                MessageBox.Show("Es ist ein Eingabefehler aufetreten!");
            }
        }
    }
}
