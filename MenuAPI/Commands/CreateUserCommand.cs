using MediatR;

public class CreateUserCommand : IRequest<int>
{
    public required string Email { get; set; }
    public required string Role { get; set; }
}