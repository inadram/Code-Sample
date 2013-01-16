using System.ServiceModel;

namespace WCFService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,ConcurrencyMode = ConcurrencyMode.Multiple) ]
    public class Machine:IMachine
    {
        public void Add(MachineDTO machineDTO)
        {
            var db=new DummyDatabase();
            db.submit(machineDTO);
        }

        public string GetMachineName(MachineDTO machineDTO)
        {
            return string.Format("the machine name is {0}",machineDTO.MachineName);
        }
    }
}
