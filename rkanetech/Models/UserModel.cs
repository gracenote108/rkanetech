using System.ComponentModel.DataAnnotations;

namespace rkanetech.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required]
        public bool IsEnabled { get; set; }

        [Required]
        public DateTime DisabledDate { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }


        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }


    }
}
