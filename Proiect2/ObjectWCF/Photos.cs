using System;
using System.Collections.Generic;
using PhotosApi.Model;
using PhotosApi.API;
using AutoMapper;

namespace ObjectPhotos
{


    public class Photos : InterfaceWCF
    {
        resAPI api;
        MapperConfiguration config;
        IMapper iMapper;
        public Photos()
        {
            
            api = new resAPI();
            config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<resources, resourcesDTO>();
                cfg.CreateMap<atributes, atributesDTO>();
            });
            iMapper = config.CreateMapper();
        }

        public int test()
        { 
            return new resAPI().test();
        }
        public List<resourcesDTO> getAllResources()
        {
           
            var getAll = api.getAllResources();
            var resDTO = new List<resourcesDTO>();
            resDTO = iMapper.Map<List<resources> , List<resourcesDTO>>(getAll);
            Console.WriteLine(resDTO[0].atributes[0].description + resDTO[0].path + resDTO[0].added_at + resDTO[0].resID.ToString() + resDTO[0].type);
            return resDTO;

        }
        public List<resourcesDTO> getAllPhotos()
        {
            var getAll = api.getAllResources();
            List<resourcesDTO> resDTO = new List<resourcesDTO>();
            resDTO = iMapper.Map<List<resources>, List<resourcesDTO>>(getAll, resDTO);
            return resDTO;
        }
        public List<resourcesDTO> getAllVideos()
        {
            var getAll = api.getAllVideos();
            List<resourcesDTO> resDTO = new List<resourcesDTO>();
            resDTO = iMapper.Map<List<resources>, List<resourcesDTO>>(getAll, resDTO);
            return resDTO;
        }
        public List<string> getAllAtributes()
        {
            return new resAPI().getAllAtributes();
        }
        public List<atributesDTO> getAllAtribtuesForResource(string path)
        {
            var getAll = api.getAllAtribtuesForResource(path);
            List<atributesDTO> resDTO = new List<atributesDTO>();
            resDTO = iMapper.Map<List<atributes>, List<atributesDTO>>(getAll, resDTO);
            return resDTO;
        }
        public List<resourcesDTO> getResourcesByQueryAtribute(string atr, string query)
        {
            var getAll = api.getResourcesByQueryAtribute(atr, query);
            List<resourcesDTO> resDTO = new List<resourcesDTO>();
            resDTO = iMapper.Map<List<resources>, List<resourcesDTO>>(getAll, resDTO);
            return resDTO;
        }



        public void saveResources(string path, string type, List<string> atr)
        {
            api.saveResources(path, type, atr);
        }
        public void updateResource(string path, List<string> atr)
        {
             api.updateResource(path, atr);
        }
        public void deleteResources(List<string> paths)
        {
             api.deleteResources(paths);
        }
        public void deleteAtribute(List<string> names)
        {
             api.deleteAtribute(names);
        }
    }
}
