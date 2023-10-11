using System.Collections.Generic;

namespace Tcp.Teste.Api.Repositories
{
    interface IBaseRepository<T>
    {
        public ICollection<T> GetAll();
        public T GetById(int id);
        public void Add(T item);
        public void Update(int id, T item);
        public void Delete(int id);
    }
}
