# 3D COORDINATES

The GUI version of the DLL based 3DCoordinates project at:

https://github.com/AdibZakwan/3D-Coordinates-Library

Sample usage:

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
    
    {  // Call the class
        Cartesian myCartesian = new Cartesian();
        Cylindrical myCylindrical = new Cylindrical();
        Spherical mySpherical = new Spherical();

        public _3DCOORDINATES()
        {
            InitializeComponent();
        }
        // CARTERSIAN PART //
        
        private void toCylin1_Click(object sender, EventArgs e)
        
        {
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

      
  
        // CYLINDRICAL PART //

        private void toCart2_Click(object sender, EventArgs e)
        {
            Cartesian bcarte = new Cartesian();
            bcarte = myCylindrical.ToCartesian2();

            textX2.Text = bcarte.X.ToString();
            textY2.Text = bcarte.Y.ToString();
            textzz2.Text = bcarte.Z.ToString();
        }

        private void toSphe2_Click(object sender, EventArgs e)
        {
            double temp4;
            double temp5;
            double temp6;

            try
            {
                temp4 = Convert.ToDouble(textR2.Text);
                temp5 = Convert.ToDouble(textTeta2.Text);
                temp6 = Convert.ToDouble(textZ2.Text);
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

            Spherical bsphe = new Spherical();
            bsphe = myCylindrical.ToSpherical2();

            textRho2.Text = bsphe.Rho.ToString();
            textTheta2.Text = bsphe.ThetaS.ToString();
            textPhi2.Text = bsphe.Phi.ToString();
        }

        private void Clearbutton2_Click(object sender, EventArgs e)
        {
            {
                textX2.Clear();
                textY2.Clear();
                textZ2.Clear();
                textR2.Clear();
                textTeta2.Clear();
                textzz2.Clear();
                textRho2.Clear();
                textTheta2.Clear();
                textPhi2.Clear();
                MessageLabel2.Text = "Message: ";
            }
        }

        // SHERICAL PART //
        private void toCylin3_Click(object sender, EventArgs e)
        {
            double temp7;
            double temp8;
            double temp9;

            try
            {
                temp7 = Convert.ToDouble(textRho3.Text);
                temp8 = Convert.ToDouble(textTheta3.Text);
                temp9 = Convert.ToDouble(textPhi3.Text);
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
            double temp7;
            double temp8;
            double temp9;

            try
            {
                temp7 = Convert.ToDouble(textRho3.Text);
                temp8 = Convert.ToDouble(textTheta3.Text);
                temp9 = Convert.ToDouble(textPhi3.Text);
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

            Cartesian ccarte = new Cartesian();
            ccarte = mySpherical.ToCartesian3();

            textX3.Text = ccarte.X.ToString();
            textY3.Text = ccarte.Y.ToString();
            textZ3.Text = ccarte.Z.ToString();
        }


        private void Clearbutton3_Click(object sender, EventArgs e)
        {
            {
                textX3.Clear();
                textY3.Clear();
                textZ3.Clear();
                textR3.Clear();
                textTeta3.Clear();
                textzz3.Clear();
                textRho3.Clear();
                textTheta3.Clear();
                textPhi3.Clear();
                MessageLabel3.Text = "Message: ";
            }
        }

    

    }
}

So the task that have been assigned to our group is 3D Coordinates.

The Goal Standard of this project is to make the conversion between Cartesian Coordinate, Cylindrical Coordinates and Spherical Coordinates.

![image](https://user-images.githubusercontent.com/116859685/215003819-973dc5d1-81f4-45ea-a642-22c787783b52.png)

When the number is inserted at the Cartesian Coordinates (x, y, z) the UI will convert the Cartesian Coordinates to Cylindrical and Spherical Coordinates.

Team members:

2190195 Muhamad Nurshaqir Bin Mohd Yunos (Assist Them)

2190205 Muhammad Zakwan Adib Bin Mat Zuber (Cylindrical to Cartesian)(Vice Versa)

2190211 Mohd Firdaus Bin Suleiman (Spherical to Cylindrical)(Vice Versa)

2190210 Tan Zheng Kang (Cartesian to Spherical)(Vice Versa)
