using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgramming
{
    class StudentLoggerRepository<T> : ICRUDRepository<T>
    {

        //The StudentLoggerRepository is an example of the Decorator pattern
        //It builds on top CrudRepository 
        private readonly ICRUDRepository<T> _decorated;

        public StudentLoggerRepository(ICRUDRepository<T> decorated)
        {
            _decorated = decorated;
        }
        public void Create(T entity)
        {
            Log($"In decorator - Before Adding {entity}");
            _decorated.Create(entity);
            Log($"In decorator - After Adding {entity}");
        }

        public void Delete(T entity)
        {
            Log($"In decorator - Before Deleting {entity}");
            _decorated.Delete(entity);
            Log($"In decorator - After Deleting {entity}");
        }

        public IEnumerable<T> GetAll()
        {
            Log("In decorator - Before Getting Entities");
            var result = _decorated.GetAll();
            Log("In decorator - After Getting Entities");
            return result;
        }

        public T GetById(int id)
        {
            Log("In decorator - Before Getting Entity by Id");
            var result = _decorated.GetById(id);
            Log("In decorator - After Getting Entity by Id");
            return result;
        }

        public void Update(T entity)
        {
            Log("In decorator - Before updating Entity by Id");
            _decorated.Update(entity);
            Log("In decorator - After updating Entity by Id");
        }

        private void Log(string msg, object arg = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg, arg);
            Console.ResetColor();
        }
    }
}
