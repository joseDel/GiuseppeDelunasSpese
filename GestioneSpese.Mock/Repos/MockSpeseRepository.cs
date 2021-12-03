using Academy.Esercitazione1.Core.Entities;
using GestionaleSpese.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Mock.Repos
{
    public class MockSpeseRepository : ISpesaRepository
    {
        public void InserireNuovaSpesa(Spesa spesa)
        {
            List<Spesa> spesaList = new List<Spesa>();
            spesaList.Add(spesa);
        }
    }
}
