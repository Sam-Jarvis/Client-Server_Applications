﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client2.ServiceReferenceClient2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/webshopService")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StockField;
        
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
        public string Price {
            get {
                return this.PriceField;
            }
            set {
                if ((object.ReferenceEquals(this.PriceField, value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Stock {
            get {
                return this.StockField;
            }
            set {
                if ((object.ReferenceEquals(this.StockField, value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="webshopService", ConfigurationName="ServiceReferenceClient2.IWebshopContract")]
    public interface IWebshopContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="webshopService/IWebshopContract/GetWebshopName", ReplyAction="webshopService/IWebshopContract/GetWebshopNameResponse")]
        string GetWebshopName();
        
        [System.ServiceModel.OperationContractAttribute(Action="webshopService/IWebshopContract/GetWebshopName", ReplyAction="webshopService/IWebshopContract/GetWebshopNameResponse")]
        System.Threading.Tasks.Task<string> GetWebshopNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="webshopService/IWebshopContract/GetProductList", ReplyAction="webshopService/IWebshopContract/GetProductListResponse")]
        Client2.ServiceReferenceClient2.Item[] GetProductList();
        
        [System.ServiceModel.OperationContractAttribute(Action="webshopService/IWebshopContract/GetProductList", ReplyAction="webshopService/IWebshopContract/GetProductListResponse")]
        System.Threading.Tasks.Task<Client2.ServiceReferenceClient2.Item[]> GetProductListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="webshopService/IWebshopContract/GetProductInfo", ReplyAction="webshopService/IWebshopContract/GetProductInfoResponse")]
        string GetProductInfo(string ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="webshopService/IWebshopContract/GetProductInfo", ReplyAction="webshopService/IWebshopContract/GetProductInfoResponse")]
        System.Threading.Tasks.Task<string> GetProductInfoAsync(string ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="webshopService/IWebshopContract/BuyProduct", ReplyAction="webshopService/IWebshopContract/BuyProductResponse")]
        bool BuyProduct(string ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="webshopService/IWebshopContract/BuyProduct", ReplyAction="webshopService/IWebshopContract/BuyProductResponse")]
        System.Threading.Tasks.Task<bool> BuyProductAsync(string ProductId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebshopContractChannel : Client2.ServiceReferenceClient2.IWebshopContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebshopContractClient : System.ServiceModel.ClientBase<Client2.ServiceReferenceClient2.IWebshopContract>, Client2.ServiceReferenceClient2.IWebshopContract {
        
        public WebshopContractClient() {
        }
        
        public WebshopContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebshopContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebshopContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebshopContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetWebshopName() {
            return base.Channel.GetWebshopName();
        }
        
        public System.Threading.Tasks.Task<string> GetWebshopNameAsync() {
            return base.Channel.GetWebshopNameAsync();
        }
        
        public Client2.ServiceReferenceClient2.Item[] GetProductList() {
            return base.Channel.GetProductList();
        }
        
        public System.Threading.Tasks.Task<Client2.ServiceReferenceClient2.Item[]> GetProductListAsync() {
            return base.Channel.GetProductListAsync();
        }
        
        public string GetProductInfo(string ProductId) {
            return base.Channel.GetProductInfo(ProductId);
        }
        
        public System.Threading.Tasks.Task<string> GetProductInfoAsync(string ProductId) {
            return base.Channel.GetProductInfoAsync(ProductId);
        }
        
        public bool BuyProduct(string ProductId) {
            return base.Channel.BuyProduct(ProductId);
        }
        
        public System.Threading.Tasks.Task<bool> BuyProductAsync(string ProductId) {
            return base.Channel.BuyProductAsync(ProductId);
        }
    }
}
