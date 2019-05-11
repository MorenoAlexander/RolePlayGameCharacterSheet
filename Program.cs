using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace RolePlayGameCharacterSheet
{
    static class Program
    {
        public static Configuration configuration;
        public static Form PreviousPage;
        public static String DefaultFolder;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configuration.AppSettings.Settings;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CharacterManager());
        }


        public static void changeDefDirectory(string newdir)
        {

        }
    }
}
