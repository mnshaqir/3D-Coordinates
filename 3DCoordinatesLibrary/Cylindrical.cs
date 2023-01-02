using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DCoordinatesLibrary
{
        /// <summary>
        /// The class Cylindrical, used to represent a cartesian coordinates.
        /// </summary>
        public class Cylindrical
        {
            /// <summary>
            /// the variable the used to represent cylindrical coordinate.
            /// </summary>
            double _R;  //properties
            double _ThetaC;
            double _ZZ;

            /// <summary>
            /// The variable R in cylindrical coordinate.
            /// </summary>
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

            /// <summary>
            /// The variable Theta in cylindrical coordinate.
            /// </summary>
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

            /// <summary>
            /// The variable Z in cylindrical coordinate.
            /// </summary>
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

            /// <summary>
            /// The three parameter constructor with R, Theta and Z variable.
            /// </summary>
            //constructer
            public Cylindrical()
            {
                _R = 0;
                _ThetaC = 0;
                _ZZ = 0;
            }

            /// <summary>
            /// The Cylindrical to Cartesian coordinates conversion formula.
            /// </summary>
            public Cartesian ToCartesian2() //type and methodname
            {
                Cartesian temp = new Cartesian();

                temp.X = _R * Math.Cos(_ThetaC);
                temp.Y = _R * Math.Sin(_ThetaC);
                temp.Z = _ZZ;
                return temp;


            }

            /// <summary>
            /// The Cylindrical to Spherical coordinates conversion formula.
            /// </summary>
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
