using BasicSocialMedia.Concrate;
using BasicSocialMedia.Concratel;
using BasicSocialMedia.Project.DAL.Repositories.Concrate;

namespace BasicSocialMediaMain;

public class MainProject
{
    static void Main(string[] args)
    {
        CommentRepository commentRepository = new CommentRepository();
        PostRepository postRepository = new PostRepository();
        UserDetailsRepository userDetailsRepository = new UserDetailsRepository();
        UserRepository userRepository = new UserRepository();

        UserDetails detail1 = new UserDetails()
        {
            Name = "Tural",
            Surname = "Huseynli",
            Birthday = DateTime.Today,
            Role = Role.Admin,
            CreateDate = DateTime.Now
        };

        User user1 = new User()
        {
            UserDetails = detail1,
            CreateDate = DateTime.Now
        };

        Post post1 = new Post()
        {
            Text = "test",
            CreateDate= DateTime.Now
        };

        Comment comment1 = new Comment()
        {
            Text = "test",
            CreateDate = DateTime.Now
        };

        userDetailsRepository.Add(detail1);
        userRepository.Add(user1);
        postRepository.Add(post1);
        commentRepository.Add(comment1);

        userDetailsRepository.SaveChanges();
        userRepository.SaveChanges();
        postRepository.SaveChanges();
        commentRepository.SaveChanges();

    }
}
