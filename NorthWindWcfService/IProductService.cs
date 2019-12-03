using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NorthWindWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        int sum(int num1, int num2);
        [OperationContract]
        Product GetProductByID(int ProductID);
        [OperationContract]
        List<Product> GetAllProducts();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "NorthWindWcfService.ContractType".
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
    [DataContract]
    public class Product {

        private int _ProductID;
        [DataMember]
        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        private string _ProductName;
        [DataMember]
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }
        private int _Price;
        [DataMember]
        public int Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        
    }
}
