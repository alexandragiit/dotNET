﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotosApi.Model
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="resources", Namespace="http://schemas.datacontract.org/2004/07/PhotosApi.Model")]
    public partial class resources : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string added_atField;
        
        private PhotosApi.Model.atributes[] atributesField;
        
        private string pathField;
        
        private int resIDField;
        
        private string typeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
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
        public PhotosApi.Model.atributes[] atributes
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="atributes", Namespace="http://schemas.datacontract.org/2004/07/PhotosApi.Model")]
    public partial class atributes : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private string descriptionField;
        
        private string nameField;
        
        private PhotosApi.Model.resources resourceField;
        
        private System.Nullable<int> resources_resIDField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
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
        public PhotosApi.Model.resources resource
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
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="InterfaceWCF")]
public interface InterfaceWCF
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllResources", ReplyAction="http://tempuri.org/InterfaceWCF/getAllResourcesResponse")]
    PhotosApi.Model.resources[] getAllResources();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllResources", ReplyAction="http://tempuri.org/InterfaceWCF/getAllResourcesResponse")]
    System.Threading.Tasks.Task<PhotosApi.Model.resources[]> getAllResourcesAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllPhotos", ReplyAction="http://tempuri.org/InterfaceWCF/getAllPhotosResponse")]
    PhotosApi.Model.resources[] getAllPhotos();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllPhotos", ReplyAction="http://tempuri.org/InterfaceWCF/getAllPhotosResponse")]
    System.Threading.Tasks.Task<PhotosApi.Model.resources[]> getAllPhotosAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllVideos", ReplyAction="http://tempuri.org/InterfaceWCF/getAllVideosResponse")]
    PhotosApi.Model.resources[] getAllVideos();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllVideos", ReplyAction="http://tempuri.org/InterfaceWCF/getAllVideosResponse")]
    System.Threading.Tasks.Task<PhotosApi.Model.resources[]> getAllVideosAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllAtributes", ReplyAction="http://tempuri.org/InterfaceWCF/getAllAtributesResponse")]
    string[] getAllAtributes();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllAtributes", ReplyAction="http://tempuri.org/InterfaceWCF/getAllAtributesResponse")]
    System.Threading.Tasks.Task<string[]> getAllAtributesAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllAtribtuesForResource", ReplyAction="http://tempuri.org/InterfaceWCF/getAllAtribtuesForResourceResponse")]
    PhotosApi.Model.atributes[] getAllAtribtuesForResource(string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getAllAtribtuesForResource", ReplyAction="http://tempuri.org/InterfaceWCF/getAllAtribtuesForResourceResponse")]
    System.Threading.Tasks.Task<PhotosApi.Model.atributes[]> getAllAtribtuesForResourceAsync(string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getResourcesByQueryAtribute", ReplyAction="http://tempuri.org/InterfaceWCF/getResourcesByQueryAtributeResponse")]
    PhotosApi.Model.resources[] getResourcesByQueryAtribute(string atr, string query);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/getResourcesByQueryAtribute", ReplyAction="http://tempuri.org/InterfaceWCF/getResourcesByQueryAtributeResponse")]
    System.Threading.Tasks.Task<PhotosApi.Model.resources[]> getResourcesByQueryAtributeAsync(string atr, string query);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/saveResources", ReplyAction="http://tempuri.org/InterfaceWCF/saveResourcesResponse")]
    void saveResources(string path, string type, string[] atr);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/saveResources", ReplyAction="http://tempuri.org/InterfaceWCF/saveResourcesResponse")]
    System.Threading.Tasks.Task saveResourcesAsync(string path, string type, string[] atr);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/updateResource", ReplyAction="http://tempuri.org/InterfaceWCF/updateResourceResponse")]
    void updateResource(string path, string[] atr);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/updateResource", ReplyAction="http://tempuri.org/InterfaceWCF/updateResourceResponse")]
    System.Threading.Tasks.Task updateResourceAsync(string path, string[] atr);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/deleteResources", ReplyAction="http://tempuri.org/InterfaceWCF/deleteResourcesResponse")]
    void deleteResources(string[] paths);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/deleteResources", ReplyAction="http://tempuri.org/InterfaceWCF/deleteResourcesResponse")]
    System.Threading.Tasks.Task deleteResourcesAsync(string[] paths);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/deleteAtribute", ReplyAction="http://tempuri.org/InterfaceWCF/deleteAtributeResponse")]
    void deleteAtribute(string[] names);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/deleteAtribute", ReplyAction="http://tempuri.org/InterfaceWCF/deleteAtributeResponse")]
    System.Threading.Tasks.Task deleteAtributeAsync(string[] names);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface InterfaceWCFChannel : InterfaceWCF, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class InterfaceWCFClient : System.ServiceModel.ClientBase<InterfaceWCF>, InterfaceWCF
{
    
    public InterfaceWCFClient()
    {
    }
    
    public InterfaceWCFClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public InterfaceWCFClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public InterfaceWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public InterfaceWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public PhotosApi.Model.resources[] getAllResources()
    {
        return base.Channel.getAllResources();
    }
    
    public System.Threading.Tasks.Task<PhotosApi.Model.resources[]> getAllResourcesAsync()
    {
        return base.Channel.getAllResourcesAsync();
    }
    
    public PhotosApi.Model.resources[] getAllPhotos()
    {
        return base.Channel.getAllPhotos();
    }
    
    public System.Threading.Tasks.Task<PhotosApi.Model.resources[]> getAllPhotosAsync()
    {
        return base.Channel.getAllPhotosAsync();
    }
    
    public PhotosApi.Model.resources[] getAllVideos()
    {
        return base.Channel.getAllVideos();
    }
    
    public System.Threading.Tasks.Task<PhotosApi.Model.resources[]> getAllVideosAsync()
    {
        return base.Channel.getAllVideosAsync();
    }
    
    public string[] getAllAtributes()
    {
        return base.Channel.getAllAtributes();
    }
    
    public System.Threading.Tasks.Task<string[]> getAllAtributesAsync()
    {
        return base.Channel.getAllAtributesAsync();
    }
    
    public PhotosApi.Model.atributes[] getAllAtribtuesForResource(string path)
    {
        return base.Channel.getAllAtribtuesForResource(path);
    }
    
    public System.Threading.Tasks.Task<PhotosApi.Model.atributes[]> getAllAtribtuesForResourceAsync(string path)
    {
        return base.Channel.getAllAtribtuesForResourceAsync(path);
    }
    
    public PhotosApi.Model.resources[] getResourcesByQueryAtribute(string atr, string query)
    {
        return base.Channel.getResourcesByQueryAtribute(atr, query);
    }
    
    public System.Threading.Tasks.Task<PhotosApi.Model.resources[]> getResourcesByQueryAtributeAsync(string atr, string query)
    {
        return base.Channel.getResourcesByQueryAtributeAsync(atr, query);
    }
    
    public void saveResources(string path, string type, string[] atr)
    {
        base.Channel.saveResources(path, type, atr);
    }
    
    public System.Threading.Tasks.Task saveResourcesAsync(string path, string type, string[] atr)
    {
        return base.Channel.saveResourcesAsync(path, type, atr);
    }
    
    public void updateResource(string path, string[] atr)
    {
        base.Channel.updateResource(path, atr);
    }
    
    public System.Threading.Tasks.Task updateResourceAsync(string path, string[] atr)
    {
        return base.Channel.updateResourceAsync(path, atr);
    }
    
    public void deleteResources(string[] paths)
    {
        base.Channel.deleteResources(paths);
    }
    
    public System.Threading.Tasks.Task deleteResourcesAsync(string[] paths)
    {
        return base.Channel.deleteResourcesAsync(paths);
    }
    
    public void deleteAtribute(string[] names)
    {
        base.Channel.deleteAtribute(names);
    }
    
    public System.Threading.Tasks.Task deleteAtributeAsync(string[] names)
    {
        return base.Channel.deleteAtributeAsync(names);
    }
}