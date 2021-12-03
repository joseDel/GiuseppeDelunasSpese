using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Esercitazione1.Core.Entities;

namespace Academy.Esercitazione1.Mock.Repos
{
    public class InMemoryStorage
    {
        public static List<Categoria> categorie { get; set; } = new List<Categoria>()
        {
            new Categoria()
            {
                Id = 1,
                Nome = "Beni alimentari"
            },

            new Categoria()
            {
                Id = 2,
                Nome = "Spese mediche"
            },

            new Categoria()
            {
                Id = 2,
                Nome = "Trasporti"
            }
        };

        public static List<Utente> utenti { get; set; } = new List<Utente>()
        {
            new Utente()
            {
                Id = 1,
                Nome = "Franco",
                Cognome = "Melis"
            },

            new Utente()
            {
                Id = 2,
                Nome = "Rossella",
                Cognome = "Nonnis"
            },

            new Utente()
            {
                Id = 3,
                Nome = "Gina",
                Cognome = "Porceddu"
            },

            new Utente()
            {
                Id = 4,
                Nome = "Paolo",
                Cognome = "Caddeo"
            },

            new Utente()
            {
                Id = 5,
                Nome = "Lina",
                Cognome = "DeMartis"
            },
        };

        public static List<Spesa> spese { get; set; } = new List<Spesa>()
        {
            new Spesa()
            {
                Id = 1,
                Data = new DateTime(2021, 5, 18),
                Descrizione = " ",
                Importo = 300,
                Approvato = true,
                CategoriaId = 2,
                UtenteId = 1,
            },

            new Spesa()
            {
                Id = 2,
                Data = new DateTime(2021, 6, 15),
                Descrizione = " ",
                Importo = 150,
                Approvato = true,
                CategoriaId = 2,
                UtenteId = 2,
            },
            new Spesa()
            {
                Id = 3,
                Data = new DateTime(2021, 12, 8),
                Descrizione = " ",
                Importo = 78,
                Approvato = false,
                CategoriaId = 1,
                UtenteId = 3,
            },

            new Spesa()
            {
                Id = 4,
                Data = new DateTime(2021, 10, 12),
                Descrizione = " ",
                Importo = 80,
                Approvato = true,
                CategoriaId = 3,
                UtenteId = 4,
            },

            new Spesa()
            {
                Id = 5,
                Data = new DateTime(2021, 7, 20),
                Descrizione = " ",
                Importo = 249,
                Approvato = false,
                CategoriaId = 3,
                UtenteId = 5,
            },

            new Spesa()
            {
                Id = 6,
                Data = new DateTime(2021, 10, 23),
                Descrizione = " ",
                Importo = 450,
                Approvato = true,
                CategoriaId = 1,
                UtenteId = 5,
            },

            new Spesa()
            {
                Id = 7,
                Data = new DateTime(2021, 11, 28),
                Descrizione = " ",
                Importo = 19,
                Approvato = false,
                CategoriaId = 2,
                UtenteId = 3,
            },

            new Spesa()
            {
                Id = 8,
                Data = new DateTime(2021, 9, 12),
                Descrizione = " ",
                Importo = 320,
                Approvato = true,
                CategoriaId = 3,
                UtenteId = 2,
            },
        };
    }
}
