﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tp.MVC
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/TP.WebService.Library")]
    public partial class Address : object
    {
        
        private string StreetNameField;
        
        private string StreetNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StreetName
        {
            get
            {
                return this.StreetNameField;
            }
            set
            {
                this.StreetNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StreetNumber
        {
            get
            {
                return this.StreetNumberField;
            }
            set
            {
                this.StreetNumberField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Tp.MVC.IService")]
    public interface IService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAddress", ReplyAction="http://tempuri.org/IService/GetAddressResponse")]
        Tp.MVC.Address GetAddress(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAddress", ReplyAction="http://tempuri.org/IService/GetAddressResponse")]
        System.Threading.Tasks.Task<Tp.MVC.Address> GetAddressAsync(int userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IServiceChannel : Tp.MVC.IService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Tp.MVC.IService>, Tp.MVC.IService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceClient() : 
                base(ServiceClient.GetDefaultBinding(), ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public Tp.MVC.Address GetAddress(int userId)
        {
            return base.Channel.GetAddress(userId);
        }
        
        public System.Threading.Tasks.Task<Tp.MVC.Address> GetAddressAsync(int userId)
        {
            return base.Channel.GetAddressAsync(userId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/TP.WebService.Library/Service/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService,
        }
    }
}
