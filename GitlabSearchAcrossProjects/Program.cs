﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GitlabSearchAcrossProjects
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VersionCheck.CheckForUpdate();
            Application.Run(new MainForm());
        }
    }
}
