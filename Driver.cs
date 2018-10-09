using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7LibraryXML
{
    // Name:        James Horton
    // Date:        10/09/2018
    // Assignment:  Library XML Project
    // File:        7LibraryXML

    static class Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LibraryControl());
        } // end of main
    } // end of class Driver
} // end of namespace
