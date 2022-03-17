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
        public double X_loc { get; set; }
        public double Y_loc { get; set; }
        public double Z_loc { get; set; }
        public int Radius { get; set; }
        public Tag[] Tags { get; set; }
        public User[] TagedUsers { get; set; }

    }
}
