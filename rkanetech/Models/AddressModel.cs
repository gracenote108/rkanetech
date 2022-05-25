using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rkanetech.Models
{
    public class AddressModel
    {
        [Key]
        public int AddressId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required]
        public bool IsEnabled { get; set; }

        [Required]
        public DateTime DisabledDate { get; set; }

        [Required]
        public int UserId { get; set; }
        public UserModel User { get; set; }

        [Required]
        public string Street { get; set; }
        
        public string? Street2 { get; set; }
        
        public string? Street3 { get; set; }
        
        public string? Street4 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public int ZipCode { get; set; }

        public string? Country { get; set; }
    }
}
