using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotosApi.API;
using PhotosApi.Model;
using ObjectPhotos;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*resAPI r = new resAPI();
            Console.WriteLine(r.getAllResources()[0].path);
*/
            /*InterfaceWCF p = new Photos();
            atributesDTO d = p.getAllAtribtuesForResource("D:\\movie\\I.Origins.2014.1080p.BluRay.H264.ACC.5.1.BADASSMEDIA\\1.JPG")[0];
          */

            InterfaceWCF p = new Photos();
            resourcesDTO d = p.getAllResources()[0];
            Console.WriteLine(d.path + d.resID + d.added_at + d.atributes + d.type);
        }
    }
}
