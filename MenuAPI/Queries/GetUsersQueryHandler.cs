using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<UserResponse>>
{
    private readonly AppDbContext _context;

    public GetUsersQueryHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<UserResponse>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        return await _context.Users
            .Select(u => new UserResponse
            {
                Id = u.Id,
                Email = u.Email,
                Role = u.Role
            })
            .ToListAsync();
    }
}