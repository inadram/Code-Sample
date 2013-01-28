using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Syndication;

namespace WCFSyndication
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Machine : IMachine
    {
        List<MachineDetail> MachineDetails=new List<MachineDetail>();
        private int machineId = 0;
        public void submitMachine(string machineName)
       {
           var machineDetail=new MachineDetail();
           machineDetail.name = machineName;
           machineDetail.Id = (++machineId).ToString();
           MachineDetails.Add(machineDetail);

       }

       public string getAllMachines()
        {
            string machine = string.Empty;
            foreach (var machineDetail in MachineDetails)
            {
                string name = machineDetail.name;
                string id = machineDetail.Id;
                machine +=
               string.Format("ID {0} and name is {1} <br/>", id, name);
            }
            return machine;

        }

      public string getMachineName(string machineID)
       {
           return MachineDetails.Find(x => x.Id == machineID).name;
       }

        public SyndicationFeedFormatter GetFeed(string format)
        {
            SyndicationFeedFormatter syndicationFeedFormatter;
            var syndicationFeed=new SyndicationFeed
                                    {
                                        Title = new TextSyndicationContent("Machine feed title"),
                                        Description = new TextSyndicationContent("Machin feed description"),
                                        Items = from machine in MachineDetails
                                                select new SyndicationItem()
                                                           {
                                                               Title = new TextSyndicationContent(machine.Id),
                                                               Content = new TextSyndicationContent(machine.name)
                                                           }
                                    };
            if(format.Equals("Atom"))
            {
                syndicationFeedFormatter = new Atom10FeedFormatter(syndicationFeed);
            }
            else
            {
                syndicationFeedFormatter = new Rss20FeedFormatter(syndicationFeed);
            }
            return syndicationFeedFormatter;
        }
    }
}
