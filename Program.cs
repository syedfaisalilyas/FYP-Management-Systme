﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProjectUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /*  [STAThread]
          static void Main()
          {


              if (Environment.OSVersion.Version.Major >= 6)
              {
                  SetProcessDPIAware();
              }

              Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);
              Application.Run(new beforeLogin());


          }

          [System.Runtime.InteropServices.DllImport("user32.dll")]
          private static extern bool SetProcessDPIAware();

      }*/
    }
    }
