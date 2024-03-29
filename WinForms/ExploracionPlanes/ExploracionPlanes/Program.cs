﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploracionPlanes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo current = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            current.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = current;
            Thread.CurrentThread.CurrentUICulture = current;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            //Application.Run(new TBI());
        }
    }
}
