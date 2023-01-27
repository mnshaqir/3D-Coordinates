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
            Spherical bsphe = new Spherical();
            bsphe = myCylindrical.ToSpherical2();

            textRho2.Text = bsphe.Rho.ToString();
            textTheta2.Text = bsphe.ThetaS.ToString();
            textPhi2.Text = bsphe.Phi.ToString();
        }

      

        // SHERICAL PART //
        private void toCylin3_Click(object sender, EventArgs e)
        {
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

    }
}

So the task that have been assigned to our group is 3D Coordinates.

# GOAL STANDARD

The Goal Standard of this project is to make the conversion between Cartesian Coordinate, Cylindrical Coordinates and Spherical Coordinates.

![image](https://user-images.githubusercontent.com/116859685/215003819-973dc5d1-81f4-45ea-a642-22c787783b52.png)

When the number is inserted at the Cartesian Coordinates (x, y, z) the UI will convert the Cartesian Coordinates to Cylindrical and Spherical Coordinates.

Team members:

2190195 Muhamad Nurshaqir Bin Mohd Yunos (Cartesian)

2190205 Muhammad Zakwan Adib Bin Mat Zuber (Cylindrical)

2190211 Mohd Firdaus Bin Suleiman (Spherical)


