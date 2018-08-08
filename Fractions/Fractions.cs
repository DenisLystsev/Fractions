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
            Fractions Result;

            this.numerator = this.numerator * B.denominator + B.numerator * this.denominator;
            this.denominator *= B.denominator;

            Result = this.GetReductFraction();

            return Result;
        }

        public Fractions SubstractFractions(Fractions B)
        {
            Fractions Result;

            this.numerator = this.numerator * B.denominator - B.numerator * this.denominator;
            this.denominator *= B.denominator;

            Result = this.GetReductFraction();

            return Result;
        }

        Fractions GetReductFraction()
        {
            int gcd = 0, min = 0;

            min = this.numerator;
            if (min > this.denominator) min = this.denominator;

            for(int i = 1; i<=min; i++)
            {
                if (this.numerator % i == 0 && this.denominator % i == 0) gcd = i;
            }

            this.numerator /= gcd;
            this.denominator /= gcd;

            return this;
        }

        public Fractions MultiFractions(Fractions B)
        {
            Fractions Result;

            this.numerator *= B.numerator;
            this.denominator *= B.denominator;

            Result = this.GetReductFraction();

            return Result;
        }

        public Fractions DividingFractions(Fractions B)
        {
            Fractions Result;

            this.numerator *= B.denominator;
            this.denominator *= B.numerator;

            Result = this.GetReductFraction();

            return Result;
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
