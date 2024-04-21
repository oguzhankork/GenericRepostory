using ProjectEntities.Models;

namespace ProjectBll.Services
{
    public interface IBaseService<T> where T: class
    {        

        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
