using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFstudii
{
    class ModelBusiness : DbContext
    {
        public DbSet<Business> Businesses { get; set; }

        public ModelBusiness() : base("ModelBusiness")
        { }

    }
}
