using FinalProject_ABBOTT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject_ABBOTT.Models
{
    //This is essentially a glorified way to mass-seed data.
    internal class ConfigureContestants : IEntityTypeConfiguration<Contestant>
    {
        public void Configure(EntityTypeBuilder<Contestant> entity)
        {
            //Seed the initial data
            entity.HasData( //Despite saying this project will not use AI, I am using it to seed the data, to cut time down.
                new { ContestantID = 1, FirstName = "Ethan", LastName = "Carter", SchoolID = 1, DivisionID = 1, Email = "ecarter1@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 13) },
                new { ContestantID = 2, FirstName = "Maya", LastName = "Lopez", SchoolID = 2, DivisionID = 2, Email = "mlopez2@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 14) },
                new { ContestantID = 3, FirstName = "Jordan", LastName = "Reed", SchoolID = 3, DivisionID = 3, Email = "jreed3@gmail.com", CheckInStatus = false, RegistrationDate = new DateTime(2026, 2, 15) },
                new { ContestantID = 4, FirstName = "Alyssa", LastName = "Nguyen", SchoolID = 4, DivisionID = 8, Email = "anguyen4@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 16) },
                new { ContestantID = 5, FirstName = "Brandon", LastName = "Fischer", SchoolID = 5, DivisionID = 1, Email = "bfischer5@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 10) },
                new { ContestantID = 6, FirstName = "Sofia", LastName = "Martinez", SchoolID = 6, DivisionID = 10, Email = "smartinez6@gmail.com", CheckInStatus = false, RegistrationDate = new DateTime(2026, 2, 11) },
                new { ContestantID = 7, FirstName = "Liam", LastName = "Turner", SchoolID = 7, DivisionID = 5, Email = "lturner7@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 12) },
                new { ContestantID = 8, FirstName = "Chloe", LastName = "Bennett", SchoolID = 8, DivisionID = 7, Email = "cbennett8@gmail.com", CheckInStatus = false, RegistrationDate = new DateTime(2026, 2, 13) },
                new { ContestantID = 9, FirstName = "Noah", LastName = "Hughes", SchoolID = 9, DivisionID = 9, Email = "nhughes9@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 14) },
                new { ContestantID = 10, FirstName = "Emma", LastName = "Collins", SchoolID = 10, DivisionID = 6, Email = "ecollins10@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 15) },
                new { ContestantID = 11, FirstName = "Lucas", LastName = "Ward", SchoolID = 1, DivisionID = 3, Email = "lward11@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 16) },
                new { ContestantID = 12, FirstName = "Isabella", LastName = "Price", SchoolID = 2, DivisionID = 10, Email = "iprice12@gmail.com", CheckInStatus = false, RegistrationDate = new DateTime(2026, 2, 17) },
                new { ContestantID = 13, FirstName = "Logan", LastName = "Bell", SchoolID = 3, DivisionID = 4, Email = "lbell13@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 18) },
                new { ContestantID = 14, FirstName = "Ava", LastName = "Murphy", SchoolID = 4, DivisionID = 12, Email = "amurphy14@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 19) },
                new { ContestantID = 15, FirstName = "Elijah", LastName = "Bailey", SchoolID = 5, DivisionID = 11, Email = "ebailey15@gmail.com", CheckInStatus = false, RegistrationDate = new DateTime(2026, 2, 20) },
                new { ContestantID = 16, FirstName = "Harper", LastName = "Rivera", SchoolID = 6, DivisionID = 2, Email = "hrivera16@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 21) },
                new { ContestantID = 17, FirstName = "James", LastName = "Cooper", SchoolID = 7, DivisionID = 5, Email = "jcooper17@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 22) },
                new { ContestantID = 18, FirstName = "Amelia", LastName = "Richardson", SchoolID = 8, DivisionID = 7, Email = "arichardson18@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 23) },
                new { ContestantID = 19, FirstName = "Benjamin", LastName = "Cox", SchoolID = 9, DivisionID = 9, Email = "bcox19@gmail.com", CheckInStatus = false, RegistrationDate = new DateTime(2026, 2, 24) },
                new { ContestantID = 20, FirstName = "Mia", LastName = "Howard", SchoolID = 10, DivisionID = 6, Email = "mhoward20@gmail.com", CheckInStatus = true, RegistrationDate = new DateTime(2026, 2, 25) }
            );
        }

    }
}
