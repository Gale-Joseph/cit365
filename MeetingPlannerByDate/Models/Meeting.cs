using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingPlanner.Models
{
    public class Meeting
    {
       // public int MeetingID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime MeetingID { get; set; }

        public string Conducting { get; set; }

        public string OpenHymn { get; set; }

        public string OpenPrayer { get; set; }

        public string SacramentHymn { get; set; }

        public string MiddleHymn { get; set; }

        public string CloseHymn { get; set; }

        public string ClosePrayer { get; set; }


        public List<Speaker>Speakers { get; set; }
    }
}
