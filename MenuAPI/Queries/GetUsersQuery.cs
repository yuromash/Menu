using MediatR;

public class GetUsersQuery : IRequest<List<UserResponse>> { }