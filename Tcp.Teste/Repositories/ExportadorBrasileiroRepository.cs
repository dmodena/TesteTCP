using System;
using System.Collections.Generic;
using System.Linq;
using Tcp.Teste.Api.Data;
using Tcp.Teste.Api.Models;

namespace Tcp.Teste.Api.Repositories
{
    public class ExportadorBrasileiroRepository : IBaseRepository<ExportadorBrasileiro>
    {
        private TestDb _db;

        // TODO add dependency injection
        public ExportadorBrasileiroRepository()
        {
            _db = TestDb.GetInstance();
        }

        public void Add(ExportadorBrasileiro item)
        {
            try
            {
                _db.ExportadorBrasileiroCollection.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir item.", ex);
            }
        }

        public void Delete(int id)
        {
            var dbItem = _db.ExportadorBrasileiroCollection.FirstOrDefault(x => x.Id == id);

            if (dbItem == null)
                throw new Exception($"Exportador Brasileiro com Id {id} não existe.");

            _db.ExportadorBrasileiroCollection.Remove(dbItem);
        }

        public ICollection<ExportadorBrasileiro> GetAll()
        {
            return _db.ExportadorBrasileiroCollection.ToList();
        }

        public ExportadorBrasileiro GetById(int id)
        {
            return _db.ExportadorBrasileiroCollection.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, ExportadorBrasileiro item)
        {
            var dbItem = _db.ExportadorBrasileiroCollection.FirstOrDefault(x => x.Id == id);

            if (dbItem == null)
                throw new Exception($"Exportador Brasileiro com Id {id} não existe.");

            item.Id = id;
            _db.ExportadorBrasileiroCollection.Remove(dbItem);
            _db.ExportadorBrasileiroCollection.Add(item);
        }
    }
}
