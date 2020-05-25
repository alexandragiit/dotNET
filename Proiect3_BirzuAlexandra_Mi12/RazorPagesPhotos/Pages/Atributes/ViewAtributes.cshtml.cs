using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

//using RazorPagesPhotos.Models;
using ServiceReferencePhotos;

namespace RazorPagesPhotos
{
    public class ViewAtributesModel : PageModel
    {
        InterfaceWCFClient cli = new InterfaceWCFClient();
        public List<String> atributes { get; set; }
       

        public async Task OnGetAsync()
        {
            atributes = await cli.getAllAtributesAsync();
            atributes.Sort();
        
        }

    }
}