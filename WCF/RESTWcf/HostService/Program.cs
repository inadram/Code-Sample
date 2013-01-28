using System;
using System.ServiceModel.Web;
using RESTWcf;

namespace HostService
{
    class Program
    {
        static void Main(string[] args)
        {
            // var webServiceHost = new ServiceHost(typeof(Machine));
            var webServiceHost = new WebServiceHost(typeof(Machine), new Uri("http://localhost:8080/RESTWcf"));
            webServiceHost.Open();
            Console.ReadLine();
            webServiceHost.Close();
        }
    }
}
