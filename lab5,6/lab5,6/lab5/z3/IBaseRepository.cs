using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.lab5.z3
{
    public interface IBaseRepository<T, TEntity> where T : iEntity<TEntity>
    {
        T Get(TEntity id);
        void Create(T item);
        void Update(T item);
        void Delete(TEntity id);
        List<T> GetAll();
    }

 
}
