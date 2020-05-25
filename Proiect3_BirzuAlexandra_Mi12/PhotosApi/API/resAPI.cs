using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotosApi.Model;

namespace PhotosApi.API
{
    public class resAPI
    {
        // returneaza 

        public int test()
        {
            return 1;
        }
        public List<resources> getAllResources()
        {
            using (Model1Container1 context = new Model1Container1())
            {
               
                var r = context.resources.Include("atributes").OrderBy(m => m.added_at).ToList();

                return r;

            }
        }

        public List<resources> getAllPhotos()
        {
            using (Model1Container1 context = new Model1Container1())
            {
              
                var r = context.resources.Include("atributes").Where(m => m.type == "image").OrderBy(m => m.added_at).ToList();
                
                return r;

            }
        }

        public List<resources> getAllVideos()
        {
            using (Model1Container1 context = new Model1Container1())
            {
                var r = context.resources.Include("atributes").Where(m => m.type == "video").OrderBy(m => m.added_at).ToList();

                return r;

            }
        }


        public List<string> getAllAtributes()
        {
            using (Model1Container1 context = new Model1Container1())
            {
                var atr = context.atributes.Include("resources").Select(m => m.name).Distinct().ToList();
                return atr;
            }
        }

        public List<atributes> getAllAtribtuesForResource(string path)
        {
            using (Model1Container1 context = new Model1Container1())
            {
                var a = context.atributes.Where(x => x.resource.path == path).Select(x => x).ToList();
                return a;
            }
        }


        public List<resources> getResourcesByQueryAtribute(string atr, string query)
        {
            using (Model1Container1 context = new Model1Container1())
            {
                List<resources> ret = new List<resources>();
                if (query != "")
                {
                   var r = context.atributes.Include("resources").Where(x => x.name == atr).Where(x => x.description == query).Select(x => x.resource).ToList();
                    foreach (var x in r)
                    {
                        ret.Add(x);
                    }
                }
                else
                {
                    var r2 = context.atributes.Include("resources").Where(x => x.name == atr).Select(x => x.resource).ToList();
                    foreach (var x in r2)
                    {
                        ret.Add(x);
                    }
                    Debug.Write(ret);
                }
                      
                return ret;
            }
        }

        public void saveResources(string path, string type, List<string> atr)
        {
            // save button
            string name, desc;

            using (Model1Container1 context = new Model1Container1())
            {
                resources r = new resources()
                {
                    path = path,
                    added_at = DateTime.Now.ToString(),
                    type = type

                };
                context.resources.Add(r);
                for (var i = 0; i < atr.Count; i += 2)
                {
                    name = atr[i];
                    desc = atr[i + 1];

                    atributes a = new atributes()
                    {
                        name = name,
                        description = desc,
                        resource = r
                    };
                    context.atributes.Add(a);
                }
                context.SaveChanges();

            }

        }

        public void updateResource(string path, List<string> atr)
        {
            // save button
            string name, desc;

            using (Model1Container1 context = new Model1Container1())
            {

                var b = context.atributes.Where(x => x.resource.path == path).Select(x => x);
                foreach (var i in b)
                {
                    context.atributes.Remove(i);
                }
                var id = context.resources.Where(x => x.path == path).Select(x => x.resID);

                for (var i = 0; i < atr.Count; i += 2)
                {
                    name = atr[i];
                    desc = atr[i + 1];

                    atributes a = new atributes()
                    {
                        name = name,
                        description = desc,
                        resources_resID = id.First()

                    };
                    context.atributes.Add(a);
                }
                context.SaveChanges();

            }
        }

        public void deleteResources(List<string> paths)
        {
            using (Model1Container1 context = new Model1Container1())
            {
                foreach (var n in paths)
                {
                    var b = context.atributes.Where(x => x.resource.path == n).Select(x => x);
                    foreach (var i in b)
                    {
                        context.atributes.Remove(i);
                    }
                }

                context.SaveChanges();

                foreach (var n in paths)
                {
                    var c = context.resources.Where(x => x.path == n).Select(x => x);
                    foreach (var i in c)
                    {
                        context.resources.Remove(i);
                    }
                }

                context.SaveChanges();

            }
        }

        public void deleteAtribute(List<string> names)
        {
            using (Model1Container1 context = new Model1Container1())
            {
                foreach (var n in names)
                {
                    var b = context.atributes.Where(x => x.name == n).Select(x => x);
                    foreach (var i in b)
                    {
                        context.atributes.Remove(i);
                    }
                }
                context.SaveChanges();

            }
        }
    }
}
