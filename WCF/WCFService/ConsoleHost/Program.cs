using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WCFService;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceHost = new ServiceHost(typeof(Machine));

            //setBindings(serviceHost);

            try
            {
                serviceHost.Open();
                Console.ReadLine();
                serviceHost.Close();
            }
            catch (Exception exception)
            {
                Console.Write(exception);
                serviceHost.Abort();
            }
        }

        private static void setBindings(ServiceHost serviceHost)
        {
            var basicHttpBinding = new BasicHttpBinding {SendTimeout = new TimeSpan(1, 1, 1, 1)};

            var serviceMetadataBehavior = new ServiceMetadataBehavior
                                              {
                                                  HttpGetEnabled = true,
                                                  HttpGetUrl = new Uri("http://localhost:8080/ServiceMachine/meta")
                                              };
            serviceHost.Description.Behaviors.Add(serviceMetadataBehavior);

            serviceHost.AddServiceEndpoint(typeof (IMachine), basicHttpBinding,
                                           "http://localhost:8080/ServiceMachine/basic");

            serviceHost.AddServiceEndpoint(typeof (IMachine), new WSHttpBinding(),
                                           "http://localhost:8080/ServiceMachine/ws");

            serviceHost.AddServiceEndpoint(typeof (IMachine), new NetTcpBinding(),
                                           "net.tcp://localhost:8731/ServiceMachine");
        }
    }
}
