using Foody.Domain.Commons;
using Foody.Domain.Enums;

namespace Foody.Domain.Entities.Users;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
    public UserRole Role { get; set; }
    public DateTime DateOfBirth { get; set; }
}
