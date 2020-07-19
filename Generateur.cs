using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.Version03
{
    class Generateur
    {
        
        public string Generation()
        {
            Terminal terminal = new Terminal();

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            terminal.Terminalfx("_______________________________________________________________");
            terminal.Terminalfx("\n  Création d’un personnage Donjon et Dragon * Règles 3.5 * \n");
            terminal.Terminalfx("_______________________________________________________________");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            // Race et Classe :

            Console.WriteLine("Sélectionner la race et la classe de votre personnage:");
            Console.WriteLine("");
            Console.WriteLine("Vous devez choisir ses deux éléments en même temps:");
            Console.WriteLine("car certaines races sont plus adaptées à certaines classes qu’à d’autres. ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Les races jouables sont: \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t 1 : Humain ");
            Console.WriteLine("\t 2 : Demi - Elfe ");
            Console.WriteLine("\t 3 : Demi - Orque ");
            Console.WriteLine("\t 4 : Elfe ");
            Console.WriteLine("\t 5 : Gnome ");
            Console.WriteLine("\t 6 : Halfelin ");
            Console.WriteLine("\t 7 : Nain ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Les classes jouables sont: \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t 1 : Barbare");
            Console.WriteLine("\t 2 : Barde");
            Console.WriteLine("\t 3 : Druide");
            Console.WriteLine("\t 4 : Ensorceleur");
            Console.WriteLine("\t 5 : Guerrier");
            Console.WriteLine("\t 6 : Magicien");
            Console.WriteLine("\t 7 : Moine");
            Console.WriteLine("\t 8 : Paladin");
            Console.WriteLine("\t 9 : Prêtre");
            Console.WriteLine("\t 10 : Rôdeur");
            Console.WriteLine("\t 11 : Roublard");
            Console.WriteLine("");

            // Faire la sélection

            int RaceDuPersonnage = 0;
            int ClasseDuPersonnage = 0;
            bool RaceIsValid = false;
            bool ClasseIsValid = false;
            string LaRaceDuPersonnage = "Non renseigné";
            string LaClasseDuPersonnage = "Non renseingé";

            Console.WriteLine("Entrez votre Race: choix[1 à 7]");

            while (!RaceIsValid)
            {
                string SaisieRace = Console.ReadLine();

                if (int.TryParse(SaisieRace, out RaceDuPersonnage))
                    if (RaceDuPersonnage > 0 && RaceDuPersonnage < 8)
                        RaceIsValid = true;
                    else
                        RaceIsValid = false;

                else
                {
                    RaceIsValid = false;
                    Console.WriteLine("La Race que vous avez choisi est invalide…");
                    Console.WriteLine("Veuillez recommencer.");
                }
            }
            Console.WriteLine("\n Votre choix est le: " + RaceDuPersonnage + "\n");

            if (RaceDuPersonnage == 1)
                LaRaceDuPersonnage = "Humain";
            else if (RaceDuPersonnage == 2)
                LaRaceDuPersonnage = "Demi - Elfe";
            else if (RaceDuPersonnage == 3)
                LaRaceDuPersonnage = "Demi - Orque";
            else if (RaceDuPersonnage == 4)
                LaRaceDuPersonnage = "Elfe";
            else if (RaceDuPersonnage == 5)
                LaRaceDuPersonnage = "Gnome";
            else if (RaceDuPersonnage == 6)
                LaRaceDuPersonnage = "Halfelin";
            else if (RaceDuPersonnage == 7)
                LaRaceDuPersonnage = "Nain";
            else
            {
                Console.WriteLine("Erreur dans le choix de race du personnage");
            }

            Console.WriteLine("\n Votre personnage va donc être un " + LaRaceDuPersonnage + "\n");

            Console.WriteLine("Entrez votre Classe: choix[1 à 11]");

            while (!ClasseIsValid)
            {
                string SaisieClasse = Console.ReadLine();

                if (int.TryParse(SaisieClasse, out ClasseDuPersonnage))
                    if (ClasseDuPersonnage > 0 && ClasseDuPersonnage < 12)
                        ClasseIsValid = true;
                    else
                        ClasseIsValid = false;

                else
                {
                    ClasseIsValid = false;
                    Console.WriteLine("La Classe que vous avez choisi est invalide…");
                    Console.WriteLine("Veuillez recommencer.");
                }
            }
            Console.WriteLine("\n Votre choix est le: " + ClasseDuPersonnage + "\n");

            if (ClasseDuPersonnage == 1)
                LaClasseDuPersonnage = "Barbare";
            else if (ClasseDuPersonnage == 2)
                LaClasseDuPersonnage = "Barde";
            else if (ClasseDuPersonnage == 3)
                LaClasseDuPersonnage = "Druide";
            else if (ClasseDuPersonnage == 4)
                LaClasseDuPersonnage = "Ensorceleur";
            else if (ClasseDuPersonnage == 5)
                LaClasseDuPersonnage = "Guerrier";
            else if (ClasseDuPersonnage == 6)
                LaClasseDuPersonnage = "Magicien";
            else if (ClasseDuPersonnage == 7)
                LaClasseDuPersonnage = "Moine";
            else if (ClasseDuPersonnage == 8)
                LaClasseDuPersonnage = "Paladin";
            else if (ClasseDuPersonnage == 9)
                LaClasseDuPersonnage = "Prêtre";
            else if (ClasseDuPersonnage == 10)
                LaClasseDuPersonnage = "Rôdeur";
            else if (ClasseDuPersonnage == 11)
                LaClasseDuPersonnage = "Roublard";
            else
            {
                Console.WriteLine("Erreur dans le choix de la classe du personnage");
            }

            Console.WriteLine("\n Votre personnage va donc être un " + LaClasseDuPersonnage + "\n");

            // Nom du Personnage, Sexe, Age, Taille, Poids :

            Console.WriteLine("\n Veuillez entrer le Nom que vous désirez utiliser pour ce personnage:");

            // Nom du Personnage RP ?
            // Là il était question de rendre les noms de personnage le plus RP possible.
            // Pas implementé.

            string SaisieNomDuPersonnage = "Non renseigné";
            
            SaisieNomDuPersonnage = Console.ReadLine();
            Console.WriteLine("\n Vous avez décidé d’appeller votre personnage: " + SaisieNomDuPersonnage + "\n");
            

            Console.WriteLine("\n Quel est le sexe de votre personnage [F/M]?");
            Console.WriteLine("\t -M = Masculin");
            Console.WriteLine("\t -F = Feminin");

            string SaisieSexeDuPersonnage = "Non renseigné";
            string LeSexeDuPersonnage = "Non renseigné";
            bool SexeIsValid = false;

            while (!SexeIsValid)
            {
                SaisieSexeDuPersonnage = Console.ReadLine();
                if (SaisieSexeDuPersonnage == "M" || SaisieSexeDuPersonnage == "m")
                {
                    LeSexeDuPersonnage = "Masculin";
                    SexeIsValid = true;
                    Console.WriteLine("\n Ton personnage est : " + LeSexeDuPersonnage);
                }
                else if (SaisieSexeDuPersonnage == "F" || SaisieSexeDuPersonnage == "f")
                {
                    LeSexeDuPersonnage = "Feminin";
                    SexeIsValid = true;
                    Console.WriteLine("\n Ton personnage est :" + LeSexeDuPersonnage);
                }
                else
                {
                    ClasseIsValid = false;
                    Console.WriteLine("Le Sexe que vous avez choisi est invalide…[F/M]");
                    Console.WriteLine("Veuillez recommencer.");
                }
            }

            // Taille et Poids : On verra plus tard car cela va aussi dépendre des résultats aux dés.
            // Age du personnage : Non implémenté.


            // Caractéristiques :
            // Valeurs de Caractéristiques :

            /* Déterminer une valeur : en laçant 4d6, 
             * ignorer le lancé le plus faible 
             * puis aditionner les trois autres résultats.
             * Noter les 6 résultats, puis les répartir dans les différentes Caractéristiques.
             */

            // Fonctionne grâce à Clan : revenir sur cette partie un de ses jours.

            Console.WriteLine("\n Début de la définition des caractéristiques de votre Personnage \n");
            Console.WriteLine("\n");

            int PremiereCaracteristique = ConfigurerCaracteristiques();
            int DeuxiemeCaracteristique = ConfigurerCaracteristiques();
            int TroisiemeCaracteristique = ConfigurerCaracteristiques();
            int QuatriemeCaracteristique = ConfigurerCaracteristiques();
            int CinquiemeCaracteristique = ConfigurerCaracteristiques();
            int SixiemeCaracteristique = ConfigurerCaracteristiques();

            // La pluspart des gens ont une moyenne des cractéristiques évoluant autour de 10/11
            // Le personnage est hors norme. 
            // Sa moyenne doit être supérieur à 12 = normal 
            // Augmenter au diminuer la difficulté du jeu en augmentant ou diminuant la moyenne des caractéristiques
            // Non implémenté.
            // 13 = facile
            // 11 = difficile etc...

            int MoyenneDesCarac;
            bool MoyenneIsValide = false;

            while (!MoyenneIsValide == true)
            {
                MoyenneDesCarac = (PremiereCaracteristique + DeuxiemeCaracteristique + TroisiemeCaracteristique + QuatriemeCaracteristique + CinquiemeCaracteristique + SixiemeCaracteristique) / 6;
                Console.WriteLine("\n La Moyenne des caracteristique est : " + MoyenneDesCarac);
                if (MoyenneDesCarac >= 12)
                {
                    Console.WriteLine("Votre Personnage est valide. \n");
                    MoyenneIsValide = true;
                }
                else
                {
                    Console.WriteLine("Votre Personnage est invalide.\n");
                    Console.WriteLine("Nous relançons les dés de caracteristiques.");
                    PremiereCaracteristique = ConfigurerCaracteristiques();
                    DeuxiemeCaracteristique = ConfigurerCaracteristiques();
                    TroisiemeCaracteristique = ConfigurerCaracteristiques();
                    QuatriemeCaracteristique = ConfigurerCaracteristiques();
                    CinquiemeCaracteristique = ConfigurerCaracteristiques();
                    SixiemeCaracteristique = ConfigurerCaracteristiques();
                    MoyenneIsValide = false;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Votre première caracteristique [1] vaut : " + PremiereCaracteristique);
            Console.WriteLine("Votre deuxième caracteristique [2] vaut : " + DeuxiemeCaracteristique);
            Console.WriteLine("Votre troisième caracteristique [3] vaut : " + TroisiemeCaracteristique);
            Console.WriteLine("Votre quatrième caracteristique [4]vaut : " + QuatriemeCaracteristique);
            Console.WriteLine("Votre cinquième caracteristique [5] vaut : " + CinquiemeCaracteristique);
            Console.WriteLine("Votre sixième caracteristique [6] vaut : " + SixiemeCaracteristique);

            Console.WriteLine("\n Vous devez désormais répartir ses valeurs entre les caractéristiques.");
            Console.WriteLine("Les caractéristiques du personnage sont : ");
            Console.WriteLine("\n\t Force \n\t Dextérité \n\t Constitution \n\t Intelligence \n\t Sagesse \n\t Charisme");

            int[] TableauDesCaracteristiques = { 0, PremiereCaracteristique, DeuxiemeCaracteristique, TroisiemeCaracteristique, QuatriemeCaracteristique, CinquiemeCaracteristique, SixiemeCaracteristique };

            int FOR;
            int DEX;
            int CONS;
            int INT;
            int SAG;
            int CHA;

            // Ajustements Raciaux :

            int[,] TableauDesAjustementsRaciaux;
            TableauDesAjustementsRaciaux = new int[7, 8]
            {
                 /*Race*/                                   { 0, 1, 2, 3, 4, 5, 6, 7, },
                 /*FOR */                                   { 0, 0, 0, 2, 0, -2, -2, 0,},
                 /*DEX */                                   { 0, 0, 0, 0, 2, 0, 2, 0,},
                 /*CONS*/                                   { 0, 0, 0, 0, -2, 2, 0, 2,},
                 /*INT */                                   { 0, 0, 0, -2, 0, 0, 0, 0,},
                 /*SAG */                                   { 0, 0, 0, 0, 0, 0, 0, 0,},
                 /*CHA */                                   { 0, 0, 0, -2, 0, 0, 0, -2,},
            };

            FOR = TableauDesCaracteristiques[SetCara("Force")];
            Console.WriteLine("La Force du Personnage vaut : " + FOR);
            FOR = FOR + TableauDesAjustementsRaciaux[1, RaceDuPersonnage];
            Console.WriteLine("La Force du Personnage avec son modificateur racial vaut : " + FOR);

            DEX = TableauDesCaracteristiques[SetCara("Dextérité")];
            Console.WriteLine("La Dextérité du Personnage vaut : " + DEX);
            DEX = DEX + TableauDesAjustementsRaciaux[2, RaceDuPersonnage];
            Console.WriteLine("La Dextérité du Personnage avec son modificateur racial vaut : " + DEX);

            CONS = TableauDesCaracteristiques[SetCara("Constitution")];
            Console.WriteLine("La Constitution du Personnage vaut : " + CONS);
            CONS = CONS + TableauDesAjustementsRaciaux[3, RaceDuPersonnage];
            Console.WriteLine("La Constitution du Personnage avec son modificateur racial vaut : " + CONS);

            INT = TableauDesCaracteristiques[SetCara("Intelligence")];
            Console.WriteLine("L’Intelligence du Personnage vaut : " + INT);
            INT = INT + TableauDesAjustementsRaciaux[4, RaceDuPersonnage];
            Console.WriteLine("L'intelligence du Personnage avec son modificateur racial vaut : " + INT);

            SAG = TableauDesCaracteristiques[SetCara("Sagesse")];
            Console.WriteLine("La Sagesse du Personnage vaut : " + SAG);
            SAG = SAG + TableauDesAjustementsRaciaux[5, RaceDuPersonnage];
            Console.WriteLine("La Sagesse du Personnage avec son modificateur racial vaut : " + SAG);

            CHA = TableauDesCaracteristiques[SetCara("Charisme")];
            Console.WriteLine("Le Charisme du Personnage vaut : " + CHA);
            CHA = CHA + TableauDesAjustementsRaciaux[6, RaceDuPersonnage];
            Console.WriteLine("La Constitution du Personnage avec son modificateur racial vaut : " + CHA);

            // Modificateurs de caractéristiques :

            int ModifFOR = 0;
            int ModifDEX = 0;
            int ModifCONS = 0;
            int ModifINT = 0;
            int ModifSAG = 0;
            int ModifCHA = 0;

            int[,] ValeursCaracteristiquesEtModificateurs;
            ValeursCaracteristiquesEtModificateurs = new int[2, 48]

            {
                { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47 },
                {(-5), (-5), (-4), (-4), (-3), (-3), (-2), (-2), (-1), (-1), 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16, 17, 17, 18, 18}
            };

            // Le Bug du 24/06/2018 a été réparé : Surveiller l'exécution de temps en temps.

            ModifFOR = ValeursCaracteristiquesEtModificateurs[1, FOR];
            Console.WriteLine("\n Modificateur de Force est : " + ModifFOR);

            ModifDEX = ValeursCaracteristiquesEtModificateurs[1, DEX];
            Console.WriteLine("\n Modificateur de Dextérité est : " + ModifDEX);

            ModifCONS = ValeursCaracteristiquesEtModificateurs[1, CONS];
            Console.WriteLine("\n Modificateur de Constitution est : " + ModifCONS);

            ModifINT = ValeursCaracteristiquesEtModificateurs[1, INT];
            Console.WriteLine("\n Modificateur d'Intelligence est : " + ModifINT);

            ModifSAG = ValeursCaracteristiquesEtModificateurs[1, SAG];
            Console.WriteLine("\n Modificateur de Sagesse est : " + ModifSAG);

            ModifCHA = ValeursCaracteristiquesEtModificateurs[1, CHA];
            Console.WriteLine("\n Modificateur de Charisme est : " + ModifCHA);

            // Personnage Injouable : 

            // Si somme (des modificateurs de carac + modificateurs de race) = 0

            int SommeDesModif;
            SommeDesModif = ModifFOR + ModifDEX + ModifCONS + ModifINT + ModifSAG + ModifCHA;

            if (SommeDesModif == 0)
            {
                Console.WriteLine("\nLa somme des modifications est égale à 0. Votre personnage est réputé : INJOUABLE.");
                Console.WriteLine("\nNous vous conseillons de relancer la console.");
            }
            else
            {
                Console.WriteLine("\nVotre personnage est réputé : JOUABLE.");
                Console.WriteLine("\nPoursuite de l'exécution du programme.");
            }

            // Si 0 caractéristique > 13
            // Non Implémenté.

            // Caractéristiques et lanceurs de sorts :
            // Caractéristique Primordiale : 
            // Intelligence = Magicien.
            // Sagesse = Prêtre, Druide, Paladin, Rôdeur.
            // Charisme = Ensorcelleur, Barde.
            // Les Sorts Bonus :
            // Valeurs = Lvl1, Lvl2, Lvl3
            //12-13 = 1 
            //14-15 = 1 , 1 
            //16-17 = 1 , 1, 1, 
            //18-19 = 1, 1, 1, 1
            //20-21 = 2, 1, 1, 1, 1
            //22-23 = 2, 2, 1, 1, 1, 1
            //24-25 = 2, 2, 2, 1, 1, 1, 1
            //26-27 = 2, 2, 2, 2, 1, 1, 1, 1
            //28-29 = 3, 2, 2, 2, 2, 1, 1, 1, 1
            //30-31 = 3, 3, 2, 2, 2, 2, 1, 1, 1
            //32-33 = 3, 3, 3, 2, 2, 2, 2, 1, 1
            //34-35 = 3, 3, 3, 3, 2, 2, 2, 2, 1
            //36-37 = 4, 3, 3, 3, 3, 2, 2, 2, 2
            //38-39 = 4, 4, 3, 3, 3, 3, 2, 2, 2
            //40-41 = 4, 4, 4, 3, 3, 3, 3, 2, 2
            //42-43 = 4, 4, 4, 4, 3, 3, 3, 3, 2
            //44-45 = 5, 4, 4, 4, 4, 3, 3, 3, 3
            //46-47 = 5, 5, 4, 4, 4, 4, 3, 3, 3

            // Non Implémenté.

            // Particularités Races et Classes :
            // taille
            // déplacement
            //

            // Les Compétences :

            // Les Dons :

            // Le Corps et l'Ame :

            // L'équipement :

            //Données de combat :
            // PV : Points de vie
            // CA : Classe d'armure 
            // INI : Initiative :
            // BnCAC : Bonus à l'attaque Corps à Corps :
            // BnAD : Bonus à l'attaque à Distance :
            // JRflx : Jet de Réflexes :
            // JVig : Jet de Vigeur :
            // JVol : Jet de Volonté :

            // Description de son apparence : 

            // Background :

            // Points d'Expérience et Level :



            // Bilan :

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("—–");
            Console.WriteLine("BILAN");
            Console.WriteLine("\n—–");
            Console.WriteLine("\n Votre Personnage est un " + LaRaceDuPersonnage + ".");
            Console.WriteLine("\n Il est de la classe " + LaClasseDuPersonnage + ".");
            Console.WriteLine("\n Son nom est : " + SaisieNomDuPersonnage);
            Console.WriteLine("\n Le sexe de votre personnage est " + LeSexeDuPersonnage);
            Console.WriteLine("");
            Console.WriteLine("FORCE : " + FOR);
            Console.WriteLine("DEXTERITE : " + DEX);
            Console.WriteLine("CONSTITUTION : " + CONS);
            Console.WriteLine("INTELLIGENCE : " + INT);
            Console.WriteLine("SAGESSE : " + SAG);
            Console.WriteLine("CHARISME : " + CHA);
            Console.WriteLine("");
            Console.WriteLine("\n Modificateur de Force est : " + ModifFOR);
            Console.WriteLine("\n Modificateur de Dextérité est : " + ModifDEX);
            Console.WriteLine("\n Modificateur de Constitution est : " + ModifCONS);
            Console.WriteLine("\n Modificateur d'Intelligence est : " + ModifINT);
            Console.WriteLine("\n Modificateur de Sagesse est : " + ModifSAG);
            Console.WriteLine("\n Modificateur de Charisme est : " + ModifCHA);
            Console.WriteLine("\n—–");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n Merci d’avoir testé le Générateur de Personnage Donjon et Dragon 3.5.");
            Console.WriteLine("une application de BB Informatique encore en version test.");
            Console.WriteLine("Vous pouvez faire parvenir vos suggestions d’amélioration de cette application à benoit@bbinformatique.fr");
            Console.WriteLine("\n\n Pour continuer : Appuyer sur n’importe qu’elle touche : pour fermer l’application.");

            return SaisieNomDuPersonnage;

        }

        static int ConfigurerCaracteristiques()
        {
            Lanceur PremierLancéD6 = new Lanceur();
            Lanceur DeuxièmeLancéD6 = new Lanceur();
            Lanceur TroisièmeLancéD6 = new Lanceur();
            Lanceur QuatrièmeLancéD6 = new Lanceur();
            int Caracteristique;
            int PremierLancé = PremierLancéD6.Lanceur1D6();
            int DeuxiemeLancé = DeuxièmeLancéD6.Lanceur1D6();
            int TroisiemeLancé = TroisièmeLancéD6.Lanceur1D6();
            int QuatriemeLancé = QuatrièmeLancéD6.Lanceur1D6();

            Console.WriteLine("Les résultats des lancés sont: {0}, {1}, {2}, {3}", PremierLancé, DeuxiemeLancé, TroisiemeLancé, QuatriemeLancé);

            // DropLowest.

            int[] ValeurDesLancés = { PremierLancé, DeuxiemeLancé, TroisiemeLancé, QuatriemeLancé };
            Array.Sort(ValeurDesLancés);
            Console.WriteLine("{0} Est la valeure de lancé la plus basse des quatres lancés.", ValeurDesLancés[0]);

            Caracteristique = ValeurDesLancés[1] + ValeurDesLancés[2] + ValeurDesLancés[3];

            return Caracteristique;

        }


        // Ceci n'est pas de moi : Retourner sur ce code plus tard
        /// <summary>
        /// Différent choix possible
        /// </summary>
        private static int[] Choice = { 0, 1, 2, 3, 4, 5, 6 };

        /// <summary>
        /// Permet de vérifier si le joueur à fait un choix possible pour sa caractéristique
        /// </summary>
        /// <param name="pCategorie">"Permet de personnalisé le message</param>
        /// <returns></returns>
        private static int SetCara(String pCategorie)
        {
            bool flag = false;
            int userChoice = 0;

            do
            {
                Console.WriteLine("\n La Caractéristique {0} de votre personnage doit être la valeur de la caractérisque numéro : [1-6]", pCategorie);
                String Saisie = Console.ReadLine();

                if (Saisie == "1" || Saisie == "2" || Saisie == "3" || Saisie == "4" || Saisie == "5" || Saisie == "6")
                {
                    int.TryParse(Saisie, out userChoice);

                    for (int i = 1; i < Choice.Length; i++)
                    {
                        if (Choice[i] == userChoice)
                        {
                            flag = true;

                            Choice[i] = -1;
                        }
                    }

                    if (flag == false)
                    {
                        Console.WriteLine("Vous avez déjà donné cette valeur");
                    }
                }

            } while (!flag);

            return userChoice;
        }
    }
}
