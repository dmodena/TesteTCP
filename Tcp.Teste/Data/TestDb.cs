using System.Collections.Generic;
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

        private TestDb()
        {
            Seed();
        }

        private void Seed()
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
                new ExportadorParaguai { Id = 1, Nome = "Exportador Pr A", Ruc = "12345A", Email = "exportadorpra@domain.com", Telefone = "+55 41 1234-5678" },
                new ExportadorParaguai { Id = 2, Nome = "Exportador Pr B", Ruc = "12345B", Email = "exportadorprb@domain.com", Telefone = "+55 41 1234-5678" },
                new ExportadorParaguai { Id = 3, Nome = "Exportador Pr C", Ruc = "12345C", Email = "exportadorprc@domain.com", Telefone = "+55 41 1234-5678" },
                new ExportadorParaguai { Id = 4, Nome = "Exportador Pr D", Ruc = "12345D", Email = "exportadorprd@domain.com", Telefone = "+55 41 1234-5678" }
            };
        }
    }
}
