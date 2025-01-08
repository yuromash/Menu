using System.Collections.Generic;

namespace MenuBackend.Models
{
    public class Company
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Country { get; set; }
        public string? Slogan { get; set; }
        public required string Picture { get; set; }
        public bool IsAvailable { get; set; }
        public required string WebAppStyle { get; set; }
        public required string SecretCode { get; set; }

        public required ICollection<UserCompany> UserCompanies { get; set; }
        public ICollection<Menu>? Menus { get; set; }
    }
}