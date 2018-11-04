using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgramming
{
    public class CRUDRepository<T> : ICRUDRepository<T>
    {
        public void Create(T entity)
        {
            Console.WriteLine($"Creating {entity}");
        }

        public IEnumerable<T> GetAll()
        {
            Console.WriteLine($"Getting all");
            return null;
        }

        public T GetById(int id)
        {
            Console.WriteLine($"Getting entity {id}");
            return default(T);
        }

        public void Update(T entity)
        {
            Console.WriteLine($"Updating {entity}");
        }

        public void Delete(T entity)
        {
            Console.WriteLine($"Deleting {entity}");
        }
    }
}
