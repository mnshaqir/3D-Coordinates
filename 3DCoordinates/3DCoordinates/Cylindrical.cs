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

        public Cartesian ToCartesian() //type and methodname
        {
            Cartesian temp = new Cartesian();

            temp.X = R * Math.Cos(ThetaC);
            temp.Y = R * Math.Sin(ThetaC);
            temp.Z = ZZ;
            return temp;


        }

        //for Spehrical
        public Spherical ToSpherical() //type and methodname
        {
            Spherical temp = new Spherical();

            temp.Rho = Math.Sqrt(R * R + ZZ * ZZ);
            temp.ThetaS = ThetaC;
            temp.Phi = Math.Acos(ZZ / (Math.Sqrt(R * R + ZZ * ZZ)));

            return temp;

        }

    }
}
