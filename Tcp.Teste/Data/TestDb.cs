using System;
using System.Collections.Generic;
using System.Linq;
using Tcp.Teste.Api.Models;

namespace Tcp.Teste.Api.Data
{
    public class TestDb
    {
        private static TestDb _instance;
        public ICollection<ExportadorBrasileiro> ExportadorBrasileiroCollection { get => _exportadorBrasileiroCollection; }
        public ICollection<ExportadorParaguai> ExportadorParaguaiCollection { get => _exportadorParaguaiCollection; }
        private ICollection<ExportadorBrasileiro> _exportadorBrasileiroCollection;
        private ICollection<ExportadorParaguai> _exportadorParaguaiCollection;

        public static TestDb GetInstance()
        {
            if (_instance == null)
                _instance = new TestDb();

            return _instance;
        }

        // TODO this can be done with Generics
        public ICollection<ExportadorBrasileiro> GetAllExportadorBrasileiro()
        {
            return _exportadorBrasileiroCollection.ToList();
        }

        public ExportadorBrasileiro GetExportadorBrasileiroById(int id)
        {
            return _exportadorBrasileiroCollection.FirstOrDefault(x => x.Id == id);
        }

        private TestDb()
        {
            Populate();
        }

        private void Populate()
        {
            _exportadorBrasileiroCollection = new List<ExportadorBrasileiro>
            {
                new ExportadorBrasileiro { Id = 1, Nome = "Exportador Br A", Cnpj = "10.100.101/0001-10", Email = "exportadorbra@domain.com", Telefone = "+55 41 1234-5678" },
                new ExportadorBrasileiro { Id = 2, Nome = "Exportador Br B", Cnpj = "10.100.102/0001-10", Email = "exportadorbrb@domain.com", Telefone = "+55 41 1234-5678" },
                new ExportadorBrasileiro { Id = 3, Nome = "Exportador Br C", Cnpj = "10.100.103/0001-10", Email = "exportadorbrc@domain.com", Telefone = "+55 41 1234-5678" },
                new ExportadorBrasileiro { Id = 4, Nome = "Exportador Br D", Cnpj = "10.100.104/0001-10", Email = "exportadorbrd@domain.com", Telefone = "+55 41 1234-5678" },
                new ExportadorBrasileiro { Id = 5, Nome = "Exportador Br E", Cnpj = "10.100.105/0001-10", Email = "exportadorbre@domain.com", Telefone = "+55 41 1234-5678" }
            };

            _exportadorParaguaiCollection = new List<ExportadorParaguai>
            {
                new ExportadorParaguai { Id = 1, Nome = "Exportador Pr A", Email = "exportadorpra@domain.com", Telefone = "+55 41 1234-5678" },
                new ExportadorParaguai { Id = 2, Nome = "Exportador Pr B", Email = "exportadorprb@domain.com", Telefone = "+55 41 1234-5678" },
                new ExportadorParaguai { Id = 3, Nome = "Exportador Pr C", Email = "exportadorprc@domain.com", Telefone = "+55 41 1234-5678" },
                new ExportadorParaguai { Id = 4, Nome = "Exportador Pr D", Email = "exportadorprd@domain.com", Telefone = "+55 41 1234-5678" },
                new ExportadorParaguai { Id = 5, Nome = "Exportador Pr E", Email = "exportadorpre@domain.com", Telefone = "+55 41 1234-5678" }
            };
        }
    }
}
