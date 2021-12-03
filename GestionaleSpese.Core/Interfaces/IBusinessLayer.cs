using Academy.Esercitazione1.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionaleSpese.Core.Interfaces
{
    public interface IBusinessLayer
    {
        public bool InserireNuovaSpesa(Spesa spesa);
        Spesa GetById(int id);
        bool Update(Spesa s);
        IEnumerable<Spesa> FiltraSpeseMeseScorso();
    }
}
