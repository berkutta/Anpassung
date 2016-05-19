using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hunkeler_aufgabe_2
{
    public partial class Form1 : Form
    {
        Anpassung anpassung = new Anpassung();
        Engineering engineering = new Engineering();

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

                
                anpassung.setUq(Convert.ToDouble(textBox1.Text));

                engineering.setEngineering(textBox2.Text);
                anpassung.setRi(engineering.getValue());

                engineering.setEngineering(textBox3.Text);
                anpassung.setDeltaR(engineering.getValue());
                
                anpassung.setNumbers(Convert.ToInt32(textBox4.Text));


                for (int y = 0; y <= anpassung.getNumbers(); y++)
                {
                    anpassung.setValue(y);
                    dataGridView1.Rows.Add( anpassung.getRl().ToString("0.00"),
                                            anpassung.getIl().ToString("0.00"),
                                            anpassung.getUk().ToString("0.00"),
                                            anpassung.getPl().ToString("0.00") );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Es ist ein Fehler aufetreten!");
            }
        }
    }

    class Anpassung
    {
        double uq, ri, rl, deltaR;
        int value, numbers;

        public void setUq(double uq)
        {
            this.uq = uq;
        }

        public void setRi(double ri)
        {
            this.ri = ri;
        }

        public void setRl(double rl)
        {
            this.rl = rl;
        }

        public void setDeltaR(double deltaR)
        {
            this.deltaR = deltaR;
        }

        public void setValue(int value)
        {
            this.value = value;
        }

        public void setNumbers(int numbers)
        {
            this.numbers = numbers;
        }

        public int getValue()
        {
            return this.value;
        }

        public int getNumbers()
        {
            return this.numbers;
        }

        public double getRl()
        {
            return this.getValue() * this.deltaR;
        }

        public double getIl()
        {
            return this.uq / (this.ri + this.getRl());
        }

        public double getUk()
        {
            return this.uq - (this.ri * this.getIl());
        }

        public double getPl()
        {
            return this.getUk() * this.getIl();
        }
    }

    class Engineering
    {
        double value;

        public void setEngineering(string engineering)
        {
            this.value = Convert.ToDouble(engineering.TrimEnd('f', 'p', 'n', 'u', 'µ', 'm', 'k', 'M', 'G'));

            if (engineering.Contains('f'))
            {
                this.value = this.value * Math.Pow(10, -15);
            }
            else if (engineering.Contains('p'))
            {
                this.value = this.value * Math.Pow(10, -12);
            }
            else if (engineering.Contains('n'))
            {
                this.value = this.value * Math.Pow(10, -9);
            }
            else if (engineering.Contains('u'))
            {
                this.value = this.value * Math.Pow(10, -6);
            }
            else if (engineering.Contains('µ'))
            {
                this.value = this.value * Math.Pow(10, -6);
            }
            else if (engineering.Contains('m'))
            {
                this.value = this.value * Math.Pow(10, -3);
            }
            else if (engineering.Contains('k'))
            {
                this.value = this.value * Math.Pow(10, 3);
            }
            else if (engineering.Contains('M'))
            {
                this.value = this.value * Math.Pow(10, 6);
            }
            else if (engineering.Contains('G'))
            {
                this.value = this.value * Math.Pow(10, 9);
            }
        }

        public double getValue()
        {
            return this.value;
        }
    }
}
