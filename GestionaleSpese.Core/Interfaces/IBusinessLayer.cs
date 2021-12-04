using Academy.Esercitazione1.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionaleSpese.Core.Interfaces
{
    public interface IBusinessLayer
    {
        public bool InserireNuovaSpesa(Spesa spesa);
        Object GetById(int id, string repo);
        bool Update(Spesa s);
        IEnumerable<Spesa> FiltraSpeseMeseScorso(bool approvato = false);
        IEnumerable<Spesa> SpesePerUtente(int id);
        IEnumerable TotSpesePerCategoriaMeseScorso();
    }
}
