using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DCoordinates
{
    public class Cylindrical
    {
            double _R;  //properties
            double _ThetaC;
            double _Z; 

            public double R //setter and getter
            {
                get
                {
                    return _R;
                }
                set
                {
                    _R = value;
                }
            }

            public double ThetaC
        {
                get
                {
                    return _ThetaC;
                }
                set
                {
                _ThetaC = value;
                }
            }
            public double Z
            {
                get
                {
                    return _Z;
                }
                set
                {
                    _Z = value;
                }
            }
        //constructer
        public Cylindrical()
        {
            _R = 0;
            _ThetaC = 0;
            _Z = 0;
        }
        public Cylindrical(double P1, double P2, double P3)  //constructer
        {
            _R = P1;
            _ThetaC = P2;
            _Z = P3;
        }


        public Cartesian ToCartesian() //type and methodname
        {
            Cartesian temp = new Cartesian();

            temp.X = _R * Math.Cos(_ThetaC);
            temp.Y = _R * Math.Sin(_ThetaC);
            temp.Z = _Z;
            return temp;


        }

        //for Spehrical
        public Spherical ToSpherical() //type and methodname
        {
            Spherical temp = new Spherical();

            temp.Rho = Math.Sqrt(_R * _R + _Z * _Z);
            temp.ThetaS = _ThetaC;
            temp.Phi = Math.Atan(_R / _Z);

            return temp;

        }

    }
}
