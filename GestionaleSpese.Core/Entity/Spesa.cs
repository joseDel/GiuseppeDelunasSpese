using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Esercitazione1.Core.Entities
{
    public class Spesa
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public  string Descrizione { get; set; }
        public decimal Importo { get; set; }
        public bool Approvato { get; set; }
        public int CategoriaId { get; set; }
        public int UtenteId { get; set; }

        public override string ToString()
        {
            return $"Spesa: Id -> {Id}, Importo -> {Importo}, Data -> {Data}, Stato di approvazione: {Approvato}" +
                    $"\nId utente: -> {UtenteId}, Id categoria: {CategoriaId}";
        }
    }
}
