using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace helper
{
    class adjustment
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
    
}
