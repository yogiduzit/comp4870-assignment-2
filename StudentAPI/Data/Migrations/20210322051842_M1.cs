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
                values: new object[] { "bf4c9d70-3872-43ec-ba45-d252ff792bd8", "A00123456", "Chilliwack", "jim@potter.com", "Jim", "Potter", "604-123-4567", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "627d709d-502e-4a72-ba84-cf3c09381407", "A00000001", "Vancouver", "aa@aa.aa", "Jane", "Douglas", "111-111-1111", "Computing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "98ee1f83-5ddd-4a9e-9dbb-fff0fddb12b2", "A00000002", "Abbotsford", "bb@bb.bb", "Tom", "Gardner", "222-222-2222", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "9611f8ed-4ba3-40f5-aab2-25bc088fac17", "A00000003", "Surrey", "cc@cc.cc", "Ann", "Lee", "333-333-3333", "Aircraft Maintenance" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "bacb5700-ea46-4d64-9970-53f06786e911", "A00000004", "Burnaby", "dd@dd.dd", "James", "Jones", "444-444-4444", "Marketing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "56d76f0b-1a98-4788-99cc-a935d1f22b77", "A00000005", "Vancouver", "ee@ee.ee", "Susan", "Taylor", "555-555-5555", "Pilot" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "706c2c4e-ee96-46c6-b44d-efed6579bb75", "A00000006", "Coquitlam", "ff@ff.ff", "Peter", "White", "666-666-6666", "Engineering" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "66333f72-32e6-43bd-99b3-1bf848baa8c3", "A00000007", "North-Vancouver", "gg@gg.gg", "Philip", "Fox", "777-777-7777", "Instructor" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BcitID", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[] { "8f4dae03-d0f2-439d-8587-04b7f447e2f4", "A00000008", "West-Vancouver", "hh@hh.hh", "Donna", "Ray", "888-888-8888", "Instructor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
