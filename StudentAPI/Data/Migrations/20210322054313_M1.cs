using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAPI.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    BcitID = table.Column<string>(type: "TEXT", nullable: false),
                    MobileNumber = table.Column<string>(type: "TEXT", nullable: false),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: false),
                    CityOfResidence = table.Column<string>(type: "TEXT", nullable: false),
                    Specialization = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "202eec22-94a0-4074-b6e0-e598199bd609", "A00123456", "Chilliwack", "jim@potter.com", "Jim", "Potter", "604-123-4567", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "eaa799f2-e4dd-4036-8f48-2154990c2cf1", "A00000001", "Vancouver", "aa@aa.aa", "Jane", "Douglas", "111-111-1111", "Computing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "f75258b0-c5d4-402f-925c-68cb959570d7", "A00000002", "Abbotsford", "bb@bb.bb", "Tom", "Gardner", "222-222-2222", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "31b8d2fa-ca07-42ce-9dc2-1743195af2b3", "A00000003", "Surrey", "cc@cc.cc", "Ann", "Lee", "333-333-3333", "Aircraft Maintenance" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "2b7be063-83fa-4460-bd72-09e9f7eb44a8", "A00000004", "Burnaby", "dd@dd.dd", "James", "Jones", "444-444-4444", "Marketing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "a1ee517c-30ab-48f5-b2a0-5a6c0e4d08c7", "A00000005", "Vancouver", "ee@ee.ee", "Susan", "Taylor", "555-555-5555", "Pilot" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "ece8ffa4-42fc-402e-9ff9-b4275a4a4c11", "A00000006", "Coquitlam", "ff@ff.ff", "Peter", "White", "666-666-6666", "Engineering" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "3431c40c-9454-4792-900c-03cfb0b8add2", "A00000007", "North-Vancouver", "gg@gg.gg", "Philip", "Fox", "777-777-7777", "Instructor" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "f1124c6f-4582-49a6-86a1-d95b963a910f", "A00000008", "West-Vancouver", "hh@hh.hh", "Donna", "Ray", "888-888-8888", "Instructor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
