using System.Runtime.Serialization;

namespace WCFSyndication
{
    [DataContract(Namespace = "http://inadram.com/syndication")]
    public class MachineDetail  
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string  Id { get; set; }    
    }
}