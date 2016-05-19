using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace helper
{
    class Engineering
    {
        double value;

        public void setValue(double value)
        {
            this.value = value;
        }

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

        public string getEngineering()
        {
            string buffer;
            double number_buffer;

            if ((this.value >= Math.Pow(10, -15)) && (this.value < Math.Pow(10, -12)))
            {
                number_buffer = this.value / Math.Pow(10, -15);
                buffer = number_buffer.ToString("0.00");

                return buffer + "f";
            }
            else if ((this.value >= Math.Pow(10, -12)) && (this.value < Math.Pow(10, -9)))
            {
                number_buffer = this.value / Math.Pow(10, -12);
                buffer = number_buffer.ToString("0.00");

                return buffer + "p";
            }
            else if ((this.value >= Math.Pow(10, -9)) && (this.value < Math.Pow(10, -6)))
            {
                number_buffer = this.value / Math.Pow(10, -9);
                buffer = number_buffer.ToString("0.00");

                return buffer + "n";
            }
            else if ((this.value >= Math.Pow(10, -6)) && (this.value < Math.Pow(10, -3)))
            {
                number_buffer = this.value / Math.Pow(10, -6);
                buffer = number_buffer.ToString("0.00");

                return buffer + "u";
            }
            else if ((this.value >= Math.Pow(10, -3)) && (this.value < Math.Pow(10, 0)))
            {
                number_buffer = this.value / Math.Pow(10, -3);
                buffer = number_buffer.ToString("0.00");

                return buffer + "m";
            }
            else if ((this.value >= Math.Pow(10, 0)) && (this.value < Math.Pow(10, 3)))
            {
                number_buffer = this.value;
                buffer = number_buffer.ToString("0.00");

                return buffer;
            }
            else if ((this.value >= Math.Pow(10, 3)) && (this.value < Math.Pow(10, 6)))
            {
                number_buffer = this.value / Math.Pow(10, 3);
                buffer = number_buffer.ToString("0.00");

                return buffer + "k";
            }
            else if ((this.value >= Math.Pow(10, 6)) && (this.value < Math.Pow(10, 9)))
            {
                number_buffer = this.value / Math.Pow(10, 6);
                buffer = number_buffer.ToString("0.00");

                return buffer + "M";
            }
            else if ((this.value >= Math.Pow(10, 9)) && (this.value < Math.Pow(10, 12)))
            {
                number_buffer = this.value / Math.Pow(10, 9);
                buffer = number_buffer.ToString("0.00");

                return buffer + "G";
            }

            // In case of error return raw string value
            return this.value.ToString("0.00");
        }
    }
}
