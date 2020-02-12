using SoftwareUpdater;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
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

            string Namespace = Assembly.GetExecutingAssembly().GetName().Name;
            string uygulamaAdi = System.Reflection.Assembly.GetEntryAssembly().Location.Substring(Assembly.GetEntryAssembly().Location.LastIndexOf('\\') + 1);
            string versiyon = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).FileVersion;
            //disabled cause of server issues
            try
            {
                //Updater.KontrolEt(Namespace, versiyon, uygulamaAdi);
            }
            catch { }

            Application.Run(new frmMain { Text =uygulamaAdi.Remove(uygulamaAdi.LastIndexOf('.'))+" v"+versiyon });
        }
    }
}
