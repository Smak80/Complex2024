using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex2024
{
    public class TrigComplex:Complex
    {
        private double _r;
        private double _phi;
        public double R { get => _r; 
            set 
            {
                _r = value;
                base.Re = Math.Cos(_phi) * _r; 
                base.Im = Math.Sin(_phi) * _r;
            } 
        }
        public double Phi { get => _phi;
            set 
            {
                _phi = value;
                base.Re = Math.Cos(_phi) * _r;
                base.Im = Math.Sin(_phi) * _r;
            } 
        }
        public override double Re
        {
            get => base.Re;
            set
            {
                 base.Re = value;
                _r = AbsoluteValue;
                _phi = Math.Atan2(Im, Re); // В C# функция Atan2 действительно принимает параметры в другом порядке!
            }
        }
        public override double Im
        {
            get => base.Im;
             set
            {
                base.Im = value;
                _r = AbsoluteValue;
                _phi=Math.Atan2(Im, Re);
            }
        }

        public TrigComplex() { }
        public TrigComplex(double r, double phi) 
        { 
            R = r;
            Phi = phi;
        }
        public override string ToString()
        {
            return $"{R}(cos({Phi})+i sin({Phi}))";
        }

    }
}
