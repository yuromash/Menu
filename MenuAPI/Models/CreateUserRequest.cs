public class CreateUserRequest
{
    public required string Email { get; set; }
    public required string Role { get; set; } // Enum: Admin, SuperAdmin
}