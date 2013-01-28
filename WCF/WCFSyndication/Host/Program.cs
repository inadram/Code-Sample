using System;
using System.ServiceModel.Web;
using WCFSyndication;

namespace Host
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceHost=new WebServiceHost(typeof(Machine),new Uri("http://localhost:8080/wcf")); 
            serviceHost.Open();

            Console.WriteLine("your service is starting...");
            Console.ReadLine();
            serviceHost.Close();
        }
    }
}
