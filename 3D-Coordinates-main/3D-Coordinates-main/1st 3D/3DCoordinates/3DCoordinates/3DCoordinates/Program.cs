﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DCoordinates
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the app lication.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new _3DCOORDINATES());
        }
    }
}
