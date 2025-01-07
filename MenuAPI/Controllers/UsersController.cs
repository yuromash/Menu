using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IConfiguration _configuration;

    public UsersController(AppDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
    {
        // Check if user already exists
        if (await _context.Users.AnyAsync(u => u.Email == request.Email))
        {
            return BadRequest(new { message = "User with this email already exists" });
        }

        // Generate temporary password
        var tempPassword = GenerateTemporaryPassword();

        // Hash the password
        var passwordHash = BCrypt.Net.BCrypt.HashPassword(tempPassword);

        // Create and save the user
        var user = new User
        {
            Email = request.Email,
            PasswordHash = passwordHash,
            Role = request.Role
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        // Send temporary password via email
        SendTemporaryPasswordEmail(request.Email, tempPassword);

        return Ok(new { message = "User created successfully. Temporary password sent to email." });
    }

    private string GenerateTemporaryPassword()
    {
        return Guid.NewGuid().ToString("N").Substring(0, 8); // 8-character random password
    }

    private void SendTemporaryPasswordEmail(string email, string tempPassword)
    {
        // Simulated email sending
        Console.WriteLine($"Sending email to {email}: Your temporary password is {tempPassword}");
        // Replace this with actual email sending logic (e.g., SMTP or a service like SendGrid).
    }
}