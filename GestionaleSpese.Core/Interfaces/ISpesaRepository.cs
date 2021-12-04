using Academy.Esercitazione1.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionaleSpese.Core.Interfaces
{
    public interface ISpesaRepository : IRepository<Spesa>
    {
        IEnumerable GroupBySum(IEnumerable<Spesa> spese);
    }
}
