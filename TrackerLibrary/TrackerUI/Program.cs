﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.bvcnbc
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Init DB Connections
            GlobalConfig.InitializeConnections(DatabaseType.Sql);
            //Application.Run(new TournamentDashboard());
            Application.Run(new CreatePrizeForm());
        }
    }
}