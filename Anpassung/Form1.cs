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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(0);
            }

            anpassung.setUq(Convert.ToDouble(textBox1.Text));
            anpassung.setRi(Convert.ToDouble(textBox2.Text));
            anpassung.setDeltaR(Convert.ToInt32(textBox3.Text));
            anpassung.setNumbers(Convert.ToInt32(textBox4.Text));


            for (int y = 1; y <= anpassung.getNumbers(); y++)
            {
                anpassung.setValue(y);
                dataGridView1.Rows.Add(Convert.ToString(anpassung.getRl()),
                                        Convert.ToString(anpassung.getIl()),
                                        Convert.ToString(anpassung.getUk()),
                                        Convert.ToString(anpassung.getPl()));
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

    class Anpassung
    {
        double uq, ri, rl;
        int deltaR, value, numbers;

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

        public void setDeltaR(int deltaR)
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
            return this.rl + (this.getValue() * this.deltaR);
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
}
