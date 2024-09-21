using BasicSocialMedia.Abstract;
using System.Linq.Expressions;

namespace BasicSocialMedia.Project.DAL.Repositories.Abstract;

public interface IRepository<T> where T : BaseEntity, new()
{
    public void Add(T entity);
    public void Update(T entity);
    public void Delete(int Id);
    public T GetById(int Id);
    public ICollection<T> GetAll();
    public void SaveChanges();

}
