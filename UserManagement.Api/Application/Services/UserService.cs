using Microsoft.EntityFrameworkCore;
using UserManagement.API.Domain.Entities;
using UserManagement.Application.Interfaces;
using UserManagement.Application.DTOs;

namespace UserManagement.Application.Services;

public class UserService
{
    private readonly IApplicationDbContext _context;

    public UserService(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<UserResponse> CreateUserAsync(CreateUserRequest request)
    {
        var user = new User(
            request.FirstName,
            request.LastName,
            request.Email
        );

        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync(CancellationToken.None);

        return new UserResponse
        {
            Id = user.Id,
            FullName = $"{user.FirstName} {user.LastName}",
            Email = user.Email,
            IsActive = user.IsActive
        };
    }

    public async Task<List<UserResponse>> GetAllAsync()
    {
        var users = await _context.Users.ToListAsync();

        return users.Select(u => new UserResponse
        {
            Id = u.Id,
            FullName = $"{u.FirstName} {u.LastName}",
            Email = u.Email,
            IsActive = u.IsActive
        }).ToList();
    }
}

