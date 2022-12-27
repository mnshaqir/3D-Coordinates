using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DCoordinates
{
    public class Spherical
    {
        double _Rho;  //properties
        double _ThetaS; 
        double _Phi; 

        public double Rho //setter and getter
        {
            get
            {
                return _Rho;
            }
            set
            {
                _Rho = value;
            }
        }

        public double ThetaS
        {
            get
            {
                return _ThetaS;
            }
            set
            {
                _ThetaS = value;
            }
        }
        public double Phi
        {
            get
            {
                return _Phi;
            }
            set
            {
                _Phi = value;
            }
        }
        //constructer
        public Spherical()
        {
            _Rho = 0;
            _ThetaS = 0;
            _Phi = 0;
        }

        public Cartesian ToCartesian() //type and methodname
        {
            Cartesian temp = new Cartesian();

            temp.X = Rho * Math.Sin(Phi);
            temp.Y = ThetaS;
            temp.Z = Rho * Math.Cos(Phi);
            return temp;

        }

        //for Cylindrical
        public Cylindrical ToCylindrical() //type and methodname 

        {
            Cylindrical temp = new Cylindrical();

            temp.R = Rho * Math.Cos(ThetaS) * Math.Sin(Phi);
            temp.ThetaC = Rho * Math.Sin(ThetaS) * Math.Sin(Phi);
            temp.ZZ = Rho * Math.Cos(Phi);
            return temp;

        }
    }
}
