using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Esercitazione1.Core.BusinessLayer;
using Academy.Esercitazione1.Core.Entities;
using GestionaleSpese.Core.Interfaces;
using GestioneSpese.Mock.Repos;

namespace GestioneSpese.ConsoleApp
{
    internal class Menu
    {
        private static readonly IBusinessLayer mainBL = new MainBusinessLayer(new MockCategoriaRepository(),
            new MockSpeseRepository(), new MockUtenteRepository());
        internal static void Start()
        {
            Console.WriteLine("Benvenuto!");

            char choice;

            do
            {
                Console.WriteLine("Scegli 1 per inserire una nuova spesa." +
                    "\nScegli 2 per approvare una spesa." +
                    "\nScegli 3 per visualizzare le spese del mese precedente." +
                    "\nScegli 4 per visualizzare le spese di uno specifico utente." +
                    "\nScegli 5 per visualizzare totale delle spese per categoria nello scorso mese." +
                    "\nScegli 6 per ordinare le spese a partire dalla più recente." +
                    "\nScegli Q per uscire");

                choice = Console.ReadKey().KeyChar;

                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        InserireNuovaSpesa();
                        break;
                    case '2':
                        ApprovareSpesa();
                        break;
                    case '3':
                        SpeseMeseScorso();
                        break;
                    case '4':
                        SpesePerUtente();
                        break;
                    case '5':
                        TotSpesePerCategoriaMeseScorso();
                        break;
                    case '6':
                        OrdinaSpeseCrono();
                        break;
                    case 'Q':
                        Console.WriteLine("Arrivederci");
                        break;
                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }

            } while (choice != 'Q');
        }

        private static void OrdinaSpeseCrono()
        {
            throw new NotImplementedException();
        }

        private static void TotSpesePerCategoriaMeseScorso()
        {
            // ottengo spese del mese scorso
            var risultato = mainBL.TotSpesePerCategoriaMeseScorso();
            foreach (var item in risultato)
            {
                Console.WriteLine($"{item}");
            }

        }

        private static void SpeseMeseScorso()
        {
            IEnumerable<Spesa> speseMeseScorso = mainBL.FiltraSpeseMeseScorso(true);
            Console.WriteLine("Le seguenti spese riguardanti il mese scorso sono state approvate: ");
            foreach (Spesa spesa in speseMeseScorso)
            {
                Console.WriteLine(spesa);

            }
        }

        private static void SpesePerUtente()
        {
            Console.WriteLine("Inserisci Id utente.");
            int id;

            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("\nPuoi inserire solo numeri interi. Riprova: ");
            }

            Utente u = (Utente)mainBL.GetById(id, "utente");
            IEnumerable<Spesa> spesePerUtente = mainBL.SpesePerUtente(id);
            Console.WriteLine("Elenco delle spese per l'utente selezionato: ");
            foreach (Spesa s in spesePerUtente)
                Console.WriteLine(s);
        }

        private static void ApprovareSpesa()
        {
            Console.Write($"\nInserisci Id della spesa: ");
            int id;

            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("\nPuoi inserire solo numeri interi. Riprova: ");
            }

            Spesa s = (Spesa)mainBL.GetById(id, "spesa");
            if (!s.Approvato) //se è falso che la spesa non è già approvata
                Console.WriteLine("Spesa già approvata");
            else
            {
                s.Approvato = true;

                bool isUpdated = mainBL.Update(s);

                if (isUpdated)
                    Console.WriteLine("Modifica effettuata");
                else Console.WriteLine("Ops... qualcosa è andato storto");
            }
        }

        private static void InserireNuovaSpesa()
        {
            string id;
            DateTime data;
            string descrizione;
            decimal importo;
            bool approvato;
            int catId;
            int utenteId;
            
            Console.WriteLine("Inserisci dati della spesa");

            Console.WriteLine("Data: ");
            while (!DateTime.TryParse(Console.ReadLine(), out data))
            {
                Console.WriteLine("Inserisci un formato corretto di data!");
            }

            Console.WriteLine("Descrizione: ");
            descrizione = Console.ReadLine();

            Console.WriteLine("Importo: ");
            while (!decimal.TryParse(Console.ReadLine(), out importo))
            {
                Console.WriteLine("Inserisci un formato corretto di importo!");
            }

            Console.WriteLine("Id utente: ");
            while (!int.TryParse(Console.ReadLine(), out utenteId))
            {
                Console.WriteLine("Inserisci un formato corretto.");
            }

            Console.WriteLine("Id categoria: ");
            while (!int.TryParse(Console.ReadLine(), out catId))
            {
                Console.WriteLine("Inserisci un formato corretto.");
            }

            Spesa spesa = new Spesa()
            {
                Data = data,
                Descrizione = descrizione,
                Approvato = false,
                Importo = importo,
                UtenteId = utenteId,
                CategoriaId = catId,
            };

            bool correttamenteAggiunto = mainBL.InserireNuovaSpesa(spesa);
            if (correttamenteAggiunto)
                Console.WriteLine("La spesa è stata aggiunta correttamente.");
            else Console.WriteLine("Qualcosa è andato storto.");
        }
    }
}
