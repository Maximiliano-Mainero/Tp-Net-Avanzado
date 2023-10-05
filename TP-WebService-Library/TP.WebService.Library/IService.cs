using System.Runtime.Serialization;
using System.ServiceModel;

namespace TP.WebService.Library
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Address GetAddress(int userId);
    }

    [DataContract]
    public class Address
    {
        [DataMember]
        public string StreetName { get; set; }
        [DataMember]
        public string StreetNumber { get; set; }
    }
    public class Service : IService
    {
       public Address GetAddress(int userId)
        {
            return new Address
            {
                StreetName = "Bv. Buenos Aires",
                StreetNumber = "205"
            };
        }
    }
}
