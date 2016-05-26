using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace helper
{
    class verlust_leitung_class
    {
        double rho = 0.01786;
        double uq, length, area, delta_i;
        int value, numbers;

        public void setUq(double uq)
        {
            this.uq = uq;
        }

        public void setLength(double length)
        {
            this.length = length;
        }

        public void setArea(double area)
        {
            this.area = area;
        }

        public void setDeltaI(double deltaI)
        {
            this.delta_i = deltaI;
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

        public double getLength()
        {
            return this.length;
        }

        public double getArea()
        {
            return this.area;
        }

        public double getR()
        {
            return ((rho * this.getLength()) / this.getArea());
        }

        public double getUq()
        {
            return this.uq;
        }

        public double getI()
        {
            return this.getValue() * this.delta_i;
        }

        public double getPl()
        {
            return this.getUk() * this.getI();
        }

        public double getUk()
        {
            return  this.getUq() - (this.getR() * this.getI());
        }
    }
    
}
