using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    internal class Program
    {
        //private static readonly string url = "C:\\Users\\domet\\source\\repos\\Cinema\\Cinema\\Resources\\";

       // public static string GetUrl()
        //{
         //   return url;
        //}
        static void Main(string[] args)
        {
            try
            {

                ServiceHost svcHost = new ServiceHost(typeof(ServiceE_Commerce));

                svcHost.Open();
                DBConnection.DBOpen();

                foreach (var process in Process.GetProcessesByName("sqlservr"))
                {
                    process.Kill();
                }

                Console.WriteLine("WCF Service online, press any key to stop...");

                Console.ReadLine();
                DBConnection.DBClose();
                svcHost.Close();

                Console.WriteLine("WCF Service successfully stopped");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }
    }
}
