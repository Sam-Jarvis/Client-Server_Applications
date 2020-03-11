using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace webshopService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "webshopService", CallbackContract = typeof(IWebshopCallback))]
    public interface IWebshopContract
    {
        [OperationContract]
        string GetWebshopName();

        [OperationContract]
        List<Item> GetProductList();

        [OperationContract]
        string GetProductInfo(string ProductId);

        [OperationContract]
        bool BuyProduct(string ProductId);

        [OperationContract]
        int connect();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    public interface IWebshopCallback
    {
        [OperationContract(IsOneWay = true)]
        void newClient(int numOfClients);

        [OperationContract(IsOneWay = true)]
        void productSold(Item product);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "webshopService.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
