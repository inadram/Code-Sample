using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RESTWcf
{
    // NOTE: If you change the interface name "IMachine" here, you must also update the reference to "IMachine" in App.config.
    [ServiceContract]
    public interface IMachine
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "machine")]
        string AddMachine(MachineDetail machineDetail);

        [WebGet(UriTemplate = "machine/{machineId}")]
        [OperationContract]
        string GetMachineNameById(string machineId);

        [WebGet(UriTemplate = "machines")]
        [OperationContract]
        string GetMachineNames();

        [WebInvoke(UriTemplate = "machine/{machineId}",Method = "DELETE")]
        [OperationContract]
        string DeleteMachineById(string machineId);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations
    [DataContract(Namespace = "http://inadram.com/machine")]
    public class MachineDetail
    {
        [DataMember] 
        public string Name;


        [DataMember] 
        public string ID;

    }
}
