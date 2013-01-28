using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;

namespace WCFSyndication
{
    [ServiceContract]
    public interface IMachine
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "machine", Method = "POST")]
        void submitMachine(string machineName);

        [OperationContract]
        [WebGet(UriTemplate = "machines")]
        string getAllMachines();

        [OperationContract]
        [WebGet(UriTemplate = "machine/{machineID}")]
        string getMachineName(string machineID);

        [ServiceKnownType(typeof(Atom10FeedFormatter))]
        [ServiceKnownType(typeof(Rss20FeedFormatter))]
        [OperationContract]
        [WebGet(UriTemplate = "machine/feed/{format}")]
        SyndicationFeedFormatter GetFeed(string format);
      

    }
}