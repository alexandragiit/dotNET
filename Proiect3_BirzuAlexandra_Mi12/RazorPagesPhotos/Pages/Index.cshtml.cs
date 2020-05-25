using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using ServiceReferencePhotos;
using static System.Net.Mime.MediaTypeNames;

namespace RazorPagesPhotos.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public List<string> b64 { get; set; }
        public List<string> b642 { get; set; }
        InterfaceWCFClient cli = new InterfaceWCFClient();
        public List<resourcesDTO> result;
        public List<resourcesDTO> result2;

        public List<List<string>> atr;
        public List<List<string>> atr2;
        public async Task OnGetAsync()
        {

            byte[] imageArray;
            string base64ImageRepresentation;
            result = await cli.getAllResourcesAsync();
            result2 = new List<resourcesDTO>();
            atr = new List<List<string>>();
            atr2 = new List<List<string>>();
            b64 = new List<string>();
            b642 = new List<string>();
            bool found = false;
                foreach (var x in result)
                {
                    var a = await cli.getAllAtribtuesForResourceAsync(x.path);
                    var s = new List<string>();
                    s.Add(" ");
                    found = false;
                    foreach (var i in a)
                    {
                        s.Add(i.name + " : " + i.description);
                        if(!string.IsNullOrEmpty(SearchString) && i.description.Contains(SearchString))
                        {
                            found = true;
                        }
                    }
                    atr.Add(s);
                    imageArray = System.IO.File.ReadAllBytes(x.path);
                    base64ImageRepresentation = Convert.ToBase64String(imageArray);
                    var type = x.path.Split(".").Last();
                    b64.Add("data:image/" + type + ";base64," + base64ImageRepresentation);
                if (found == true && !string.IsNullOrEmpty(SearchString))
                    {
                        result2.Add(x);
                        b642.Add("data:image/" + type + ";base64," + base64ImageRepresentation);
                        atr2.Add(s);
                    }
                }

                if(!string.IsNullOrEmpty(SearchString))
                {
                    result = result2;
                    atr = atr2;
                    b64 = b642;
                }
            
        }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

      
    }
}
