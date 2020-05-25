using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RazorPagesPhotos.Models
{
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
        public resourcesDTO resource { get; set; }
    }
}
