using FinalProject_ABBOTT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject_ABBOTT.Models
{
    //This is essentially a glorified way to mass-seed data.
    internal class ConfigureSchools : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> entity)
        {
            entity.HasData( //Despite saying this project will not use AI, I am using it to seed the data, to cut time down.
                new {SchoolID = 1, SchoolName = "Northeast Community College", SchoolType = "College/PostSecondary", Location = "Norfolk" },
                new { SchoolID = 2, SchoolName = "University of Nebraska–Lincoln", SchoolType = "University", Location = "Lincoln" },
                new { SchoolID = 3, SchoolName = "Wayne State College", SchoolType = "College", Location = "Wayne" },
                new { SchoolID = 4, SchoolName = "Norfolk High School", SchoolType = "High School", Location = "Norfolk" },
                new { SchoolID = 5, SchoolName = "University of Nebraska at Omaha", SchoolType = "University", Location = "Omaha" },
                new { SchoolID = 6, SchoolName = "Creighton University", SchoolType = "University", Location = "Omaha" },
                new { SchoolID = 7, SchoolName = "Mid-Plains Community College", SchoolType = "College/PostSecondary", Location = "North Platte" },
                new { SchoolID = 8, SchoolName = "Kearney High School", SchoolType = "High School", Location = "Kearney" },
                new { SchoolID = 9, SchoolName = "University of Nebraska at Kearney", SchoolType = "University", Location = "Kearney" },
                new { SchoolID = 10, SchoolName = "Central Community College", SchoolType = "College/PostSecondary", Location = "Grand Island" }
                );
        }
    }
}

