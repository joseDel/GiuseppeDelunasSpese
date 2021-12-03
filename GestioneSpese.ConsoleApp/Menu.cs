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
                Console.WriteLine("Scegli 1 per inserire nuova spesa." +
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
                        TotSpesePerCategoria();
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

        private static void TotSpesePerCategoria()
        {
            throw new NotImplementedException();
        }

        private static void SpeseMeseScorso()
        {
            throw new NotImplementedException();
        }

        private static void SpesePerUtente()
        {
            throw new NotImplementedException();
        }

        private static void ApprovareSpesa()
        {
            throw new NotImplementedException();
        }

        private static void InserireNuovaSpesa()
        {
            Spesa spesa = new Spesa();
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
            spesa.Data = data;

            Console.WriteLine("Descrizione: ");
            descrizione = Console.ReadLine();
            spesa.Descrizione = descrizione;

            Console.WriteLine("Importo: ");
            while (!decimal.TryParse(Console.ReadLine(), out importo))
            {
                Console.WriteLine("Inserisci un formato corretto di importo!");
            }
            spesa.Importo = importo;

            Console.WriteLine("Id utente: ");
            while (!int.TryParse(Console.ReadLine(), out utenteId))
            {
                Console.WriteLine("Inserisci un formato corretto.");
            }
            spesa.UtenteId = utenteId;

            Console.WriteLine("Id categoria: ");
            while (!int.TryParse(Console.ReadLine(), out catId))
            {
                Console.WriteLine("Inserisci un formato corretto.");
            }
            spesa.CategoriaId = catId;
            spesa.Approvato = false;
            spesa.Id = 10; // metto un numero a caso per prova, perché implementerò successivamente un metodo GetId

            mainBL.InserireNuovaSpesa(spesa);
        }
    }
}
