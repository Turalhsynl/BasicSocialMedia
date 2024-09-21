using BasicSocialMedia.Project.DAL.Context;
using BasicSocialMedia.Project.DAL.Repositories.Concrate;

namespace MainProject;

public class UnitOfWork
{
    private readonly SocialMediaDBContext _context;

    public UnitOfWork(SocialMediaDBContext context, CommentRepository commentRepository, PostRepository postRepository, UserRepository userRepository, UserDetailsRepository userDetailsRepository)
    {
        _context = context;
    }

    public CommentRepository CommentRepository { get; }
    public PostRepository PostRepository { get; }
    public UserRepository UserRepository { get; }
    public UserDetailsRepository UserDetailsRepository { get; }

}
