using System.Collections.Generic;
using System.ServiceModel;
using PhotosApi.Model;

namespace ObjectPhotos
{
    [ServiceContract]
    interface InterfaceWCF
    {
        [OperationContract]
        List<resources> getAllResources();

        [OperationContract]
        List<resources> getAllPhotos();
        [OperationContract]
        List<resources> getAllVideos();
        [OperationContract]
        List<string> getAllAtributes();
        [OperationContract]
        List<atributes> getAllAtribtuesForResource(string path);
        [OperationContract]
        List<resources> getResourcesByQueryAtribute(string atr, string query);
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
