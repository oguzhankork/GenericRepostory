using ProjectEntities.Models;

namespace ProjectBll.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        NorthwndContext context = new NorthwndContext();
        public void Create(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            var updated = context.Set<T>().Find(entity);

            context
                .Entry(updated)
                .CurrentValues
                .SetValues(entity);
            context.SaveChanges();
        }
    }
}
