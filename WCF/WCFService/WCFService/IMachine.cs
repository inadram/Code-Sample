using System.ServiceModel;

namespace WCFService
{
    [ServiceContract]
    public interface IMachine
    {
        [OperationContract(IsOneWay = true)]
        void Add(MachineDTO machineDTO);

        [OperationContract]
        string GetMachineName(MachineDTO machineDTO);

    }
}
