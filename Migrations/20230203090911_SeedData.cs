using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace apbd_2023_egzamin_s16324.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "IdTeam", "Deadline", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2033, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Projekt Egzamin" },
                    { 2, new DateTime(2043, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Testowy" }
                });

            migrationBuilder.InsertData(
                table: "TaskType",
                columns: new[] { "IdTaskType", "Name" },
                values: new object[,]
                {
                    { 1, "Zrobić" },
                    { 2, "Ogarnąć" }
                });

            migrationBuilder.InsertData(
                table: "TeamMember",
                columns: new[] { "IdTeamMember", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "s16324@pjwstk.edu.pl", "Jakub", "Lewandowski" },
                    { 2, "basz@kot.pl", "Basz", "Kot" }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "IdTask", "Deadline", "Description", "IdAssignedTo", "IdCreator", "IdTaskType", "IdTeam", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2043, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "testowy opis", 1, 1, 1, 1, "Napisać egzamin" },
                    { 2, new DateTime(2044, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "testowy opis2", 1, 2, 2, 1, "Wrócić do domu" },
                    { 3, new DateTime(2045, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "testowy opis3", 1, 1, 1, 1, "Zalogować się do pracy" },
                    { 4, new DateTime(2046, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "testowy opi4s", 1, 2, 2, 1, "Udawać żę cały czas byłam w pracy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "IdTeam",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "IdTask",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "IdTask",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "IdTask",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "IdTask",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaskType",
                keyColumn: "IdTaskType",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "IdTeamMember",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "IdTeam",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaskType",
                keyColumn: "IdTaskType",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "IdTeamMember",
                keyValue: 1);
        }
    }
}
