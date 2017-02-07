using System;

namespace fastfood
{
    /// <summary>
    /// Classe contenant toutes les fonctions utiles au fonctionnement de VégétaFood.
    /// </summary>
    abstract class Fonction
    {
        static public int lireEntier()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Fonction qui renvoie un burger choisi.
        /// </summary>
        /// <returns>Renvoie le Burger choisi par le client.</returns>
		static public Article ChoixBurger()
        {
            int entreeUtilisateur;
            bool validerBurger = false;
            Article burger = new Article("", 0, 0);

            do
            {
                Console.WriteLine("Quel Burger voulez vous choisir ?");
                for (int i = DonneePublique.debutBurger; i < DonneePublique.debutBoisson; i++)
                {
                    Console.WriteLine((i + 1) + "." + DonneePublique.ListeArticle[i].Nom);
                }

                do
                {
                    entreeUtilisateur = lireEntier();
                    if (entreeUtilisateur-1 < DonneePublique.debutBurger || entreeUtilisateur-1 >= DonneePublique.debutBoisson)
                    {
                        Console.WriteLine("Quel Burger voulez vous choisir ?");
                        
                    }

                } while (entreeUtilisateur-1 < DonneePublique.debutBurger || entreeUtilisateur-1 >= DonneePublique.debutBoisson);

                //int indiceBurger = DonneePublique.debutBurger;

                //bool burgerTrouve = false;
                //while (!burgerTrouve &&( entreeUtilisateur - 1 != indiceBurger || indiceBurger != DonneePublique.debutBoisson))
                //{
                //	if (entreeUtilisateur -1 == indiceBurger)
                //	{
                burger = DonneePublique.ListeArticle[entreeUtilisateur - 1];
                burger.Quantite++;
                //burgerTrouve = true;
                Console.WriteLine("Vous avez choisi le burger " + burger.Nom + ".");
                //	}
                //	indiceBurger++;
                //}
                Console.WriteLine("Etes vous sur de votre choix : " + burger.Nom + " ?");
                Console.WriteLine("1.Oui\n2.Non");
                entreeUtilisateur = lireEntier();

                if (entreeUtilisateur == 1)
                {
                    validerBurger = true;
                }
                else
                {
                    validerBurger = false;
                    burger = new Article("", 0, 0);
                }

            } while (!validerBurger);
            return burger;
        }

        /// <summary>
        /// Fonction qui renvoie une boisson choisie.
        /// </summary>
        /// <returns>Renvoie la Boisson choisi par le client.</returns>
		static public Article ChoixBoisson()
        {
            int entreeUtilisateur;
            bool validerBoisson = false;
            Article boisson = new Article("", 0, 0);

            do
            {
                Console.WriteLine("Quelle Boisson voulez vous choisir ?");
                for (int i = DonneePublique.debutBoisson; i < DonneePublique.debutSalade; i++)
                {
                    Console.WriteLine((i + 1) + "." + DonneePublique.ListeArticle[i].Nom);
                }

                do
                {
                    entreeUtilisateur = lireEntier();
                    if (entreeUtilisateur-1 < DonneePublique.debutBoisson  || entreeUtilisateur-1 >= DonneePublique.debutSalade)
                    {
                        Console.WriteLine("Quelle Boisson voulez vous choisir ?");
                        
                    }

                } while (entreeUtilisateur-1 < DonneePublique.debutBoisson  || entreeUtilisateur-1 >= DonneePublique.debutSalade);

                boisson = DonneePublique.ListeArticle[entreeUtilisateur - 1];
                boisson.Quantite++;

                Console.WriteLine("Vous avez choisi la boisson " + boisson.Nom + ".");

                Console.WriteLine("Etes vous sur de votre choix : " + boisson.Nom + " ?");
                Console.WriteLine("1.Oui\n2.Non");
                entreeUtilisateur = lireEntier();

                if (entreeUtilisateur == 1)
                {
                    validerBoisson = true;
                }
                else
                {
                    validerBoisson = false;
                    boisson = new Article("", 0, 0);
                }

            } while (!validerBoisson);
            return boisson;
        }

        /// <summary>
        /// Fonction qui renvoie une salade choisie.
        /// </summary>
        /// <returns>Renvoie la salade choisie par le client.</returns>
		static public Article ChoixSalade()
        {
            int entreeUtilisateur;
            bool validerSalade = false;
            Article salade = new Article("", 0, 0);

            do
            {
                Console.WriteLine("Quelle Salade voulez vous choisir ?");
                for (int i = DonneePublique.debutSalade; i < DonneePublique.debutGlace; i++)
                {
                    Console.WriteLine((i + 1) + "." + DonneePublique.ListeArticle[i].Nom);
                }

                do
                {
                    entreeUtilisateur = lireEntier();
                    if (entreeUtilisateur-1 < DonneePublique.debutSalade || entreeUtilisateur-1 >= DonneePublique.debutGlace)
                    {
                        Console.WriteLine("Quelle Salade voulez vous choisir ?");
                        
                    }

                } while (entreeUtilisateur-1 < DonneePublique.debutSalade  || entreeUtilisateur-1 >= DonneePublique.debutGlace);

                salade = DonneePublique.ListeArticle[entreeUtilisateur - 1];
                //saladeTrouve = true;
                Console.WriteLine("Vous avez choisi la salade " + salade.Nom + ".");

                Console.WriteLine("Etes vous sûr de votre choix : " + salade.Nom + " ?");
                Console.WriteLine("1.Oui\n2.Non");
                entreeUtilisateur = lireEntier();

                if (entreeUtilisateur == 1)
                {
                    validerSalade = true;
                }
                else
                {
                    validerSalade = false;
                    salade = new Article("", 0, 0);
                }

            } while (!validerSalade);
            return salade;
        }

        /// <summary>
        /// Fonction qui renvoie une glace choisie.
        /// </summary>
        /// <returns>Renvoie la Glace choisie par le client.</returns>
		static public Article ChoixGlace()
        {
            int entreeUtilisateur;
            bool validerGlace = false;
            Article glace = new Article("", 0, 0);

            do
            {
                Console.WriteLine("Quelle Glace voulez vous choisir ?");
                for (int i = DonneePublique.debutGlace; i < DonneePublique.ListeArticle.Length; i++)
                {
                    Console.WriteLine((i + 1) + "." + DonneePublique.ListeArticle[i].Nom);
                }


                do
                {
                    entreeUtilisateur = lireEntier();
                    if (entreeUtilisateur-1 < DonneePublique.debutGlace || entreeUtilisateur-1 >= DonneePublique.ListeArticle.Length)
                    {
                        Console.WriteLine("Quelle Glace voulez vous choisir ?");
                        
                    }

                } while (entreeUtilisateur-1 < DonneePublique.debutGlace  || entreeUtilisateur-1 >= DonneePublique.ListeArticle.Length);

                glace = DonneePublique.ListeArticle[entreeUtilisateur - 1];

                Console.WriteLine("Vous avez choisi la glace " + glace.Nom + ".");

                Console.WriteLine("Etes vous sûr de votre choix : " + glace.Nom + " ?");
                Console.WriteLine("1.Oui\n2.Non");


                entreeUtilisateur = lireEntier();
                if (entreeUtilisateur == 1)
                {
                    validerGlace = true;
                }
                else
                {
                    validerGlace = false;
                    glace = new Article("", 0, 0);
                }

            } while (!validerGlace);
            return glace;
        }

        /// <summary>
        /// Permet de choisir le type du menu.
        /// </summary>
        /// <returns>Renvoie un menu.</returns>
		public static Menu ChoixTypeMenu()
        {
            Menu menu = new Menu();

            do
			{
				Console.WriteLine("Quel Menu voulez vous choisir : ");
				Console.WriteLine("1.Petit\n2.Moyen\n3.Grand");
				Console.WriteLine("\nSaisissez votre choix.");
				menu.TypeMenu = lireEntier();
                
            } while (menu.TypeMenu < 1 || menu.TypeMenu > 3);

			switch (menu.TypeMenu)
			{
				case 1:
					menu.TabArticle = new Article[2];
					menu.TabArticle[0] = ChoixBurger();
					menu.TabArticle[1] = ChoixBoisson();
					break;
				case 2:
					menu.TabArticle = new Article[3];
					menu.TabArticle[0] = ChoixBurger();
					menu.TabArticle[1] = ChoixBoisson();
					menu.TabArticle[2] = ChoixSalade();

					break;
				case 3:
					menu.TabArticle = new Article[4];
					menu.TabArticle[0] = ChoixBurger();
					menu.TabArticle[1] = ChoixBoisson();
					menu.TabArticle[2] = ChoixSalade();
					menu.TabArticle[3] = ChoixGlace();
					break;
			}
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
						MenuPrincipal();
						break;

					//Dans le cas du personnel
					case "2":
						choixDuPersonnage = "";
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

		}

		/// <summary>
		/// Choix du Menu Principal. Le client peut choisir son menu ou bien un article, etc. 
		/// </summary>
		private static void MenuPrincipal()
		{
			bool quitter = false;
			string choixDuMenu = "";

			do
			{
				switch (choixDuMenu)
				{
					case "1":
						choixDuMenu = "";
						ChoixTypeMenu();
						break;
					case "2":
						choixDuMenu = "";
						ChoixArticle();
						break;
					case "3":
						choixDuMenu = "";
						break;
					case "4":
						choixDuMenu = "";
						break;
					case "5":
						choixDuMenu = "";
						Paiement();
						break;
					case "Q":
					case "q":
						quitter = true;
						break;
					default:
						Console.Clear();
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
		private static void Paiement()
		{
			Console.WriteLine("Paiement");
			Console.ReadLine();
		}

		/// <summary>
		/// 
		/// </summary>
		private static void ChoixArticle()
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
						ChoixBurger();
						break;

					case "2":
						choixTypeArticle = "";
						ChoixBoisson();
						break;

					case "3":
						choixTypeArticle = "";
						ChoixSalade();
						break;

					case "4":
						choixTypeArticle = "";
						ChoixGlace();
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
