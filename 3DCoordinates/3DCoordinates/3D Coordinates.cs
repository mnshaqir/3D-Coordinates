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
            
            try
            {
                temp1 = Convert.ToInt32(textX1.Text);
                temp2 = Convert.ToInt32(textY1.Text);
                temp3 = Convert.ToInt32(textZ1.Text);
                MessageLabel1.Text = "Message: -";
            }

            catch (Exception excep)
            {
                MessageLabel1.Text = "Message: Please give a valid value.";
                return;
            }

            myCartesian.X = temp1;
            myCartesian.Y = temp2;
            myCartesian.Z = temp3;

            Cylindrical acylin = new Cylindrical();
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

        private void Clearbutton1_Click(object sender, EventArgs e)
        {
            {
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                };

                func(Controls);
            }
        }

        //*****************************************//



        //*************** CYLINDRICAL ***************//

        private void toCart2_Click(object sender, EventArgs e)
        {

            double temp4;
            double temp5;
            double temp6;

            try
            {
                temp4 = Convert.ToInt32(textR2.Text);
                temp5 = Convert.ToInt32(textTeta2.Text);
                temp6 = Convert.ToInt32(textZ2.Text);
                MessageLabel2.Text = "Message: -";
            }

            catch (Exception excep)
            {
                MessageLabel2.Text = "Message: Please give a valid value.";
                return;
            }

            myCylindrical.R = temp4;
            myCylindrical.ThetaC = temp5;
            myCylindrical.ZZ = temp6;

            Cartesian bcarte = new Cartesian();
            bcarte = myCylindrical.ToCartesian2();

            textX2.Text = bcarte.X.ToString();
            textY2.Text = bcarte.Y.ToString();
            textzz2.Text = bcarte.Z.ToString();
        }

        private void toSphe2_Click(object sender, EventArgs e)
        {


            Spherical bsphe = new Spherical();
            bsphe = myCylindrical.ToSpherical2();

            textRho2.Text = bsphe.Rho.ToString();
            textTheta2.Text = bsphe.ThetaS.ToString();
            textPhi2.Text = bsphe.Phi.ToString();
        }

        private void Clearbutton2_Click(object sender, EventArgs e)
        {
            {
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                };

                func(Controls);
            }
        }

        //*********************************************//



        //************ SPHERICAL *********************//
        private void toCylin3_Click(object sender, EventArgs e)
        {
            double temp7;
            double temp8;
            double temp9;

            try
            {
                temp7 = Convert.ToInt32(textRho3.Text);
                temp8 = Convert.ToInt32(textTheta3.Text);
                temp9 = Convert.ToInt32(textPhi3.Text);
                MessageLabel3.Text = "Message: -";
            }

            catch (Exception excep)
            {
                MessageLabel3.Text = "Message: Please give a valid value.";
                return;
            }

            mySpherical.Rho = temp7;
            mySpherical.ThetaS = temp8;
            mySpherical.Phi = temp9;

            Cylindrical ccylin = new Cylindrical();
            ccylin = mySpherical.ToCylindrical3();

            textR3.Text = ccylin.R.ToString();
            textTeta3.Text = ccylin.ThetaC.ToString();
            textzz3.Text = ccylin.ZZ.ToString();
        }



        private void toCart3_Click(object sender, EventArgs e)
        {

            Cartesian ccarte = new Cartesian();
            ccarte = mySpherical.ToCartesian3();

            textX3.Text = ccarte.X.ToString();
            textY3.Text = ccarte.Y.ToString();
            textZ3.Text = ccarte.Z.ToString();
        }

    

        private void Clearbutton3_Click(object sender, EventArgs e)
        {
            {
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                };

                func(Controls);
            }
        }

        //********************************//







    }
}
