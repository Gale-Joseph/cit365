using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingPlanner.Models;

namespace MeetingPlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(ChurchContext context)
        {
            context.Database.EnsureCreated();

            if (context.Speakers.Any())
            {
                return;
            }

            var meetings = new Meeting[]
            {
                new Meeting{MeetingID=DateTime.Parse("2020-04-05"), Conducting="Bishop Blackfield", OpenHymn="Come Let Us",OpenPrayer="Maggie Smith",SacramentHymn="Jesus the very",MiddleHymn="Kroger Family Number",CloseHymn="Abide With Me", ClosePrayer="Jay Homer" }

            };

            foreach (Meeting m in meetings)
            {
                context.Meetings.Add(m);
            }
            context.SaveChanges();

            var speakers = new Speaker[]
{
                new Speaker{FirstName="Billy", LastName="Graham", Topic="Faith", MeetingID=DateTime.Parse("2020-04-05")},
                new Speaker{FirstName="Newt", LastName="Gingrich", Topic="Honesty", MeetingID=DateTime.Parse("2020-04-05")},
                new Speaker{FirstName="Chelsea", LastName="Clinton", Topic="Salvation", MeetingID=DateTime.Parse("2020-04-05")}
};

            foreach (Speaker s in speakers)
            {
                context.Speakers.Add(s);
            }
            context.SaveChanges();

        }
    }
}
