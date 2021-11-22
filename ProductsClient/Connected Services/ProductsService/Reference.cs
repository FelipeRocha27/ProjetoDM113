﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductsClient.ProductsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductData", Namespace="http://schemas.datacontract.org/2004/07/Products")]
    [System.SerializableAttribute()]
    public partial class ProductData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstoqueProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroProdutoField;
        
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
        public string DescricaoProduto {
            get {
                return this.DescricaoProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoProdutoField, value) != true)) {
                    this.DescricaoProdutoField = value;
                    this.RaisePropertyChanged("DescricaoProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EstoqueProduto {
            get {
                return this.EstoqueProdutoField;
            }
            set {
                if ((this.EstoqueProdutoField.Equals(value) != true)) {
                    this.EstoqueProdutoField = value;
                    this.RaisePropertyChanged("EstoqueProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameProduto {
            get {
                return this.NameProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NameProdutoField, value) != true)) {
                    this.NameProdutoField = value;
                    this.RaisePropertyChanged("NameProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroProduto {
            get {
                return this.NumeroProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroProdutoField, value) != true)) {
                    this.NumeroProdutoField = value;
                    this.RaisePropertyChanged("NumeroProduto");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductsService.IProductsService")]
    public interface IProductsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/ListProducts", ReplyAction="http://tempuri.org/IProductsService/ListProductsResponse")]
        ProductsClient.ProductsService.ProductData[] ListProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/ListProducts", ReplyAction="http://tempuri.org/IProductsService/ListProductsResponse")]
        System.Threading.Tasks.Task<ProductsClient.ProductsService.ProductData[]> ListProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetProduct", ReplyAction="http://tempuri.org/IProductsService/GetProductResponse")]
        ProductsClient.ProductsService.ProductData GetProduct(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetProduct", ReplyAction="http://tempuri.org/IProductsService/GetProductResponse")]
        System.Threading.Tasks.Task<ProductsClient.ProductsService.ProductData> GetProductAsync(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/CurrentStockProduto", ReplyAction="http://tempuri.org/IProductsService/CurrentStockProdutoResponse")]
        int CurrentStockProduto(string numeroproduct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/CurrentStockProduto", ReplyAction="http://tempuri.org/IProductsService/CurrentStockProdutoResponse")]
        System.Threading.Tasks.Task<int> CurrentStockProdutoAsync(string numeroproduct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/AddStockProduto", ReplyAction="http://tempuri.org/IProductsService/AddStockProdutoResponse")]
        bool AddStockProduto(string numeroProduct, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/AddStockProduto", ReplyAction="http://tempuri.org/IProductsService/AddStockProdutoResponse")]
        System.Threading.Tasks.Task<bool> AddStockProdutoAsync(string numeroProduct, int quantity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsServiceChannel : ProductsClient.ProductsService.IProductsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsServiceClient : System.ServiceModel.ClientBase<ProductsClient.ProductsService.IProductsService>, ProductsClient.ProductsService.IProductsService {
        
        public ProductsServiceClient() {
        }
        
        public ProductsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ProductsClient.ProductsService.ProductData[] ListProducts() {
            return base.Channel.ListProducts();
        }
        
        public System.Threading.Tasks.Task<ProductsClient.ProductsService.ProductData[]> ListProductsAsync() {
            return base.Channel.ListProductsAsync();
        }
        
        public ProductsClient.ProductsService.ProductData GetProduct(string numeroProduto) {
            return base.Channel.GetProduct(numeroProduto);
        }
        
        public System.Threading.Tasks.Task<ProductsClient.ProductsService.ProductData> GetProductAsync(string numeroProduto) {
            return base.Channel.GetProductAsync(numeroProduto);
        }
        
        public int CurrentStockProduto(string numeroproduct) {
            return base.Channel.CurrentStockProduto(numeroproduct);
        }
        
        public System.Threading.Tasks.Task<int> CurrentStockProdutoAsync(string numeroproduct) {
            return base.Channel.CurrentStockProdutoAsync(numeroproduct);
        }
        
        public bool AddStockProduto(string numeroProduct, int quantity) {
            return base.Channel.AddStockProduto(numeroProduct, quantity);
        }
        
        public System.Threading.Tasks.Task<bool> AddStockProdutoAsync(string numeroProduct, int quantity) {
            return base.Channel.AddStockProdutoAsync(numeroProduct, quantity);
        }
    }
}