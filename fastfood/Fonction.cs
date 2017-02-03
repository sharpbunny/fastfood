using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
	/// <summary>
	/// Classe contenant toutes les fonctions utiles au fonctionnement de VégétaFood
	/// </summary>
	abstract class Fonction
	{

        static public Article ChoixBurger()
        {
            int entreeUtilisateur;
            bool validerBurger = false;
            Article burger = new Article("",0,0);

            do {
                Console.WriteLine("Quel Burger voulez vous choisir ?");
                for (int i = DonneePublique.debutBurger; i < DonneePublique.debutBoisson; i++)
                {
                    Console.WriteLine((i + 1) + "." + DonneePublique.ListeArticle[i].Nom);
                }
                entreeUtilisateur = Console.Read();

                do
                {
                    if (entreeUtilisateur < DonneePublique.debutBurger + 1 || entreeUtilisateur >= DonneePublique.debutBoisson)
                    {
                        Console.WriteLine("Quel Burger voulez vous choisir ?");
                        entreeUtilisateur = Console.Read();
                    }
                    entreeUtilisateur = Console.Read();
                } while (entreeUtilisateur < DonneePublique.debutBurger + 1 || entreeUtilisateur >= DonneePublique.debutBoisson);


            int indiceBurger = DonneePublique.debutBurger;
                bool burgerTrouve = false;
                while (entreeUtilisateur - 1 != indiceBurger || indiceBurger != DonneePublique.debutBoisson || !burgerTrouve)
                {
                    if (entreeUtilisateur == indiceBurger)
                    {
                        burger = DonneePublique.ListeArticle[indiceBurger];
                        burgerTrouve = true;
                        Console.WriteLine("Vous avez choisi le burger " + DonneePublique.ListeArticle[indiceBurger].Nom + ".");
                    }
                    indiceBurger++;
                }
                Console.WriteLine("Etes vous sur de votre choix : " + DonneePublique.ListeArticle[indiceBurger - 1].Nom + " ?");
                Console.WriteLine("1.Oui\n2.Non");


                entreeUtilisateur = Console.Read();
                if (entreeUtilisateur == 1)
                {
                    validerBurger = true;
                }

            } while (!validerBurger);
            return burger;
        }

		public static Menu ChoixTypeMenu()
        {
            Menu menu = new Menu();
            menu.TypeMenu = Console.Read();
            Console.WriteLine("Quel Menu voulez vous choisir : ");
            do {
                Console.WriteLine("1.Petit\n2.Moyen\n3.Grand");
                menu.TypeMenu = Console.Read();
            } while(menu.TypeMenu <1 || menu.TypeMenu >3 );
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
		/// Choix de l'utilisateur : fonction utile au développeur pour se mettre dans la position du client ou du personnel de Végétafood
		/// </summary>
		public static void AffichageMenuProg()
		{
			bool choixValide;
			int choixDuPersonnageInt;
			char choixDuPersonnage;

			do
			{
				Console.WriteLine("Bonjour et bienvenue dans VégétaFood !");
				Console.WriteLine("Veuillez nous indiquer si vous êtes client ou si vous faites partie du personnel :");
				Console.WriteLine(" 1.Client");
				Console.WriteLine(" 2.Personnel");
				Console.WriteLine(" 3.Debug");
				choixDuPersonnage = Console.ReadKey(true).KeyChar;
				choixValide = int.TryParse(Convert.ToString(choixDuPersonnage), out choixDuPersonnageInt);

				if (choixValide) choixValide = (choixDuPersonnageInt < 1 || choixDuPersonnageInt > 3) ? false : true;
			} while (!choixValide);

			
			

			switch (choixDuPersonnage)
			{
				//Dans le cas d'un client
				case '1':
					Fonction.MenuPrincipal();
					break;
				
				//Dans le cas du personnel
				case '2':
					Console.WriteLine("Vous faites partie du personnel.\nVeuillez saisir le login : ");
					if (Console.ReadLine() == "admin")
					{
						Console.WriteLine("Veuillez saisir le mot de passe : ");
						if (Console.ReadLine() == "admin")
						{
							Console.WriteLine("Vous faites partie du personnel.");
						}
					}
					break;

				case '3':

					break;

				default:
					Console.WriteLine("Erreur 404");
					break;
			}

		}

		/// <summary>
		/// Choix du Menu Principal. Le client peut choisir son menu ou bien un article,etc. 
		/// </summary>
		private static void MenuPrincipal()
		{
			bool choixValide;
			int choixDuMenuInt;
			char choixDuMenu;

			do
			{
				Console.WriteLine("Bonjour et bienvenue dans VégétaFood !");
				Console.WriteLine("--- CHOIX DE VOTRE COMMANDE --- ");
				Console.WriteLine("1. Menu");
				Console.WriteLine("2. Article");
				Console.WriteLine("3. Annuler un article");
				Console.WriteLine("4. Annuler le menu");
				Console.WriteLine("5. Payer");
				Console.WriteLine("------------------------------------");
				Console.WriteLine("Indiquez votre numéro.");
				Console.WriteLine("------------------------------------");
				//TO DO : Afficher le menu.
				
				//On regarde si le client a saisi un nombre valide
				choixDuMenu = Console.ReadKey(true).KeyChar;
				choixValide = int.TryParse(Convert.ToString(choixDuMenu), out choixDuMenuInt);

				if (choixValide) choixValide = (choixDuMenuInt < 1 || choixDuMenuInt > 5) ? false : true;

			} while (!choixValide);

			

			switch (choixDuMenu)
			{
				case '1':
					Fonction.ChoixTypeMenu();
					break;
				case '2':
					ChoixArticle();
					break;
				case '3':
					break;
				case '4':
					break;
				case '5':
					break;

			}

		} //Fin Menu Principal

		/// <summary>
		/// 
		/// </summary>
		private static void ChoixArticle()
		{
			bool choixValide;
			int choixTypeArticleInt;
			char choixTypeArticle;

			//Boucle forçant le client à choisir un menu valide
			do
			{
				Console.Clear();
				
				Console.WriteLine("--- CHOIX DE VOS ARTICLES --- ");
				Console.WriteLine("1. Burger");
				Console.WriteLine("2. Boisson");
				Console.WriteLine("3. Salade");
				Console.WriteLine("4. Glace");
				Console.WriteLine("5. Retour");

				//On regarde si le client a saisi un nombre valide
				choixTypeArticle = Console.ReadKey(true).KeyChar;
				choixValide = int.TryParse(Convert.ToString(choixTypeArticle), out choixTypeArticleInt);

				if (choixValide) choixValide = (choixTypeArticleInt < 1 || choixTypeArticleInt > 5) ? false : true ;

			} while (!choixValide); //Fin de la boucle forçant le client à choisir un nombre valide


			switch (choixTypeArticle)
			{
				case '1':
					ChoixBurger();
					break;

				case '2':
					ChoixBoisson();
					break;

				case '3':
					ChoixSalade();
					break;
					
				case '4':
					ChoixGlace();
					break;
					
				case '5':
					MenuPrincipal();
					break;

				default:
					break;

			}
		}

	}




    }

