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

        public Cartesian ToCartesian3() //type and methodname
        {
            Cartesian temp = new Cartesian();

            temp.X = (_Rho * (Math.Sin(_Phi)) * (Math.Cos(_ThetaS)));
            temp.Y = (_Rho * (Math.Sin(_Phi)) * (Math.Sin(_ThetaS)));
            temp.Z = (_Rho * (Math.Cos(_Phi)));
            return temp;

        }

        //for Cylindrical
        public Cylindrical ToCylindrical3() //type and methodname 

        {
            Cylindrical temp = new Cylindrical();

            temp.R = _Rho * Math.Sin(_Phi);
            temp.ThetaC = _ThetaS;
            temp.ZZ = _Rho * Math.Cos(_Phi);
            return temp;

        }
    }
}
