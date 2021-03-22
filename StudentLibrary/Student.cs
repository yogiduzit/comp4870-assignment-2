using System.ComponentModel.DataAnnotations;

namespace StudentLibrary
{
    public class Student {
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string BcitID { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string CityOfResidence { get; set; }
        [Required]
        public string Specialization { get; set; }
    }

}