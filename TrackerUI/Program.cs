using System;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize database
            GlobalConfig.InitializeConnections(DataBaseType.Sql);
            Application.Run(new CreateTeamForm());



            //Application.Run(new TournamentDashboardForm());
        }
    }
}
