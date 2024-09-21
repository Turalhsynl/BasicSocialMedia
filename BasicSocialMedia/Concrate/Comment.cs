using BasicSocialMedia.Abstract;
using BasicSocialMedia.Concrate;

namespace BasicSocialMedia.Concratel;

public class Comment : BaseEntity
{
    public string Text { get; set; }
    public int LikeCount { get; set; }
    public ICollection<Post> Posts { get; set; }
}
