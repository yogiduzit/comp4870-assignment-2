using System;
using Microsoft.EntityFrameworkCore;
using StudentLibrary;

namespace StudentAPI.Data
{
  public class StudentDbContext : DbContext {
  public DbSet<Student> Students { get; set; }

  public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);

    builder.Entity<Student>().HasData(
      new {
        Id = Guid.NewGuid().ToString(),
        FirstName = "Jim",
        LastName = "Potter",
        BcitID = "A00123456",
        MobileNumber = "604-123-4567",
        EmailAddress = "jim@potter.com",
        CityOfResidence = "Chilliwack",
        Specialization = "Nursing"
      }, new {
        Id = Guid.NewGuid().ToString(),
        FirstName = "Jane",
        LastName = "Douglas",
        BcitID = "A00000001",
        MobileNumber = "111-111-1111",
        EmailAddress = "aa@aa.aa",
        CityOfResidence = "Vancouver",
        Specialization = "Computing"
      }, new {
        Id = Guid.NewGuid().ToString(),
        FirstName = "Tom",
        LastName = "Gardner",
        BcitID = "A00000002",
        MobileNumber = "222-222-2222",
        EmailAddress = "bb@bb.bb",
        CityOfResidence = "Abbotsford",
        Specialization = "Business"
      }, new {
        Id = Guid.NewGuid().ToString(),
        FirstName = "Ann",
        LastName = "Lee",
        BcitID = "A00000003",
        MobileNumber = "333-333-3333",
        EmailAddress = "cc@cc.cc",
        CityOfResidence = "Surrey",
        Specialization = "Aircraft Maintenance"
      }, new {
        Id = Guid.NewGuid().ToString(),
        FirstName = "James",
        LastName = "Jones",
        BcitID = "A00000004",
        MobileNumber = "444-444-4444",
        EmailAddress = "dd@dd.dd",
        CityOfResidence = "Burnaby",
        Specialization = "Marketing"
      }, new {
        Id = Guid.NewGuid().ToString(),
        FirstName = "Susan",
        LastName = "Taylor",
        BcitID = "A00000005",
        MobileNumber = "555-555-5555",
        EmailAddress = "ee@ee.ee",
        CityOfResidence = "Vancouver",
        Specialization = "Pilot"
      }, new {
        Id = Guid.NewGuid().ToString(),
        FirstName = "Peter",
        LastName = "White",
        BcitID = "A00000006",
        MobileNumber = "666-666-6666",
        EmailAddress = "ff@ff.ff",
        CityOfResidence = "Coquitlam",
        Specialization = "Engineering"
      }, new {
        Id = Guid.NewGuid().ToString(),
        FirstName = "Philip",
        LastName = "Fox",
        BcitID = "A00000007",
        MobileNumber = "777-777-7777",
        EmailAddress = "gg@gg.gg",
        CityOfResidence = "North-Vancouver",
        Specialization = "Instructor"
      }, new {
        Id = Guid.NewGuid().ToString(),
        FirstName = "Donna",
        LastName = "Ray",
        BcitID = "A00000008",
        MobileNumber = "888-888-8888",
        EmailAddress = "hh@hh.hh",
        CityOfResidence = "West-Vancouver",
        Specialization = "Instructor"
      }
    );
  }
}

}