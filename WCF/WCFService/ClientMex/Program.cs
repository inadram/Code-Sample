﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using ClientMex.ServiceReference1;

namespace ClientMex
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceEndpointCollection serviceEndpointCollection =
                MetadataResolver.Resolve(typeof (IMachine),
                new EndpointAddress("http://localhost:8080/ServiceMachine/mex"));
            foreach (var endpoint in serviceEndpointCollection)
            {
               var channel=new MachineClient(endpoint.Binding,endpoint.Address);
                string machineName = channel.GetMachineName(new MachineDTO {MachineID = "1", MachineName = "test"});
                Console.WriteLine(machineName);
            }
        }
    }
}
