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

    
    {
        public _3DCOORDINATES()
        {
            InitializeComponent();
        }
//*************  CARTERSIAN  ***************//
        private void toCylin1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textX1.Text);
            int b = Convert.ToInt32(textY1.Text);
            int c = Convert.ToInt32(textZ1.Text);

            textR1.Text = Convert.ToString(Math.Sqrt((a * a + b * b)));
            textTeta1.Text = Convert.ToString(Math.Atan(b/a));
            textzz1.Text = Convert.ToString(c);
        }

        private void toSphe1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textX1.Text);
            int b = Convert.ToInt32(textY1.Text);
            int c = Convert.ToInt32(textZ1.Text);

            textRho1.Text = Convert.ToString(a * a + b * b + c * c);
            textTheta1.Text = Convert.ToString(Math.Atan(b/a));
            textPhi1.Text = Convert.ToString(a * Math.Acos(c/ Math.Sqrt(a * a + b * b + c * c)));
        }

//******************************
        private void CylindricalToCartesian_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //*************** CYLINDRICAL ***************//


        private void toCart2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textR2.Text);
            int b = Convert.ToInt32(textTeta2.Text);
            int c = Convert.ToInt32(textzz2.Text);

            textX2.Text = Convert.ToString(a * Math.Cos(b));
            textY2.Text = Convert.ToString(a * Math.Sin(b));
            textZ2.Text = Convert.ToString(c);
        }

        private void toSphe2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textR2.Text);
            int b = Convert.ToInt32(textTeta2.Text);
            int c = Convert.ToInt32(textzz2.Text);

            textRho2.Text = Convert.ToString(Math.Sqrt(a * a + c * c));
            textTheta2.Text = Convert.ToString(b);
            textPhi2.Text = Convert.ToString(Math.Acos(c /(Math.Sqrt(a * a + c * c))));
        }

        //*********************************************//
        private void Spherical_Click(object sender, EventArgs e)
        {

        }

        private void Cylindrical_Click(object sender, EventArgs e)
        {

        }

        private void Cartesian_Click(object sender, EventArgs e)
        {

        }

        private void textRho_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTheta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhi_TextChanged(object sender, EventArgs e)
        {

        }
//************ SPHERICAL *********************//
        private void toCylin3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textRho3.Text);
            int b = Convert.ToInt32(textTheta3.Text);
            int c = Convert.ToInt32(textPhi3.Text);

            textR3.Text = Convert.ToString(a * Math.Sin(c));
            textTeta3.Text = Convert.ToString(b);
            textzz3.Text = Convert.ToString(a * Math.Cos(c));
        }

        private void toCart3_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(textRho3.Text);
            int b = Convert.ToInt32(textTheta3.Text);
            int c = Convert.ToInt32(textPhi3.Text);

            textX3.Text = Convert.ToString(a * Math.Cos(b) * Math.Sin(c));
            textY3.Text = Convert.ToString(a * Math.Sin(b) * Math.Sin(c));
            textZ3.Text = Convert.ToString(a * Math.Cos(c));
        }


        //********************************//







    }
}
