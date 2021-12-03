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

        public void InserireNuovaSpesa(Spesa spesa)
        {
            _spesaRepository.InserireNuovaSpesa(spesa);
        }
    }
}
