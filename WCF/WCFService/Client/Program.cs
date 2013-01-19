using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Client.Imachine;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
           //  IChannelFactory<IMachineChannel> factory = new ChannelFactory<IMachineChannel>(new BasicHttpBinding());
            // IMachineChannel channel = factory.CreateChannel(new EndpointAddress("http://localhost:8733/ServiceMachine/basic"));

            var channel = new MachineClient("BasicHttpBinding_IMachine");
            try
            {
               string machineName = channel.GetMachineName(new MachineDTO {MachineID = "1", MachineName = "test"});
               Console.WriteLine(machineName);
               Console.ReadLine();
               channel.Close();
            }
            catch (FaultException faultException)
            {
                channel.Abort();
                Console.WriteLine(faultException.Message);
            }
            catch(CommunicationException communicationException)
            {
                channel.Abort();
                Console.WriteLine(communicationException.Message);
            }
        }
    }
}
