﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferencePhotos
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="resourcesDTO", Namespace="http://schemas.datacontract.org/2004/07/ObjectPhotos", IsReference=true)]
    public partial class resourcesDTO : object
    {
        
        private string added_atField;
        
        private System.Collections.Generic.List<ServiceReferencePhotos.atributesDTO> atributesField;
        
        private string pathField;
        
        private int resIDField;
        
        private string typeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string added_at
        {
            get
            {
                return this.added_atField;
            }
            set
            {
                this.added_atField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferencePhotos.atributesDTO> atributes
        {
            get
            {
                return this.atributesField;
            }
            set
            {
                this.atributesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int resID
        {
            get
            {
                return this.resIDField;
            }
            set
            {
                this.resIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="atributesDTO", Namespace="http://schemas.datacontract.org/2004/07/ObjectPhotos", IsReference=true)]
    public partial class atributesDTO : object
    {
        
        private int IdField;
        
        private string descriptionField;
        
        private string nameField;
        
        private ServiceReferencePhotos.resourcesDTO resourceField;
        
        private System.Nullable<int> resources_resIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferencePhotos.resourcesDTO resource
        {
            get
            {
                return this.resourceField;
            }
            set
            {
                this.resourceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> resources_resID
        {
            get
            {
                return this.resources_resIDField;
            }
            set
            {
                this.resources_resIDField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePhotos.InterfaceWCF")]
    public interface InterfaceWCF
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/test", ReplyAction="http://tempuri.org/InterfaceWCF/testResponse")]
        System.Threading.Tasks.Task<int> testAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllResources", ReplyAction="http://tempuri.org/InterfaceWCF/getAllResourcesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotos.resourcesDTO>> getAllResourcesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllPhotos", ReplyAction="http://tempuri.org/InterfaceWCF/getAllPhotosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotos.resourcesDTO>> getAllPhotosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllVideos", ReplyAction="http://tempuri.org/InterfaceWCF/getAllVideosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotos.resourcesDTO>> getAllVideosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllAtributes", ReplyAction="http://tempuri.org/InterfaceWCF/getAllAtributesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> getAllAtributesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllAtribtuesForResource", ReplyAction="http://tempuri.org/InterfaceWCF/getAllAtribtuesForResourceResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotos.atributesDTO>> getAllAtribtuesForResourceAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getResourcesByQueryAtribute", ReplyAction="http://tempuri.org/InterfaceWCF/getResourcesByQueryAtributeResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotos.resourcesDTO>> getResourcesByQueryAtributeAsync(string atr, string query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/saveResources", ReplyAction="http://tempuri.org/InterfaceWCF/saveResourcesResponse")]
        System.Threading.Tasks.Task saveResourcesAsync(string path, string type, System.Collections.Generic.List<string> atr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/updateResource", ReplyAction="http://tempuri.org/InterfaceWCF/updateResourceResponse")]
        System.Threading.Tasks.Task updateResourceAsync(string path, System.Collections.Generic.List<string> atr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/deleteResources", ReplyAction="http://tempuri.org/InterfaceWCF/deleteResourcesResponse")]
        System.Threading.Tasks.Task deleteResourcesAsync(System.Collections.Generic.List<string> paths);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/deleteAtribute", ReplyAction="http://tempuri.org/InterfaceWCF/deleteAtributeResponse")]
        System.Threading.Tasks.Task deleteAtributeAsync(System.Collections.Generic.List<string> names);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface InterfaceWCFChannel : ServiceReferencePhotos.InterfaceWCF, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class InterfaceWCFClient : System.ServiceModel.ClientBase<ServiceReferencePhotos.InterfaceWCF>, ServiceReferencePhotos.InterfaceWCF
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public InterfaceWCFClient() : 
                base(InterfaceWCFClient.GetDefaultBinding(), InterfaceWCFClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_InterfaceWCF.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfaceWCFClient(EndpointConfiguration endpointConfiguration) : 
                base(InterfaceWCFClient.GetBindingForEndpoint(endpointConfiguration), InterfaceWCFClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfaceWCFClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(InterfaceWCFClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfaceWCFClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(InterfaceWCFClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfaceWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<int> testAsync()
        {
            return base.Channel.testAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotos.resourcesDTO>> getAllResourcesAsync()
        {
            return base.Channel.getAllResourcesAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotos.resourcesDTO>> getAllPhotosAsync()
        {
            return base.Channel.getAllPhotosAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotos.resourcesDTO>> getAllVideosAsync()
        {
            return base.Channel.getAllVideosAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> getAllAtributesAsync()
        {
            return base.Channel.getAllAtributesAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotos.atributesDTO>> getAllAtribtuesForResourceAsync(string path)
        {
            return base.Channel.getAllAtribtuesForResourceAsync(path);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePhotos.resourcesDTO>> getResourcesByQueryAtributeAsync(string atr, string query)
        {
            return base.Channel.getResourcesByQueryAtributeAsync(atr, query);
        }
        
        public System.Threading.Tasks.Task saveResourcesAsync(string path, string type, System.Collections.Generic.List<string> atr)
        {
            return base.Channel.saveResourcesAsync(path, type, atr);
        }
        
        public System.Threading.Tasks.Task updateResourceAsync(string path, System.Collections.Generic.List<string> atr)
        {
            return base.Channel.updateResourceAsync(path, atr);
        }
        
        public System.Threading.Tasks.Task deleteResourcesAsync(System.Collections.Generic.List<string> paths)
        {
            return base.Channel.deleteResourcesAsync(paths);
        }
        
        public System.Threading.Tasks.Task deleteAtributeAsync(System.Collections.Generic.List<string> names)
        {
            return base.Channel.deleteAtributeAsync(names);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_InterfaceWCF))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_InterfaceWCF))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/photos");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return InterfaceWCFClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_InterfaceWCF);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return InterfaceWCFClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_InterfaceWCF);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_InterfaceWCF,
        }
    }
}