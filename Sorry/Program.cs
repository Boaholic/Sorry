﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//This comment made by Michael
namespace Sorry 
{
    static class Program 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            StartMenu start = new StartMenu();
            Application.Run(start);
            
        }
    }
}
