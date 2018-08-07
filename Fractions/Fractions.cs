using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Fractions
{
    class Fractions
    {
        int numerator;
        int denominator;

        public Fractions(int num, int den)
        {
            numerator = num;
            denominator = den;
        }

        public Fractions PlusFractions(Fractions B)
        {
            this.numerator = this.numerator * B.denominator + B.numerator * this.denominator;
            this.denominator *= B.denominator;

            return this;
        }

        public Fractions SubstractFractions(Fractions B)
        {
            this.numerator = this.numerator * B.denominator - B.numerator * this.denominator;
            this.denominator *= B.denominator;

            return this;
        }



        public Fractions MultiFractions(Fractions B)
        {
            this.numerator *= B.numerator;
            this.denominator *= B.denominator;

            return this;
        }

        public Fractions DividingFractions(Fractions B)
        {
            this.numerator *= B.denominator;
            this.denominator *= B.numerator;

            return this;
        }

        public string GetNumerator
        {
            get
            {
                return Convert.ToString(this.numerator);
            }
        }

        public string GetDenominator
        {
            get
            {
                return Convert.ToString(this.denominator);
            }
        }
    }
}
