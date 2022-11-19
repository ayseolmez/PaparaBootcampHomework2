using Member.Data.Abstract;
using Member.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Member.Data.Concrete
{
    public class MemberRepository : IMemberRepository
    {
        public Task<int> Add(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BaseEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BaseEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(BaseEntity entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
