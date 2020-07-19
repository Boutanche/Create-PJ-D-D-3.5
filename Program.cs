using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.Version03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Lanceur LanceTestD6 = new Lanceur();
            Lanceur LanceTestD6Encore = new Lanceur();
            LanceTestD6.Lanceur1D6();
            LanceTestD6Encore.Lanceur1D6();

            Lanceur LanceTestD20 = new Lanceur();
            LanceTestD20.Lanceur1D20();

            Terminal terminal = new Terminal();

            
            Console.WriteLine("Print : " + LanceTestD6.ResultatDuLancé);
            Console.WriteLine("Print : " + LanceTestD6Encore.ResultatDuLancé);
            Console.WriteLine("Print : " + LanceTestD20.ResultatDuLancé);
            terminal.Terminalfx("...Phase de Tests et Initialisation Terminée...");
            */

            /// Début du Programme ///
            /// 

            /// Intitulé et Version ///
            /// 

            Console.WriteLine("Programme de génération de personnages Donjon & Dragon 3.5");
            Console.WriteLine("Version 0.3 du 26 / 06 / 2018");
            Console.WriteLine("Par BB Informatique ");
            Console.WriteLine(DateTime.Now + ".");

            /// Menu ///
            /// 
            Console.WriteLine("");
            Console.WriteLine("Menu du Programme :");
            Console.WriteLine("");
            Console.WriteLine("Que souhaitez-vous faire ?");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t Créer un nouveau personnage : [1]");

            string ChoixMenu;
            int SaisieMenu;
            ChoixMenu = Console.ReadLine();
         
            if (int.TryParse(ChoixMenu, out SaisieMenu))
                if (SaisieMenu == 1)
                {
                    Personnages NouveauPersonnage = new Personnages();
                    NouveauPersonnage.PersonnageJoueur();   
                }

            /// Tests Divers 
            /// 

            Console.WriteLine("");
                    
            /// Fin du Programme ///
            /// 


            Console.WriteLine("");
            Console.WriteLine("Appuyer sur une touche pour terminer l'exécution.");
            Console.ReadKey();
        }
    }
}
