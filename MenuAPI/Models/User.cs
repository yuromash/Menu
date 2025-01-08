using MenuBackend.Models;
public class User
{
    public int Id { get; set; }
    public required string Email { get; set; }
    public required string Role { get; set; } // Enum: Admin, SuperAdmin
    public required string PasswordHash { get; set; } // For storing the hashed password


    public ICollection<UserCompany>? UserCompanies { get; set; }
}
