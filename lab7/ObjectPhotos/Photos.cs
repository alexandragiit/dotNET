using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotosApi.Model;
using PhotosApi.API;

namespace ObjectPhotos
{
    public class Photos : InterfaceWCF
    {

        List<resources> InterfaceWCF.getAllResources()
        {
            return new resAPI().getAllResources();
        }
        List<resources> InterfaceWCF.getAllPhotos()
        {
            return new resAPI().getAllPhotos();
        }
        List<resources> InterfaceWCF.getAllVideos()
        {
             return new resAPI().getAllPhotos();
        }
        List<string> InterfaceWCF.getAllAtributes()
        {
            return new resAPI().getAllAtributes();
        }
        List<atributes> InterfaceWCF.getAllAtribtuesForResource(string path)
        {
            return new resAPI().getAllAtribtuesForResource(path);
        }
        List<resources> InterfaceWCF.getResourcesByQueryAtribute(string atr, string query)
        {
            return new resAPI().getResourcesByQueryAtribute(atr, query);
        }
        void InterfaceWCF.saveResources(string path, string type, List<string> atr)
        {
            new resAPI().saveResources(path, type, atr);
        }
        void InterfaceWCF.updateResource(string path, List<string> atr)
        {
             new resAPI().updateResource(path, atr);
        }
        void InterfaceWCF.deleteResources(List<string> paths)
        {
             new resAPI().deleteResources(paths);
        }
        void InterfaceWCF.deleteAtribute(List<string> names)
        {
             new resAPI().deleteAtribute(names);
        }
    }
}
