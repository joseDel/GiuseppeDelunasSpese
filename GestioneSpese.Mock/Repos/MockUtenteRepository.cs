using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Esercitazione1.Core.Entities;
using Academy.Esercitazione1.Mock.Repos;
using GestionaleSpese.Core.Interfaces;

namespace GestioneSpese.Mock.Repos
{
    public class MockUtenteRepository : IUtenteRepository
    {
        public bool Add(Utente item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Utente item)
        {
            throw new NotImplementedException();
        }

        public List<Utente> FetchAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Utente> FetchAllFilter(Func<Utente, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public Utente GetById(int id)
        {
            return InMemoryStorage.utenti.SingleOrDefault(b => b.Id == id);
        }

        public bool Update(Utente item)
        {
            throw new NotImplementedException();
        }
    }
}
