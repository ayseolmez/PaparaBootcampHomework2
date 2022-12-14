using Member.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Member.Data.Abstract
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<int> Add(T entity);
        Task<int> Delete(int id);
        Task<int> Update(T entity, int id);

    }
}
