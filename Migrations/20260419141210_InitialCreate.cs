using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_ABBOTT.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contestants",
                columns: table => new
                {
                    ContestantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    School = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckInStatus = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contestants", x => x.ContestantID);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    DivisionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TotalContestantSlots = table.Column<int>(type: "int", nullable: false),
                    FilledContestantSlots = table.Column<int>(type: "int", nullable: false),
                    EventTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CoordinatorName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.DivisionId);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    SchoolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.SchoolID);
                });

            migrationBuilder.InsertData(
                table: "Contestants",
                columns: new[] { "ContestantID", "CheckInStatus", "Division", "Email", "FirstName", "LastName", "RegistrationDate", "School" },
                values: new object[,]
                {
                    { 1, true, "Computer Programming", "ecarter1@gmail.com", "Ethan", "Carter", new DateTime(2026, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northeast Community College" },
                    { 2, true, "Web Design and Development", "mlopez2@gmail.com", "Maya", "Lopez", new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Nebraska–Lincoln" },
                    { 3, false, "Cybersecurity", "jreed3@gmail.com", "Jordan", "Reed", new DateTime(2026, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne State College" },
                    { 4, true, "Health Knowledge Bowl", "anguyen4@gmail.com", "Alyssa", "Nguyen", new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norfolk High School" },
                    { 5, true, "Computer Programming", "bfischer5@gmail.com", "Brandon", "Fischer", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Nebraska at Omaha" },
                    { 6, false, "Job Interview", "smartinez6@gmail.com", "Sofia", "Martinez", new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Creighton University" },
                    { 7, true, "Welding", "lturner7@gmail.com", "Liam", "Turner", new DateTime(2026, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mid-Plains Community College" },
                    { 8, false, "Culinary Arts", "cbennett8@gmail.com", "Chloe", "Bennett", new DateTime(2026, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kearney High School" },
                    { 9, true, "Graphic Communications", "nhughes9@gmail.com", "Noah", "Hughes", new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Nebraska at Kearney" },
                    { 10, true, "Carpentry", "ecollins10@gmail.com", "Emma", "Collins", new DateTime(2026, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central Community College" },
                    { 11, true, "Cybersecurity", "lward11@gmail.com", "Lucas", "Ward", new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northeast Community College" },
                    { 12, false, "Job Interview", "iprice12@gmail.com", "Isabella", "Price", new DateTime(2026, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Nebraska–Lincoln" },
                    { 13, true, "Automotive Service Technology", "lbell13@gmail.com", "Logan", "Bell", new DateTime(2026, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne State College" },
                    { 14, true, "TeamWorks", "amurphy14@gmail.com", "Ava", "Murphy", new DateTime(2026, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norfolk High School" },
                    { 15, false, "Electrical Construction Wiring", "ebailey15@gmail.com", "Elijah", "Bailey", new DateTime(2026, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Nebraska at Omaha" },
                    { 16, true, "Web Design and Development", "hrivera16@gmail.com", "Harper", "Rivera", new DateTime(2026, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Creighton University" },
                    { 17, true, "Welding", "jcooper17@gmail.com", "James", "Cooper", new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mid-Plains Community College" },
                    { 18, true, "Culinary Arts", "arichardson18@gmail.com", "Amelia", "Richardson", new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kearney High School" },
                    { 19, false, "Graphic Communications", "bcox19@gmail.com", "Benjamin", "Cox", new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Nebraska at Kearney" },
                    { 20, true, "Carpentry", "mhoward20@gmail.com", "Mia", "Howard", new DateTime(2026, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central Community College" },
                    { 21, false, "Computer Programming", "dward21@gmail.com", "Daniel", "Ward", new DateTime(2026, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northeast Community College" },
                    { 22, true, "Cybersecurity", "etorres22@gmail.com", "Ella", "Torres", new DateTime(2026, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Nebraska–Lincoln" },
                    { 23, true, "Automotive Service Technology", "mpeterson23@gmail.com", "Matthew", "Peterson", new DateTime(2026, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne State College" },
                    { 24, false, "Health Knowledge Bowl", "sgray24@gmail.com", "Scarlett", "Gray", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norfolk High School" },
                    { 25, true, "Electrical Construction Wiring", "hjames25@gmail.com", "Henry", "James", new DateTime(2026, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Nebraska at Omaha" }
                });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "DivisionId", "CoordinatorName", "EventTime", "FilledContestantSlots", "Name", "TotalContestantSlots" },
                values: new object[,]
                {
                    { 1, "Harvey Kingsley", new TimeSpan(0, 7, 0, 0, 0), 13, "Computer Programming", 20 },
                    { 2, "Melissa Grant", new TimeSpan(0, 8, 30, 0, 0), 18, "Web Design and Development", 18 },
                    { 3, "Daniel Ortiz", new TimeSpan(0, 9, 0, 0, 0), 12, "Cybersecurity", 16 },
                    { 4, "Brian Keller", new TimeSpan(0, 7, 30, 0, 0), 20, "Automotive Service Technology", 24 },
                    { 5, "Scott Ramirez", new TimeSpan(0, 10, 0, 0, 0), 14, "Welding", 15 },
                    { 6, "Jason Miller", new TimeSpan(0, 8, 0, 0, 0), 17, "Carpentry", 20 },
                    { 7, "Angela Dupree", new TimeSpan(0, 11, 0, 0, 0), 10, "Culinary Arts", 12 },
                    { 8, "Rachel Nguyen", new TimeSpan(0, 9, 30, 0, 0), 28, "Health Knowledge Bowl", 30 },
                    { 9, "Ethan Brooks", new TimeSpan(0, 10, 30, 0, 0), 9, "Graphic Communications", 14 },
                    { 10, "Lauren Mitchell", new TimeSpan(0, 13, 0, 0, 0), 21, "Job Interview", 25 },
                    { 11, "Kevin O'Connor", new TimeSpan(0, 7, 45, 0, 0), 16, "Electrical Construction Wiring", 18 },
                    { 12, "Derrick Holmes", new TimeSpan(0, 8, 15, 0, 0), 26, "TeamWorks", 30 }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolID", "Location", "SchoolName", "SchoolType" },
                values: new object[,]
                {
                    { 1, "Norfolk", "Northeast Community College", "College/PostSecondary" },
                    { 2, "Lincoln", "University of Nebraska–Lincoln", "University" },
                    { 3, "Wayne", "Wayne State College", "College" },
                    { 4, "Norfolk", "Norfolk High School", "High School" },
                    { 5, "Omaha", "University of Nebraska at Omaha", "University" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolID", "Location", "SchoolName", "SchoolType" },
                values: new object[,]
                {
                    { 6, "Omaha", "Creighton University", "University" },
                    { 7, "North Platte", "Mid-Plains Community College", "College/PostSecondary" },
                    { 8, "Kearney", "Kearney High School", "High School" },
                    { 9, "Kearney", "University of Nebraska at Kearney", "University" },
                    { 10, "Grand Island", "Central Community College", "College/PostSecondary" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contestants");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
