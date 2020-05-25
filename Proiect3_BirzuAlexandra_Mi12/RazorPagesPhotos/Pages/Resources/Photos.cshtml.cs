using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ServiceReferencePhotos;

namespace RazorPagesPhotos
{
    public class PhotosModel : PageModel
    {
        InterfaceWCFClient cli = new InterfaceWCFClient();
        public List<resourcesDTO> result;
        public List<List<string>> atr;
        public List<string> b64 { get; set; }
        public async Task OnGetAsync(string name)
        {
            atr = new List<List<string>>();
            b64 = new List<string>();

            byte[] imageArray;
            string base64ImageRepresentation;

            result = await cli.getResourcesByQueryAtributeAsync(name,"");
            foreach(var x in result)
            {
                var a = await cli.getAllAtribtuesForResourceAsync(x.path);
                var s = new List<string>();
                s.Add(" ");
                foreach(var i in a) {

                    s.Add(i.name + " : " + i.description);
                }

                imageArray = System.IO.File.ReadAllBytes(x.path);
                base64ImageRepresentation = Convert.ToBase64String(imageArray);
                var type = x.path.Split(".").Last();
                b64.Add("data:image/" + type + ";base64," + base64ImageRepresentation);

                atr.Add(s);

            }
        }
    }
}