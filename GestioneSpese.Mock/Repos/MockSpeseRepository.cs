using Academy.Esercitazione1.Core.Entities;
using Academy.Esercitazione1.Mock.Repos;
using GestionaleSpese.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Mock.Repos
{
    public class MockSpeseRepository : ISpesaRepository
    {
        public bool Add(Spesa spesa)
        {
            if (spesa == null)
                return false;

            spesa.Id = InMemoryStorage.spese.Max(b => b.Id) + 1;
            InMemoryStorage.spese.Add(spesa);
            return true;
        }

        public bool Delete(Spesa item)
        {
            throw new NotImplementedException();
        }

        public List<Spesa> FetchAll()
        {
            return InMemoryStorage.spese;
        }

        public IEnumerable<Spesa> FetchAllFilter(Func<Spesa, bool> filter = null)
        {
            if (filter != null)
            {
                var speseFiltrate = InMemoryStorage.spese.Where(filter).ToList();
                return speseFiltrate;
            }

            return InMemoryStorage.spese.ToList();
        }

        public Spesa GetById(int id)
        {
            return InMemoryStorage.spese.SingleOrDefault(b => b.Id == id);
        }

        public IEnumerable GroupBySum(IEnumerable<Spesa> spese)
        {
            var result = spese.GroupBy(a => a.CategoriaId).Select(a => new 
            { Totale = a.Sum(b => b.Importo), Categoria = a.Key }).OrderByDescending(a => a.Totale).ToList();

             return result;
        }

        public IEnumerable<Spesa> OrdinaPerData()
        {
            IEnumerable<Spesa> spese = FetchAll();
            var result =
                from spesa in spese
                orderby spesa.Data descending
                select spesa;
            return result;
        }

        public bool Update(Spesa spesaAggiornata)
        {
            var spesaDaModificare = GetById(spesaAggiornata.Id);
            var index = InMemoryStorage.spese.IndexOf(spesaDaModificare);
            if (index != -1) 
            {
                InMemoryStorage.spese[index] = spesaAggiornata; //nella lista, all'indice trovato, metto l'oggetto modificato

            }
            return false;
        }
    }
}
