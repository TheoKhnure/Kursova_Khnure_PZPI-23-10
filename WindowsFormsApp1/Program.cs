﻿using Criminals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            CriminalDatabase database = new CriminalDatabase();
            List<Criminal> criminals = CriminalDatabase.criminals;

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Golovna());
           
        }
    }
}
