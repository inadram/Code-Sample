using System.Runtime.Serialization;

namespace WCFService
{
    [DataContract]
    public  class MachineDetails
    {
        [DataMember] 
        public string Name;
        [DataMember] 
        private int _id;

        public bool Original;
    }
}
