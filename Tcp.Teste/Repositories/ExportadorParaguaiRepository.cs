using System;
using System.Collections.Generic;
using System.Linq;
using Tcp.Teste.Api.Data;
using Tcp.Teste.Api.Models;

namespace Tcp.Teste.Api.Repositories
{
    public class ExportadorParaguaiRepository : IBaseRepository<ExportadorParaguai>
    {
        private TestDb _db;

        // TODO add dependency injection
        public ExportadorParaguaiRepository()
        {
            _db = TestDb.GetInstance();
        }

        public void Add(ExportadorParaguai item)
        {
            try
            {
                _db.ExportadorParaguaiCollection.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir item.", ex);
            }
        }

        public void Delete(int id)
        {
            var dbItem = _db.ExportadorParaguaiCollection.FirstOrDefault(x => x.Id == id);

            if (dbItem == null)
                throw new Exception($"Exportador Paraguai com Id {id} não existe.");

            _db.ExportadorParaguaiCollection.Remove(dbItem);
        }

        public ICollection<ExportadorParaguai> GetAll()
        {
            return _db.ExportadorParaguaiCollection.ToList();
        }

        public ExportadorParaguai GetById(int id)
        {
            return _db.ExportadorParaguaiCollection.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, ExportadorParaguai item)
        {
            var dbItem = _db.ExportadorParaguaiCollection.FirstOrDefault(x => x.Id == id);

            if (dbItem == null)
                throw new Exception($"Exportador Paraguai com Id {id} não existe.");

            item.Id = id;
            _db.ExportadorParaguaiCollection.Remove(dbItem);
            _db.ExportadorParaguaiCollection.Add(item);
        }
    }
}
