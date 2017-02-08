﻿using System;
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
		/// Fonction qui renvoie un burger choisi.
		/// </summary>
		/// <returns>Renvoie le Burger choisi par le client.</returns>
		static public Article Choix(short categorie)
		{
			int entreeUtilisateur, debutBoucle = -1, finBoucle = -1;
			bool validerArticle = false, ConversionReussie = false, ChoixValide = false;
			string phraseChoix = "", confirmationChoix = "";
			Article article = new Article("", 0, 0);

			if (categorie == 1)
			{
				phraseChoix = "Quel Burger voulez-vous choisir ?";
				confirmationChoix = "Vous avez choisi le burger";
				debutBoucle = DonneePublique.debutBurger;
				finBoucle = DonneePublique.debutBoisson;
			}
			else if (categorie == 2)
			{
				phraseChoix = "Quelle Boisson voulez-vous choisir ?";
				confirmationChoix = "Vous avez choisi la boisson";
				debutBoucle = DonneePublique.debutBoisson;
				finBoucle = DonneePublique.debutSalade;
			}
			else if (categorie == 3)
			{
				phraseChoix = "Quelle Salade voulez-vous choisir ?";
				confirmationChoix = "Vous avez choisi la salade";
				debutBoucle = DonneePublique.debutSalade;
				finBoucle = DonneePublique.debutGlace;
			}
			else if (categorie == 4)
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
			Client.ChoixArticle(Commande.ListeArticle, article);
			return article;
		}

		/// <summary>
		/// Permet de choisir le type du menu.
		/// </summary>
		/// <returns>Renvoie un menu.</returns>
		public static Menu ChoixTypeMenu()
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
                        menu.TabArticle[0] = Choix((short)DonneePublique.Categories.Burger);
                        menu.TabArticle[1] = Choix((short)DonneePublique.Categories.Boisson);
                        quitter = true;
                        break;
                    case "2":
                        menu.TypeMenu = 2;
                        menu.TabArticle = new Article[3];
                        menu.TabArticle[0] = Choix((short)DonneePublique.Categories.Burger);
                        menu.TabArticle[1] = Choix((short)DonneePublique.Categories.Boisson);
                        menu.TabArticle[2] = Choix((short)DonneePublique.Categories.Salade);
                        quitter = true;
                        break;
                    case "3":
                        menu.TypeMenu = 3;
                        menu.TabArticle = new Article[4];
                        menu.TabArticle[0] = Choix((short)DonneePublique.Categories.Burger);
                        menu.TabArticle[1] = Choix((short)DonneePublique.Categories.Boisson);
                        menu.TabArticle[2] = Choix((short)DonneePublique.Categories.Salade);
                        menu.TabArticle[3] = Choix((short)DonneePublique.Categories.Glace);
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
		private static void MenuPrincipal()
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
		private static void Paiement()
		{
            string choixDuPaiement = "";
            bool quitter = false;
           
            do
            {
                switch (choixDuPaiement)
                {
                    case "1":
                        choixDuPaiement = "";
                        Caissier.EncaisserCB();
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
		private static void AfficherCommande(Commande commande)
		{
			Console.WriteLine("Commande {0}", commande.Numero);
			// TODO afficher le contenu
			Console.WriteLine("Commande payée: {0}", commande.Paye ? "OUI" : "NON");
			Console.WriteLine();
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
						Choix((short)DonneePublique.Categories.Burger);
						break;

					case "2":
						choixTypeArticle = "";
						Choix((short)DonneePublique.Categories.Boisson);
						break;

					case "3":
						choixTypeArticle = "";
						Choix((short)DonneePublique.Categories.Salade);
						break;

					case "4":
						choixTypeArticle = "";
						Choix((short)DonneePublique.Categories.Glace);
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
