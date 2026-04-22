using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_ABBOTT.Migrations
{
    public partial class FixedRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 25);

            migrationBuilder.DropColumn(
                name: "Division",
                table: "Contestants");

            migrationBuilder.DropColumn(
                name: "School",
                table: "Contestants");

            migrationBuilder.RenameColumn(
                name: "DivisionId",
                table: "Divisions",
                newName: "DivisionID");

            migrationBuilder.AddColumn<int>(
                name: "DivisionID",
                table: "Contestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SchoolID",
                table: "Contestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 1,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 2,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 3,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 4,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 8, 4 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 5,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 6,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 10, 6 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 7,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 8,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 7, 8 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 9,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 10,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 6, 10 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 11,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 12,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 13,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 14,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 12, 4 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 15,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 11, 5 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 16,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 17,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 18,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 7, 8 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 19,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 20,
                columns: new[] { "DivisionID", "SchoolID" },
                values: new object[] { 6, 10 });

            migrationBuilder.CreateIndex(
                name: "IX_Contestants_DivisionID",
                table: "Contestants",
                column: "DivisionID");

            migrationBuilder.CreateIndex(
                name: "IX_Contestants_SchoolID",
                table: "Contestants",
                column: "SchoolID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contestants_Divisions_DivisionID",
                table: "Contestants",
                column: "DivisionID",
                principalTable: "Divisions",
                principalColumn: "DivisionID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contestants_Schools_SchoolID",
                table: "Contestants",
                column: "SchoolID",
                principalTable: "Schools",
                principalColumn: "SchoolID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contestants_Divisions_DivisionID",
                table: "Contestants");

            migrationBuilder.DropForeignKey(
                name: "FK_Contestants_Schools_SchoolID",
                table: "Contestants");

            migrationBuilder.DropIndex(
                name: "IX_Contestants_DivisionID",
                table: "Contestants");

            migrationBuilder.DropIndex(
                name: "IX_Contestants_SchoolID",
                table: "Contestants");

            migrationBuilder.DropColumn(
                name: "DivisionID",
                table: "Contestants");

            migrationBuilder.DropColumn(
                name: "SchoolID",
                table: "Contestants");

            migrationBuilder.RenameColumn(
                name: "DivisionID",
                table: "Divisions",
                newName: "DivisionId");

            migrationBuilder.AddColumn<string>(
                name: "Division",
                table: "Contestants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "School",
                table: "Contestants",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 1,
                columns: new[] { "Division", "School" },
                values: new object[] { "Computer Programming", "Northeast Community College" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 2,
                columns: new[] { "Division", "School" },
                values: new object[] { "Web Design and Development", "University of Nebraska–Lincoln" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 3,
                columns: new[] { "Division", "School" },
                values: new object[] { "Cybersecurity", "Wayne State College" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 4,
                columns: new[] { "Division", "School" },
                values: new object[] { "Health Knowledge Bowl", "Norfolk High School" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 5,
                columns: new[] { "Division", "School" },
                values: new object[] { "Computer Programming", "University of Nebraska at Omaha" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 6,
                columns: new[] { "Division", "School" },
                values: new object[] { "Job Interview", "Creighton University" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 7,
                columns: new[] { "Division", "School" },
                values: new object[] { "Welding", "Mid-Plains Community College" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 8,
                columns: new[] { "Division", "School" },
                values: new object[] { "Culinary Arts", "Kearney High School" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 9,
                columns: new[] { "Division", "School" },
                values: new object[] { "Graphic Communications", "University of Nebraska at Kearney" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 10,
                columns: new[] { "Division", "School" },
                values: new object[] { "Carpentry", "Central Community College" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 11,
                columns: new[] { "Division", "School" },
                values: new object[] { "Cybersecurity", "Northeast Community College" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 12,
                columns: new[] { "Division", "School" },
                values: new object[] { "Job Interview", "University of Nebraska–Lincoln" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 13,
                columns: new[] { "Division", "School" },
                values: new object[] { "Automotive Service Technology", "Wayne State College" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 14,
                columns: new[] { "Division", "School" },
                values: new object[] { "TeamWorks", "Norfolk High School" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 15,
                columns: new[] { "Division", "School" },
                values: new object[] { "Electrical Construction Wiring", "University of Nebraska at Omaha" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 16,
                columns: new[] { "Division", "School" },
                values: new object[] { "Web Design and Development", "Creighton University" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 17,
                columns: new[] { "Division", "School" },
                values: new object[] { "Welding", "Mid-Plains Community College" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 18,
                columns: new[] { "Division", "School" },
                values: new object[] { "Culinary Arts", "Kearney High School" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 19,
                columns: new[] { "Division", "School" },
                values: new object[] { "Graphic Communications", "University of Nebraska at Kearney" });

            migrationBuilder.UpdateData(
                table: "Contestants",
                keyColumn: "ContestantID",
                keyValue: 20,
                columns: new[] { "Division", "School" },
                values: new object[] { "Carpentry", "Central Community College" });

            migrationBuilder.InsertData(
                table: "Contestants",
                columns: new[] { "ContestantID", "CheckInStatus", "Division", "Email", "FirstName", "LastName", "RegistrationDate", "School" },
                values: new object[,]
                {
                    { 21, false, "Computer Programming", "dward21@gmail.com", "Daniel", "Ward", new DateTime(2026, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northeast Community College" },
                    { 22, true, "Cybersecurity", "etorres22@gmail.com", "Ella", "Torres", new DateTime(2026, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Nebraska–Lincoln" },
                    { 23, true, "Automotive Service Technology", "mpeterson23@gmail.com", "Matthew", "Peterson", new DateTime(2026, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne State College" },
                    { 24, false, "Health Knowledge Bowl", "sgray24@gmail.com", "Scarlett", "Gray", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norfolk High School" },
                    { 25, true, "Electrical Construction Wiring", "hjames25@gmail.com", "Henry", "James", new DateTime(2026, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Nebraska at Omaha" }
                });
        }
    }
}
