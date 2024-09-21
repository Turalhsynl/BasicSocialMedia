using BasicSocialMedia.Abstract;

namespace BasicSocialMedia.Concrate;

public class User : BaseEntity
{
    //Foreign Key
    public int UserDetailsId { get; set; }

    //Navigation property
    public UserDetails UserDetails { get; set; }
    public ICollection<Post> Posts { get; set; }
}
