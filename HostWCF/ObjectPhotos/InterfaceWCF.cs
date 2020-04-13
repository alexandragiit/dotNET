using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using PhotosApi.Model;

namespace ObjectPhotos
{

    [DataContract(IsReference = true)]
    public partial class resourcesDTO
    {
        public resourcesDTO()
        {
            this.atributes = new List<atributesDTO>();
        }
        [DataMember]
        public int resID { get; set; }
        [DataMember]
        public string path { get; set; }
        [DataMember]
        public string added_at { get; set; }
        [DataMember]
        public string type { get; set; }

        [DataMember]
        public List<atributesDTO> atributes { get; set; }

    }

    [DataContract(IsReference = true)]
    public partial class atributesDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public Nullable<int> resources_resID { get; set; }

        [DataMember]
        public resources resource { get; set; }
    }

    [ServiceContract]
    public interface InterfaceWCF
    {
        [OperationContract]
        int test();

        [OperationContract]
        List<resourcesDTO> getAllResources();

        [OperationContract]
        List<resourcesDTO> getAllPhotos();
        [OperationContract]
        List<resourcesDTO> getAllVideos();
        [OperationContract]
        List<string> getAllAtributes();
        [OperationContract]
        List<atributesDTO> getAllAtribtuesForResource(string path);
        
        [OperationContract]
        List<resourcesDTO> getResourcesByQueryAtribute(string atr, string query);
        [OperationContract]
        void saveResources(string path, string type, List<string> atr);
        [OperationContract]
        void updateResource(string path, List<string> atr);
        [OperationContract]
        void deleteResources(List<string> paths);
        [OperationContract]
        void deleteAtribute(List<string> names);
    }

   
}
