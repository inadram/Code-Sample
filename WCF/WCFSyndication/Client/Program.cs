using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using WCFSyndication;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory=new WebChannelFactory<IMachine>(new Uri("http://localhost:8080/wcf"));
            IMachine machine = factory.CreateChannel();

           while (true)
            {
                Console.WriteLine("To submit press 1 \nTo get all machines press 2 \nTo get specific machine name press 3 ");
                string readLine = Console.ReadLine();

         

                if (readLine == "1")
                {
                    Console.WriteLine("please enter machine name :\n");
                    string machineName = Console.ReadLine();
                    machine.submitMachine(machineName);
                }
                else if (readLine == "2")
                {
                    string allMachines = machine.getAllMachines();
                    
                    Console.WriteLine(allMachines);
                }
                else if (readLine == "3")
                {
                    Console.WriteLine("please enter the machine Id \n");
                    string machineId = Console.ReadLine();
                    string machineName = machine.getMachineName(machineId);
                    Console.WriteLine(machineName);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
