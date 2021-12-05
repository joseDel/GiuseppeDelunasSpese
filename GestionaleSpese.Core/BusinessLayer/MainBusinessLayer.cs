using Academy.Esercitazione1.Core.Entities;
using GestionaleSpese.Core.Interfaces;
using System;
using System.Collections;
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

        public IEnumerable<Spesa> FiltraSpeseMeseScorso(bool approvato)
        {
            if (approvato)
            {
                var speseFiltrate = _spesaRepository.FetchAllFilter(e => e.Approvato &&
                e.Data >= DateTime.Today.AddDays(-DateTime.Today.Day + 1).AddMonths(-1) &&
                e.Data <= DateTime.Today.AddDays(-DateTime.Today.Day));
                return speseFiltrate;
            }
            else
            {
                var speseFiltrate = _spesaRepository.FetchAllFilter(e => 
                e.Data >= DateTime.Today.AddDays(-DateTime.Today.Day + 1).AddMonths(-1) &&
                e.Data <= DateTime.Today.AddDays(-DateTime.Today.Day));
                return speseFiltrate;
            }
        }

        public Object GetById(int id, string repo)
        {
            if (id <= 0)
                return null;

            if (repo == "spesa")
                return _spesaRepository.GetById(id);
            else if (repo == "utente")
                return _utenteRepository.GetById(id);
            else if (repo == "categoria")
                return _categoriaRepository.GetById(id);
            else return null;
        }

        public bool InserireNuovaSpesa(Spesa spesa)
        {
            if (spesa == null)
                return false;
            return _spesaRepository.Add(spesa);
        }

        public IEnumerable<Spesa> OrdinaPerData()
        {
            return _spesaRepository.OrdinaPerData();
        }

        public IEnumerable<Spesa> SpesePerUtente(int id)
        {
            if (id == null)
                return null;
            return _spesaRepository.FetchAllFilter(e => e.UtenteId == id);
        }

        public IEnumerable TotSpesePerCategoriaMeseScorso()
        {
            var speseMeseScorso = FiltraSpeseMeseScorso(true);
            return _spesaRepository.GroupBySum(speseMeseScorso);
        }

        public bool Update(Spesa spesaAggiornata)
        {
            if (spesaAggiornata == null)
                return false;

            return _spesaRepository.Update(spesaAggiornata);
        }
    }
}
