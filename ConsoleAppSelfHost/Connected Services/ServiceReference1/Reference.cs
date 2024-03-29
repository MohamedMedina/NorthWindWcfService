﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppSelfHost.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/NorthWindWcfService")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/NorthWindWcfService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IProductService")]
    public interface IProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetData", ReplyAction="http://tempuri.org/IProductService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetData", ReplyAction="http://tempuri.org/IProductService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/sum", ReplyAction="http://tempuri.org/IProductService/sumResponse")]
        int sum(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/sum", ReplyAction="http://tempuri.org/IProductService/sumResponse")]
        System.Threading.Tasks.Task<int> sumAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProductByID", ReplyAction="http://tempuri.org/IProductService/GetProductByIDResponse")]
        ConsoleAppSelfHost.ServiceReference1.Product GetProductByID(int ProductID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProductByID", ReplyAction="http://tempuri.org/IProductService/GetProductByIDResponse")]
        System.Threading.Tasks.Task<ConsoleAppSelfHost.ServiceReference1.Product> GetProductByIDAsync(int ProductID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetAllProducts", ReplyAction="http://tempuri.org/IProductService/GetAllProductsResponse")]
        ConsoleAppSelfHost.ServiceReference1.Product[] GetAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetAllProducts", ReplyAction="http://tempuri.org/IProductService/GetAllProductsResponse")]
        System.Threading.Tasks.Task<ConsoleAppSelfHost.ServiceReference1.Product[]> GetAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IProductService/GetDataUsingDataContractResponse")]
        ConsoleAppSelfHost.ServiceReference1.CompositeType GetDataUsingDataContract(ConsoleAppSelfHost.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IProductService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ConsoleAppSelfHost.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ConsoleAppSelfHost.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductServiceChannel : ConsoleAppSelfHost.ServiceReference1.IProductService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceClient : System.ServiceModel.ClientBase<ConsoleAppSelfHost.ServiceReference1.IProductService>, ConsoleAppSelfHost.ServiceReference1.IProductService {
        
        public ProductServiceClient() {
        }
        
        public ProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public int sum(int num1, int num2) {
            return base.Channel.sum(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> sumAsync(int num1, int num2) {
            return base.Channel.sumAsync(num1, num2);
        }
        
        public ConsoleAppSelfHost.ServiceReference1.Product GetProductByID(int ProductID) {
            return base.Channel.GetProductByID(ProductID);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppSelfHost.ServiceReference1.Product> GetProductByIDAsync(int ProductID) {
            return base.Channel.GetProductByIDAsync(ProductID);
        }
        
        public ConsoleAppSelfHost.ServiceReference1.Product[] GetAllProducts() {
            return base.Channel.GetAllProducts();
        }
        
        public System.Threading.Tasks.Task<ConsoleAppSelfHost.ServiceReference1.Product[]> GetAllProductsAsync() {
            return base.Channel.GetAllProductsAsync();
        }
        
        public ConsoleAppSelfHost.ServiceReference1.CompositeType GetDataUsingDataContract(ConsoleAppSelfHost.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppSelfHost.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ConsoleAppSelfHost.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
