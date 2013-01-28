using System;
using System.ServiceModel.Web;
using RESTWcf;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory =
                new WebChannelFactory<IMachine>(new Uri("http://localhost:8080/RESTWcf"));
            IMachine machine = factory.CreateChannel();
           
           
            while (true)
            {

                Console.WriteLine("To submit press 1 \nTo delete press 2 \nto Retrive press 3\n\n");
                string readLine = Console.ReadLine();

                if (readLine.Equals("1"))
                {
                    Console.WriteLine("please enter the machine name");
                    string machineName = Console.ReadLine();
                    var machineDetail = new MachineDetail {Name = machineName};
                    string addMachine = machine.AddMachine(machineDetail);
                    Console.WriteLine(addMachine);
                }
                else if (readLine.Equals("2"))
                {
                    Console.WriteLine("please enter the machine Id that you want to delete");
                    string machineId = Console.ReadLine();
                    string deleteMachineById = machine.DeleteMachineById(machineId);
                    Console.WriteLine(deleteMachineById);
                }
                else if (readLine.Equals("3"))
                {
                    Console.WriteLine("please enter the machine Id that you want to get");
                    string machineId = Console.ReadLine();
                    string machineNameById = machine.GetMachineNameById(machineId);
                    Console.WriteLine(machineNameById);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
