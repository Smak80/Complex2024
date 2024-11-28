using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex2024
{
    public class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }
        public double AbsoluteValue => Math.Sqrt(Re * Re + Im * Im);
        public Complex Conjugate => new Complex(Re, -Im);

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public Complex() { }
        public override string ToString()
        {
            var sb = new StringBuilder();
            if (Re != 0 || Im == 0)
            {
                sb.Append(Re);
            }
            if (Im != 0)
            {
                if (Im > 0 && Re != 0)
                {
                    sb.Append("+");
                }
                else
                {
                    sb.Append("-");
                }
                if (Math.Abs(Im) != 1)
                {
                    sb.Append(Math.Abs(Im));
                }
                sb.Append('i');
            }
            return sb.ToString();
        }
        public Complex Sum(Complex other) => new Complex(Re + other.Re, Im + other.Im);
        public Complex Diff(Complex other) => new Complex(Re - other.Re, Im - other.Im);

        public Complex Product(Complex other) => new Complex(Re * other.Re - Im * other.Im, Re * other.Im + Im * other.Re);
        public Complex Quotient(Complex other)
        {
            double denominator = other.Re * other.Re + other.Im * other.Im;
            var re = (Re * other.Re + Im * other.Im) / denominator;
            var im = (Im * other.Re - Re * other.Im) / denominator;

            return new(re, im);
        }

        public void SumAssign(Complex other)
        {
            Re += other.Re;
            Im += other.Im;
        }
        public void DiffAssign(Complex other)
        {
            Re -= other.Re;
            Im -= other.Im;
        }
        public void ProductAssign(Complex other)
        {
            var l = Re * other.Re - other.Im * Im;
            Im = Im * other.Re + other.Im * Re;
            Re = l;

            /*var l = Re;
            Re = Re * other.Re - other.Im * Im;
            Im = Im * other.Re + other.Im * l;*/
        }
    }

}
