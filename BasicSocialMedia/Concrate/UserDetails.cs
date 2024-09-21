using BasicSocialMedia.Abstract;

namespace BasicSocialMedia.Concrate;

public class UserDetails : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birthday { get; set; }
    public Role Role { get; set; }

    //Navigation property
    public User User { get; set; }
}

public enum Role
{
    Admin,
    User
}