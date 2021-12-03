using Academy.Esercitazione1.Core.Entities;
using GestionaleSpese.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Esercitazione1.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly ISpesaRepository _spesaRepository;
        private readonly IUtenteRepository _utenteRepository;

        public MainBusinessLayer(ICategoriaRepository categoriaRepo, ISpesaRepository spesaRepo, IUtenteRepository utenteRepo)
        {
            _categoriaRepository = categoriaRepo;
            _spesaRepository = spesaRepo;
            _utenteRepository = utenteRepo;
        }

        public IEnumerable<Spesa> FiltraSpeseMeseScorso()
        {
            var speseFiltrate = _spesaRepository.FetchAllFilter(e => e.Approvato &&
            e.Data >= DateTime.Today.AddDays(-DateTime.Today.Day + 1).AddMonths(-1) &&
            e.Data <= DateTime.Today.AddDays(-DateTime.Today.Day));

            return speseFiltrate;
        }

        public Spesa GetById(int id)
        {
            if (id <= 0)
                return null;

            return _spesaRepository.GetById(id);
        }

        public bool InserireNuovaSpesa(Spesa spesa)
        {
            if (spesa == null)
                return false;
            return _spesaRepository.Add(spesa);
        }

        public bool Update(Spesa spesaAggiornata)
        {
            if (spesaAggiornata == null)
                return false;

            return _spesaRepository.Update(spesaAggiornata);
        }
    }
}
