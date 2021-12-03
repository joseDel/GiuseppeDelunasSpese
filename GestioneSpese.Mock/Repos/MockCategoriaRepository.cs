using Academy.Esercitazione1.Core.Entities;
using GestionaleSpese.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Mock.Repos
{
    public class MockCategoriaRepository : ICategoriaRepository
    {
        public bool Add(Categoria item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Categoria item)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> FetchAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> FetchAllFilter(Func<Categoria, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public Categoria GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Categoria item)
        {
            throw new NotImplementedException();
        }
    }
}
