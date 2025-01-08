using MediatR;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly AppDbContext _context;

    public CreateUserCommandHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        // Generate a temporary password
        var tempPassword = Guid.NewGuid().ToString("N").Substring(0, 8);
        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(tempPassword);

        // Create new user
        var user = new User
        {
            Email = request.Email,
            PasswordHash = hashedPassword,
            Role = request.Role
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        // Simulate email sending
        Console.WriteLine($"Temporary password sent to {request.Email}: {tempPassword}");

        return user.Id;
    }
}