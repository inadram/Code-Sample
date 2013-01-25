using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace RESTWcf
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in App.config.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Machine : IMachine
    {
        List<MachineDetail> MachineDetails=new List<MachineDetail>();
        private int machineId = 0;

       public string AddMachine(MachineDetail machineDetail)
       {
           machineDetail.ID = (++machineId).ToString();
            MachineDetails.Add(machineDetail);
           return (string.Format("add successfully {0}",machineDetail.Name));
        }

        public string GetMachineNameById(string machineId)
        {
            MachineDetail machineDetail = MachineDetails.Find(x => x.ID == machineId);
            return machineDetail.Name;
            
        }

        public string GetMachineNames()
        {
            string machine=string.Empty;
            foreach (var machineDetail in MachineDetails)
            {
                string name = machineDetail.Name;
                string id = machineDetail.ID;
                 machine+=
                string.Format("ID {0} and name is {1} <br/>",id, name);
            }
            return machine;

        }

        public string DeleteMachineById(string machineId)
        {
            MachineDetails.RemoveAll(x => x.ID == machineId);
            return string.Format("machine with Id {0} has successfully deleted",machineId );
        }
    }
}
