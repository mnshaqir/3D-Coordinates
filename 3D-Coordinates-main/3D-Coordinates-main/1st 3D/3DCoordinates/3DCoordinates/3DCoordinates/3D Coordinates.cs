using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DCoordinates
{
    public partial class _3DCOORDINATES : Form

    
    {  // Panggil class
        Cartesian myCartesian = new Cartesian();
        Cylindrical myCylindrical = new Cylindrical();
        Spherical mySpherical = new Spherical();

        public _3DCOORDINATES()
        {
            InitializeComponent();
        }
        //*************  CARTERSIAN  ***************//
        private void toCylin1_Click(object sender, EventArgs e)
        {

            myCartesian.ToCylindrical();


            textR1.Text = myCartesian.X.ToString();
            textTeta1.Text = myCartesian.Y.ToString();
            textzz1.Text = myCartesian.Z.ToString();
        }

        private void toSphe1_Click(object sender, EventArgs e)
        {
            myCartesian.ToSpherical();

            textRho1.Text = myCartesian.X.ToString();
            textTheta1.Text = myCartesian.Y.ToString();
            textPhi1.Text = myCartesian.Z.ToString();
        }

        //*****************************************//



        //*************** CYLINDRICAL ***************//

        private void toCart2_Click(object sender, EventArgs e)
        {
            myCylindrical.ToCartesian();

            textX2.Text = myCylindrical.R.ToString();
            textY2.Text = myCylindrical.ThetaC.ToString();
            textzz2.Text = myCylindrical.ZZ.ToString();
        }

        private void toSphe2_Click(object sender, EventArgs e)
        {
            myCylindrical.ToSpherical();

            textRho2.Text = myCylindrical.R.ToString();
            textTheta2.Text = myCylindrical.ThetaC.ToString();
            textPhi2.Text = myCylindrical.ZZ.ToString();
        }

          //*********************************************//



           //************ SPHERICAL *********************//
        private void toCylin3_Click(object sender, EventArgs e)
        {
            mySpherical.ToCylindrical();

            textR3.Text = mySpherical.Rho.ToString();
            textTeta3.Text = mySpherical.ThetaS.ToString();
            textzz3.Text = mySpherical.Phi.ToString();
        }



        private void toCart3_Click(object sender, EventArgs e)
        {
            mySpherical.ToCartesian();

            textX3.Text = mySpherical.Rho.ToString();
            textY3.Text = mySpherical.ThetaS.ToString();
            textZ3.Text = mySpherical.Phi.ToString();
        }


        //********************************//







    }
}
