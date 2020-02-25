using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWebApp.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public string SurfaceMaterial { get; set; }
        public int RushDelivery { get; set; }
    }
}
