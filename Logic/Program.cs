using System;
using System.Windows.Forms;
using AllInOne.Logic;
using AllInOne.Forms;

namespace AllInOne
{
    internal static class Program
    {
        public static bool standalone;
        public static string workdir;
        public static string processApkPath;
        public static string ApkDir;
        public static string pathToMyPluginDir;
        public static string pathToBatchapktool;
        
        [STAThread]
        private static void Main()
        {
            string[] commandLineArgs = Environment.GetCommandLineArgs();
            if (commandLineArgs.Length == 1)
            {
                Program.standalone = true;
            }
            Settings.Load();
            Patcher.loadAllInOne(commandLineArgs);
            Patterns.LoadPatterns();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            Patcher.setMainForm(ref mainForm);
            Application.Run(mainForm);
        }


    }
}
