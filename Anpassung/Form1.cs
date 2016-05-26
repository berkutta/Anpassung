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
    public partial class Form1 : Form
    {
        adjustment anpassung = new adjustment();
        Engineering engineering = new Engineering();
        Engineering loadr = new Engineering();
        Engineering loadi = new Engineering();
        Engineering voltagek = new Engineering();
        Engineering powerr = new Engineering();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                while (dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }

                engineering.setEngineering(textBox1.Text);
                anpassung.setUq(engineering.getValue());

                engineering.setEngineering(textBox2.Text);
                anpassung.setRi(engineering.getValue());

                engineering.setEngineering(textBox3.Text);
                anpassung.setDeltaR(engineering.getValue());

                anpassung.setNumbers(Convert.ToInt32(textBox4.Text));


                for (int y = 0; y <= anpassung.getNumbers() - 1; y++)
                {
                    anpassung.setValue(y);

                    loadr.setValue(anpassung.getRl());
                    loadi.setValue(anpassung.getIl());
                    voltagek.setValue(anpassung.getUk());
                    powerr.setValue(anpassung.getPl());

                    dataGridView1.Rows.Add( loadr.getEngineering(),
                                            loadi.getEngineering(),
                                            voltagek.getEngineering(),
                                            powerr.getEngineering() );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Es ist ein Eingabefehler aufetreten!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
