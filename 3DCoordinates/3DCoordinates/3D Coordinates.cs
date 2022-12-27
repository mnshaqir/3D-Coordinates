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
            double temp1;
            double temp2;
            double temp3;
            
            Cylindrical acylin = new Cylindrical(); 
            

            try
            {
                temp1 = Convert.ToInt32(textX1.Text);
                temp2 = Convert.ToInt32(textY1.Text);
                temp3 = Convert.ToInt32(textZ1.Text);

            }

            catch (Exception excep)
            {
                MessageLabel1.Text = "Message: Please give a valid value";
                return;
            }

            myCartesian.X = temp1;
            myCartesian.Y = temp2;
            myCartesian.Z = temp3;


            acylin = myCartesian.ToCylindrical1();


            textR1.Text = acylin.R.ToString();
            textTeta1.Text = acylin.ThetaC.ToString();
            textzz1.Text = acylin.ZZ.ToString();
        }

        private void toSphe1_Click(object sender, EventArgs e)
            
        {
            Spherical asphe = new Spherical();
            asphe = myCartesian.ToSpherical1();

            textRho1.Text = asphe.Rho.ToString();
            textTheta1.Text = asphe.ThetaS.ToString();
            textPhi1.Text = asphe.Phi.ToString();
        }

        //*****************************************//



        //*************** CYLINDRICAL ***************//

        private void toCart2_Click(object sender, EventArgs e)
        {

            int temp;

            try
            {
                temp = Convert.ToInt32(textR2.Text);
                temp = Convert.ToInt32(textTeta2.Text);
                temp = Convert.ToInt32(textZ2.Text);

            }

            catch (Exception excep)
            {
                MessageLabel1.Text = "Message: Please give a valid value";
                return;
            }

            myCylindrical.ToCartesian2();

            textX2.Text = myCylindrical.R.ToString();
            textY2.Text = myCylindrical.ThetaC.ToString();
            textzz2.Text = myCylindrical.ZZ.ToString();
        }

        private void toSphe2_Click(object sender, EventArgs e)
        {
            myCylindrical.ToSpherical2();

            textRho2.Text = myCylindrical.R.ToString();
            textTheta2.Text = myCylindrical.ThetaC.ToString();
            textPhi2.Text = myCylindrical.ZZ.ToString();
        }

          //*********************************************//



           //************ SPHERICAL *********************//
        private void toCylin3_Click(object sender, EventArgs e)
        {
            mySpherical.ToCylindrical3();

            textR3.Text = mySpherical.Rho.ToString();
            textTeta3.Text = mySpherical.ThetaS.ToString();
            textzz3.Text = mySpherical.Phi.ToString();
        }



        private void toCart3_Click(object sender, EventArgs e)
        {
            mySpherical.ToCartesian3();

            textX3.Text = mySpherical.Rho.ToString();
            textY3.Text = mySpherical.ThetaS.ToString();
            textZ3.Text = mySpherical.Phi.ToString();
        }


        //********************************//







    }
}
