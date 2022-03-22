using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fakeLook_models.Models
{
    public class FiltersModel
    {
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string[] Publishers { get; set; }
        public string[] Tags { get; set; }
        public string[] TagsUsers { get; set; }

    }
}
