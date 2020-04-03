using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingPlanner.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Topic { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime MeetingDate { get; set; }

        public int MeetingID { get; set; }
        public Meeting Meeting { get; set; }
    }
}
