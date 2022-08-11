using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CourseDemo.Core.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();

        T GetById(Guid id);
        Task<T> GetByIdAsync(Guid id);

        void Insert(T entity);
        Task InsertAsync(T entity);

        T Update(T entity);
        //void Update(Guid id, T entity);        
        //Task UpdateAsync(Guid id, T entity);

        void Delete(Guid id);
        Task DeleteAsync(Guid id);

        T Find(Expression<Func<T, bool>> expression);
        T Find(Expression<Func<T, bool>> expression, string[] includes);
    }
}
