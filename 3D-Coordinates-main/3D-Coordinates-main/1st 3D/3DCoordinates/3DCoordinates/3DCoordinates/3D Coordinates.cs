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

        private void CylindricalToCartesian_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void Spherical_Click(object sender, EventArgs e)
        {

        }

        private void Cylindrical_Click(object sender, EventArgs e)
        {

        }

        private void Cartesian_Click(object sender, EventArgs e)
        {

        }


        private void Carte2Sphere_Click(object sender, EventArgs e)
        {

        }

        private void Carte2Cylind_Click(object sender, EventArgs e)
        {

        }

//***********
        private void textRho_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTheta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhi_TextChanged(object sender, EventArgs e)
        {

        }

        private void convertbtntoCart_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(textRho.Text);
            int b = Convert.ToInt32(textTheta.Text);
            int c = Convert.ToInt32(textPhi.Text);

            textx.Text = Convert.ToString(a * Math.Cos(b) * Math.Sin(c));
            texty.Text = Convert.ToString(a * Math.Sin(b) * Math.Sin(c));
            textz.Text = Convert.ToString(a * Math.Cos(c));
        }

        private void convertbtntoCylin_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textRho.Text);
            int b = Convert.ToInt32(textTheta.Text);
            int c = Convert.ToInt32(textPhi.Text);

            textr.Text = Convert.ToString(a * Math.Sin(c));
            textTeta.Text = Convert.ToString(b);
            textzz.Text = Convert.ToString(a * Math.Cos(c));
        }


        //*************
    }
}
