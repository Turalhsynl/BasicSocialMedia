using BasicSocialMedia.Abstract;
using BasicSocialMedia.Project.DAL.Context;
using BasicSocialMedia.Project.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

public class Repository<T> : IRepository<T> where T : BaseEntity, new()
{
    private readonly SocialMediaDBContext _context;
    private readonly DbSet<T> _dbset;

    public Repository()
    {
        _context = new SocialMediaDBContext();
        _dbset = _context.Set<T>();
    }

    public void Add(T entity)
    {
        _dbset.Add(entity);
        entity.CreateDate = DateTime.Now;
    }

    public void Delete(int Id)
    {
        var entity = _dbset.FirstOrDefault(x => x.Id == Id);
        if (entity != null)
        {
            entity.IsDeleted = true;
            entity.DeleteDate = DateTime.Now;
        }
        else
            throw new NullReferenceException();
    }

    public ICollection<T> GetAll()
    {
        return _dbset.Where(t => t.IsDeleted == false).ToList();
    }

    public T GetById(int Id)
    {
        return _dbset.FirstOrDefault(t => t.Id == Id && t.IsDeleted == false);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _dbset.Update(entity);
    }
}