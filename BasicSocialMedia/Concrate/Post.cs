using BasicSocialMedia.Abstract;
using BasicSocialMedia.Concratel;

namespace BasicSocialMedia.Concrate;

public class Post : BaseEntity
{
    public string Text { get; set; }
    public int LikeCount { get; set; }

    //Foreign Key
    public int UserId { get; set; }

    //Navigation Property
    public User User { get; set; }
    public ICollection<Comment> Comments { get; set; }
}
