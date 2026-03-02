namespace UserManagement.API.Domain.Entities;

public class User
{
    public long Id { get; private set; }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }

    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }

    // Constructor for creating new users
    public User(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        IsActive = true;
        CreatedAt = DateTime.UtcNow;
    }

    // Business behavior
    public void Deactivate()
    {
        IsActive = false;
    }

    public void UpdateName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
