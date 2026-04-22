using FinalProject_ABBOTT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject_ABBOTT.Models
{
    //This is essentially a glorified way to mass-seed data.
    internal class ConfigureDivisions : IEntityTypeConfiguration<Division>
    {
        public void Configure(EntityTypeBuilder<Division> entity)
        {
            entity.HasData( //Despite saying this project will not use AI, I am using it to seed the data, to cut time down.
                    new { DivisionID = 1, Name = "Computer Programming", TotalContestantSlots = 20, FilledContestantSlots = 13, EventTime = new TimeSpan(7, 0, 0), CoordinatorName = "Harvey Kingsley" },
                    new { DivisionID = 2, Name = "Web Design and Development", TotalContestantSlots = 18, FilledContestantSlots = 18, EventTime = new TimeSpan(8, 30, 0), CoordinatorName = "Melissa Grant" },
                    new { DivisionID = 3, Name = "Cybersecurity", TotalContestantSlots = 16, FilledContestantSlots = 12, EventTime = new TimeSpan(9, 0, 0), CoordinatorName = "Daniel Ortiz" },
                    new { DivisionID = 4, Name = "Automotive Service Technology", TotalContestantSlots = 24, FilledContestantSlots = 20, EventTime = new TimeSpan(7, 30, 0), CoordinatorName = "Brian Keller" },
                    new { DivisionID = 5, Name = "Welding", TotalContestantSlots = 15, FilledContestantSlots = 14, EventTime = new TimeSpan(10, 0, 0), CoordinatorName = "Scott Ramirez" },
                    new { DivisionID = 6, Name = "Carpentry", TotalContestantSlots = 20, FilledContestantSlots = 17, EventTime = new TimeSpan(8, 0, 0), CoordinatorName = "Jason Miller" },
                    new { DivisionID = 7, Name = "Culinary Arts", TotalContestantSlots = 12, FilledContestantSlots = 10, EventTime = new TimeSpan(11, 0, 0), CoordinatorName = "Angela Dupree" },
                    new { DivisionID = 8, Name = "Health Knowledge Bowl", TotalContestantSlots = 30, FilledContestantSlots = 28, EventTime = new TimeSpan(9, 30, 0), CoordinatorName = "Rachel Nguyen" },
                    new { DivisionID = 9, Name = "Graphic Communications", TotalContestantSlots = 14, FilledContestantSlots = 9, EventTime = new TimeSpan(10, 30, 0), CoordinatorName = "Ethan Brooks" },
                    new { DivisionID = 10, Name = "Job Interview", TotalContestantSlots = 25, FilledContestantSlots = 21, EventTime = new TimeSpan(13, 0, 0), CoordinatorName = "Lauren Mitchell" },
                    new { DivisionID = 11, Name = "Electrical Construction Wiring", TotalContestantSlots = 18, FilledContestantSlots = 16, EventTime = new TimeSpan(7, 45, 0), CoordinatorName = "Kevin O'Connor" },
                    new { DivisionID = 12, Name = "TeamWorks", TotalContestantSlots = 30, FilledContestantSlots = 26, EventTime = new TimeSpan(8, 15, 0), CoordinatorName = "Derrick Holmes" }
                );
        }
    }
}
