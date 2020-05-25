using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RazorPagesPhotos.Models
{

    [DataContract(IsReference = true)]
    public partial class resourcesDTO
    {
        public resourcesDTO()
        {
            this.atributes = new List<atributesDTO>();
        }
        [DataMember]
        public int resID { get; set; }
        [DataMember]
        public string path { get; set; }
        [DataMember]
        public string added_at { get; set; }
        [DataMember]
        public string type { get; set; }

        [DataMember]
        public List<atributesDTO> atributes { get; set; }

    }

}
