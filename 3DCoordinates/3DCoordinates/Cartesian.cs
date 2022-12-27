using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DCoordinates
{
    public class Cartesian
    {   
        double _X;  //properties
        double _Y;
        double _Z;

        public double X //setter and getter
        {
            get
            {
                return _X;
            }
            set
            {
                _X = value;
            }
        }

        public double Y
        {
            get
            {
                return _Y;
            }
            set
            {
                _Y = value;
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
        public Cartesian()
        {
            _X = 0;
            _Y = 0;
            _Z = 0;
        }
     
        //for Cylindrical
        public Cylindrical ToCylindrical1() //type and methodname 

        {
            Cylindrical temp = new Cylindrical();

            temp.R = Math.Sqrt((_X * _X + _Y * _Y));
            temp.ThetaC = Math.Atan(_Y / _X);
            temp.ZZ = _Z;
            return temp;
    
        }

        //for Spehrical
        public Spherical ToSpherical1() //type class and method name
        {
            Spherical temp = new Spherical();

            temp.Rho = X * X + Y * Y + Z * Z;
            temp.ThetaS = Math.Atan(Y / X);
            temp.Phi = X * Math.Acos(Z / Math.Sqrt(X * X + Y * Y + Z * Z));

            return temp;

        }




    }
}
