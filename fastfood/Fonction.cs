using System;
using System.Collections.Generic;

namespace fastfood
{
    /// <summary>
    /// Classe contenant toutes les fonctions utiles au fonctionnement de VégétaFood.
    /// </summary>
    abstract class Fonction
    {
        static public List<Commande> listeCommandes = new List<Commande>();

        /// <summary>
        /// Attend de l'utilisateur un nombre.
        /// </summary>
        /// <param name="entier">Stocke l'entier écrit par l'utilisateur(-1 par défaut).</param>
        /// <returns>Renvoie true si la conversion a réussie et faux si elle a raté.</returns>
        static public bool lireEntier(out int entier)
        {
            entier = -1;
            bool ConversionReussi = int.TryParse(Console.ReadLine(), out entier);
            return ConversionReussi;
        }

        /// <summary>
        /// Fonction qui renvoie l'article choisi.
        /// </summary>
        /// <returns>Renvoie l'article choisi par le client.</returns>
        static public Article Choix(short categorie, Commande commande)
        {
            int entreeUtilisateur, debutBoucle = -1, finBoucle = -1;
            bool validerArticle = false, ConversionReussie = false, ChoixValide = false;
            string phraseChoix = "", confirmationChoix = "";
            Article article = new Article("", 0, 0);

            if (categorie == (short)DonneePublique.Categories.Burger)
            {
                phraseChoix = "Quel Burger voulez-vous choisir ?";
                confirmationChoix = "Vous avez choisi le burger";
                debutBoucle = DonneePublique.debutBurger;
                finBoucle = DonneePublique.debutBoisson;
            }
            else if (categorie == (short)DonneePublique.Categories.Boisson)
            {
                phraseChoix = "Quelle Boisson voulez-vous choisir ?";
                confirmationChoix = "Vous avez choisi la boisson";
                debutBoucle = DonneePublique.debutBoisson;
                finBoucle = DonneePublique.debutSalade;
            }
            else if (categorie == (short)DonneePublique.Categories.Salade)
            {
                phraseChoix = "Quelle Salade voulez-vous choisir ?";
                confirmationChoix = "Vous avez choisi la salade";
                debutBoucle = DonneePublique.debutSalade;
                finBoucle = DonneePublique.debutGlace;
            }
            else if (categorie == (short)DonneePublique.Categories.Glace)
            {
                phraseChoix = "Quelle Glace voulez-vous choisir ?";
                confirmationChoix = "Vous avez choisi la glace";
                debutBoucle = DonneePublique.debutGlace;
                finBoucle = DonneePublique.ListeArticle.Length;
            }

            do
            {
                do
                {

                    do
                    {
                        Console.WriteLine(phraseChoix);
                        for (int i = debutBoucle; i < finBoucle; i++)
                        {
                            Console.WriteLine((i - debutBoucle + 1) + "." + DonneePublique.ListeArticle[i].Nom);
                        }

                        ConversionReussie = lireEntier(out entreeUtilisateur);

                    } while (!ConversionReussie);

                    entreeUtilisateur = entreeUtilisateur - 1;

                    if (entreeUtilisateur >= 0 && entreeUtilisateur < (finBoucle - debutBoucle))
                    {
                        article = DonneePublique.ListeArticle[entreeUtilisateur + debutBoucle];
                        article.Quantite++;
                        ChoixValide = true;
                    }
                    else
                    {
                        ChoixValide = false;
                    }

                } while (!ChoixValide);

                Console.WriteLine("{0} : {1}", confirmationChoix, article.Nom);
                Console.WriteLine("Etes vous sur de votre choix : {0} ?", article.Nom);

                do
                {
                    Console.WriteLine("1.Oui\n2.Non");
                    ConversionReussie = lireEntier(out entreeUtilisateur);
                } while (!ConversionReussie);

                if (entreeUtilisateur == 1)
                {
                    validerArticle = true;
                }
                else
                {
                    validerArticle = false;
                    article = new Article("", 0, 0);
                }

            } while (!validerArticle);
			if (validerArticle)
			{
				commande.ListeArticle = Client.ChoixArticle(commande.ListeArticle, article); // bug si non incremente la quantitée
			}
           
            return article;
        }

        /// <summary>
        /// Permet de choisir le type du menu.
        /// </summary>
        /// <returns>Renvoie un menu.</returns>
        public static Menu ChoixTypeMenu(Commande commande)
        {
            Menu menu = new Menu();
            bool quitter = false;
            string choix = "";
            do
            {
                switch (choix)
                {
                    case "1":
                        menu.TypeMenu = 1;
                        menu.TabArticle = new Article[2];
                        menu.TabArticle[0] = Choix((short)DonneePublique.Categories.Burger, commande);
                        menu.TabArticle[1] = Choix((short)DonneePublique.Categories.Boisson, commande);
                        quitter = true;
                        break;
                    case "2":
                        menu.TypeMenu = 2;
                        menu.TabArticle = new Article[3];
                        menu.TabArticle[0] = Choix((short)DonneePublique.Categories.Burger, commande);
                        menu.TabArticle[1] = Choix((short)DonneePublique.Categories.Boisson, commande);
                        menu.TabArticle[2] = Choix((short)DonneePublique.Categories.Salade, commande);
                        quitter = true;
                        break;
                    case "3":
                        menu.TypeMenu = 3;
                        menu.TabArticle = new Article[4];
                        menu.TabArticle[0] = Choix((short)DonneePublique.Categories.Burger, commande);
                        menu.TabArticle[1] = Choix((short)DonneePublique.Categories.Boisson, commande);
                        menu.TabArticle[2] = Choix((short)DonneePublique.Categories.Salade, commande);
                        menu.TabArticle[3] = Choix((short)DonneePublique.Categories.Glace, commande);
                        quitter = true;
                        break;
                    case "Q":
                    case "q":
                        quitter = true;
                        break;
                    default:
                        Console.WriteLine("Quel Menu voulez vous choisir : ");
                        Console.WriteLine("1. Petit");
                        Console.WriteLine("2. Moyen");
                        Console.WriteLine("3. Grand");
                        Console.WriteLine("Q. Quitter");
                        Console.WriteLine("\nSaisissez votre choix.");
                        choix = Console.ReadLine();
                        break;
                }
            } while (!quitter);
            return menu;
        }

        /// <summary>
        /// Choix de l'utilisateur : fonction utile au développeur pour se mettre dans la position du client ou du personnel de Végétafood.
        /// </summary>
        public static void AffichageMenuProg()
        {
            bool quitter = false;
            string choixDuPersonnage = "";

            do
            {
                switch (choixDuPersonnage)
                {
                    //Dans le cas d'un client
                    case "1":
                        choixDuPersonnage = "";
                        Console.Clear();
                        MenuPrincipal();
                        break;

                    //Dans le cas du personnel
                    case "2":
                        choixDuPersonnage = "";
                        Console.Clear();
                        MenuPersonnel();
                        break;

                    // pour sortir du programme
                    case "Q":
                    case "q":
                        choixDuPersonnage = "";
                        quitter = true;
                        Console.WriteLine("The end...");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Bonjour et bienvenue dans VégétaFood !");
                        Console.WriteLine("Veuillez nous indiquer si vous êtes client ou si vous faites partie du personnel :");
                        Console.WriteLine(" 1.Client");
                        Console.WriteLine(" 2.Personnel");
                        Console.WriteLine(" Q.Quitter");
                        Console.WriteLine("\nSaisissez votre choix.");
                        choixDuPersonnage = Console.ReadLine();
                        break;

                }
            } while (!quitter);
        }

        /// <summary>
        /// Choix du Menu Personnel. Preparateur caissier etc
        /// </summary>
        private static void MenuPersonnel()
        {

            Console.WriteLine("Liste des Commandes");
            if (listeCommandes.Count > 0)
            {
                // liste des commandes
                foreach (Commande commande in listeCommandes)
                {
                    AfficherCommande(commande);
                }
            }
            else
            {
                Console.WriteLine("Pas de commandes");
            }
            Console.ReadLine();

        }

        /// <summary>
        /// Choix du Menu Principal. Le client peut choisir son menu ou bien un article, etc. 
        /// </summary>
        public static void MenuPrincipal()
        {
            bool quitter = false;
            string choixDuMenu = "";
            Commande commande = new Commande();
            commande.Numero = Commande.counter;
            listeCommandes.Add(commande);

            do
            {
                switch (choixDuMenu)
                {
                    case "1":
                        choixDuMenu = "";
                        ChoixTypeMenu(commande);
                        break;
                    case "2":
                        choixDuMenu = "";
                        ChoixArticle(commande);
                        break;
                    case "3":
                        choixDuMenu = "";
                        if (commande.ListeArticle.Length > 1)
                        {
                            commande.ListeArticle = commande.annulerArticle(commande);
                        }
                        else if (commande.ListeArticle.Length == 1)
                        {
                            Article[] videTabArt = { };
                            commande.ListeArticle = videTabArt;
                        }
                        break;
                    case "4":
                        choixDuMenu = "";
                        break;
                    case "Q":
                    case "q":
                        quitter = true;
                        break;
                    case "5":
                        Paiement(commande);
                        break;
                    default:
                        Console.Clear();
                        AfficherCommande(commande);
                        Console.WriteLine("Bonjour et bienvenue dans VégétaFood !");
                        Console.WriteLine("--- CHOIX DE VOTRE COMMANDE --- ");
                        Console.WriteLine("1. Menu");
                        Console.WriteLine("2. Article");
                        Console.WriteLine("3. Annuler un article");
                        Console.WriteLine("4. Annuler le menu");
                        Console.WriteLine("5. Payer");
                        Console.WriteLine("Q. Quitter");
                        Console.WriteLine("\nSaisissez votre choix.");
                        choixDuMenu = Console.ReadLine();
                        break;
                }
            } while (!quitter);
        }

        /// <summary>
        /// 
        /// </summary>
        private static void Paiement(Commande commande)
        {
            string choixDuPaiement = "";
            bool quitter = false;

            do
            {
                switch (choixDuPaiement)
                {
                    case "1":
                        choixDuPaiement = "";
                        Caissier.EncaisserCB(commande);
                        break;
                    case "2":
                        choixDuPaiement = "";
                        Caissier.EncaisserEspece();
                        break;
                    case "3":
                        choixDuPaiement = "";
                        Caissier.EncaisserCheque();
                        break;
                    case "Q":
                    case "q":
                        quitter = true;
                        break;
                    default:
                        Console.Clear();
						Console.WriteLine("Vous allez payer la commande {0}", commande.Numero);
						AfficherCommande(commande);
						Console.WriteLine("--- CHOIX DE VOTRE PAIEMENT --- ");
                        Console.WriteLine("1. Paiement en CB");
                        Console.WriteLine("2. Paiement en espèces");
                        Console.WriteLine("3. Paiement en chèque");
                        Console.WriteLine("Q. Quitter");
                        Console.WriteLine("\nSaisissez votre choix.");
                        choixDuPaiement = Console.ReadLine();
                        break;
                }
            } while (!quitter);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void AfficherCommande(Commande commande)
        {
            double Total = 0;
            Console.WriteLine("Commande {0}", commande.Numero);
            for (short i = 0; i < commande.ListeArticle.Length; i++)
            {
                Console.WriteLine("{0}. {1,6}*{2} Prix : {3} euros.", i + 1, commande.ListeArticle[i].Nom, commande.ListeArticle[i].Quantite, commande.ListeArticle[i].Prix);
                Total = Total + commande.ListeArticle[i].Prix;
            }
            Console.WriteLine("Total : {0} euros.", Total);
            Console.WriteLine("Commande payée: {0}", commande.Paye ? "OUI" : "NON");
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        private static void ChoixArticle(Commande commande)
        {
            bool quitter = false;
            string choixTypeArticle = "";

            //Boucle forçant le client à choisir un menu valide
            do
            {
                switch (choixTypeArticle)
                {
                    case "1":
                        choixTypeArticle = "";
                        Choix((short)DonneePublique.Categories.Burger, commande);
                        break;

                    case "2":
                        choixTypeArticle = "";
                        Choix((short)DonneePublique.Categories.Boisson, commande);
                        break;

                    case "3":
                        choixTypeArticle = "";
                        Choix((short)DonneePublique.Categories.Salade, commande);
                        break;

                    case "4":
                        choixTypeArticle = "";
                        Choix((short)DonneePublique.Categories.Glace, commande);
                        break;

                    case "5":
                        choixTypeArticle = "";
                        MenuPrincipal();
                        break;
                    case "Q":
                    case "q":
                        quitter = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("--- CHOIX DE VOS ARTICLES --- ");
                        Console.WriteLine("1. Burger");
                        Console.WriteLine("2. Boisson");
                        Console.WriteLine("3. Salade");
                        Console.WriteLine("4. Glace");
                        Console.WriteLine("5. Retour");
                        Console.WriteLine("Q. Quitter");
                        Console.WriteLine("\nSaisissez votre choix.");
                        choixTypeArticle = Console.ReadLine();
                        break;

                }
            } while (!quitter);
        }
    }
}
