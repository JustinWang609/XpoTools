using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XpoTools.master;

namespace XpoTools
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //connect db
            //ConnectionHelper.Connect(AutoCreateOption.DatabaseAndSchema);
            InitDAL();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.Run(new Form1());
        }


        private static void InitDAL()
        {

            XpoDefault.DataLayer = XpoDefault.GetDataLayer(
            ConnectionHelper.ConnectionString,
            AutoCreateOption.DatabaseAndSchema);

        }


    }
}
