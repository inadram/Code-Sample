using System;
using AsyncClient.ServiceReference1;

namespace AsyncClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new MachineClient("basic");
            channel.GetMachineNameCompleted+=ChannelOnGetMachineNameCompleted;
            channel.GetMachineNameAsync(new MachineDTO {MachineID = "1",MachineName = "async machine"});
            Console.WriteLine("some other operation is going on ...");
            Console.ReadLine();
        }

        private static void ChannelOnGetMachineNameCompleted(object sender, GetMachineNameCompletedEventArgs getMachineNameCompletedEventArgs)
        {
            string result = getMachineNameCompletedEventArgs.Result;
            Console.WriteLine(result);
        }
        
    }
}
