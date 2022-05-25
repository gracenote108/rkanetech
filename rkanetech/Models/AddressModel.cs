using System.ComponentModel.DataAnnotations;

namespace rkanetech.Models
{
    public class AddressModel
    {
        [Key]
        public int AddressId { get; set; }

        public string Street { get; set; }
        
        public string Street2 { get; set; }
        
        public string Street3 { get; set; }
        
        public string Street4 { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
        
        public int ZipCode { get; set; }

        public string? Country { get; set; }
    }
}
