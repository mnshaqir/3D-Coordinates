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
            double _ZZ; 

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
            public double ZZ
            {
                get
                {
                    return _ZZ;
                }
                set
                {
                    _ZZ = value;
                }
            }
        //constructer
        public Cylindrical()
        {
            _R = 0;
            _ThetaC = 0;
            _ZZ = 0;
        }

        public Cartesian ToCartesian2() //type and methodname
        {
            Cartesian temp = new Cartesian();

            temp.X = _R * Math.Cos(_ThetaC);
            temp.Y = _R * Math.Sin(_ThetaC);
            temp.Z = _ZZ;
            return temp;


        }

        //for Spehrical
        public Spherical ToSpherical2() //type and methodname
        {
            Spherical temp = new Spherical();

            temp.Rho = Math.Sqrt(_R * _R + _ZZ * _ZZ);
            temp.ThetaS = _ThetaC;
            temp.Phi = Math.Atan(_R / _ZZ);

            return temp;

        }

    }
}
