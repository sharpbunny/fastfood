using System;
using System.Collections.Generic;

namespace fastfood
{
	/// <summary>
	/// Classe contenant toutes les fonctions utiles au fonctionnement de VégétaFood.
	/// </summary>
	abstract class Fonction
	{
		/// <summary>
		/// Liste de toutes les commandes.
		/// </summary>
		static public List<Commande> listeCommandes = new List<Commande>();

		/// <summary>
		/// Attend de l'utilisateur un nombre.
		/// </summary>
		/// <param name="entier">Stocke l'entier écrit par l'utilisateur(-1 par défaut).</param>
		/// <returns>Renvoie vrai si la conversion a réussie et faux si elle a raté.</returns>
		static public bool lireEntier(out int entier)
		{
			entier = -1;
			bool conversionReussi = int.TryParse(Console.ReadLine(), out entier);
			return conversionReussi;
		}

		/// <summary>
		/// Fonction qui renvoie l'article choisi.
		/// </summary>
		/// <param name="categorie">Catégorie de l'article à choisir.</param>
		/// <param name="commande">Conserve la commande en cours.</param>
		/// <returns>Renvoie l'article choisi par le client.</returns>
		static public void Choix(short categorie, Commande commande)
		{
			int entreeUtilisateur;
			bool validerArticle = false;
			bool conversionReussie = false;
			bool choixValide = false;
			string phraseChoix = "";
			string confirmationChoix = "";

			Article article = new Article("",0,0,0);
			List<Article> listeChoix = new List<Article>();
			listeChoix = DonneePublique.ListeArticleParCategorie(categorie);

			if (categorie == (short)DonneePublique.Categories.Burger)
			{
				phraseChoix = "Quel Burger voulez-vous choisir ?";
				confirmationChoix = "Vous avez choisi le burger";
			}
			else if (categorie == (short)DonneePublique.Categories.Boisson)
			{
				phraseChoix = "Quelle Boisson voulez-vous choisir ?";
				confirmationChoix = "Vous avez choisi la boisson";
			}
			else if (categorie == (short)DonneePublique.Categories.Salade)
			{
				phraseChoix = "Quelle Salade voulez-vous choisir ?";
				confirmationChoix = "Vous avez choisi la salade";
			}
			else if (categorie == (short)DonneePublique.Categories.Glace)
			{
				phraseChoix = "Quelle Glace voulez-vous choisir ?";
				confirmationChoix = "Vous avez choisi la glace";
			}

			do
			{
				Console.Clear();
				do
				{
					Console.Clear();
					do
					{
						Console.Clear();
						Console.WriteLine(phraseChoix);
						int i = 0;
						foreach (Article articleChoix in listeChoix)
						{
							Console.WriteLine((i + 1) + ".{0,12} : {1}", articleChoix.Nom, articleChoix.Prix);
							i++;
						}

						conversionReussie = lireEntier(out entreeUtilisateur);

					} while (!conversionReussie);

					if ((entreeUtilisateur > 0) && (entreeUtilisateur <= listeChoix.Count))
					{
						article = listeChoix[entreeUtilisateur - 1];
						choixValide = true;
					}
					else
					{
						choixValide = false;
					}

				} while (!choixValide);

				do
				{
					Console.Clear();
					Console.WriteLine("{0} : {1}", confirmationChoix, article.Nom);
					Console.WriteLine("Êtes vous sur de votre choix : {0} ?", article.Nom);
					
					Console.WriteLine("1.Oui\n2.Non");
					conversionReussie = lireEntier(out entreeUtilisateur);
				} while (!conversionReussie);

				if (entreeUtilisateur == 1)
				{
					validerArticle = true;
					//article.Quantite++;
				}
				else
				{
					validerArticle = false;
					//article = new Article("",0,0,0);

				}

			} while (!validerArticle);
			commande.AjouterArticle(article, 1);

		}

		/// <summary>
		/// Permet de choisir le type du menu.
		/// </summary>
		/// <param name="commande">Conserve la commande en cours.</param>
		/// <returns>Renvoie un menu.</returns>
		public static void ChoixTypeMenu(Commande commande)
		{
			Console.Clear();
			bool quitter = false;
			string choix = "";
			do
			{
				switch (choix)
				{
					case "1":
						Choix((short)DonneePublique.Categories.Burger, commande);
						Choix((short)DonneePublique.Categories.Boisson, commande);
						quitter = true;
						break;
					case "2":
						Choix((short)DonneePublique.Categories.Burger, commande);
						Choix((short)DonneePublique.Categories.Boisson, commande);
						Choix((short)DonneePublique.Categories.Salade, commande);
						quitter = true;
						break;
					case "3":
						Choix((short)DonneePublique.Categories.Burger, commande);
						Choix((short)DonneePublique.Categories.Boisson, commande);
						Choix((short)DonneePublique.Categories.Salade, commande);
						Choix((short)DonneePublique.Categories.Glace, commande);
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
		/// Choix du Menu Personnel. Préparateur caissier etc
		/// </summary>
		private static void MenuPersonnel()
		{

			int choix=0; bool valide = false;
			do
			{
				Console.WriteLine("Bienvenu dans le menu du personnel!");
				Console.WriteLine("1.Caissier/Manager");
				Console.WriteLine("2.Préparateur");
				valide=lireEntier(out choix);
			}
			while (!valide);
			switch (choix)
			{
				case 1:
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
			
					break;
				case 2:
					Preparateur.PreparationCommande(listeCommandes);
					break;
			 }

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
				if (commande.Paye)
				{
					Console.WriteLine("La commande est payée.");
					Console.ReadLine();
					choixDuMenu = "Q";
					quitter = true;
				}

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
						if (commande.ListeArticle.Length > 0)
						{
							SupprimerArticle(commande);
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
						choixDuMenu = "";
						if (commande.ListeArticle.Length > 0)
						{
							Paiement(commande);
						}
						break;
					default:
						Console.Clear();
						AfficherCommande(commande);
						Console.WriteLine("Bonjour et bienvenue dans VégétaFood !");
						Console.WriteLine("--- CHOIX DE VOTRE COMMANDE --- ");
						Console.WriteLine("1. Menu");
						Console.WriteLine("2. Article");
						if (commande.ListeArticle.Length > 0)
						{
							Console.WriteLine("3. Annuler un article");
						}
						Console.WriteLine("4. Annuler le menu");
						if (commande.ListeArticle.Length > 0)
						{
							Console.ForegroundColor = ConsoleColor.Green;
							Console.Write("5. Payer\n");
							Console.ResetColor();
						}
						Console.WriteLine("Q. Quitter");
						Console.WriteLine("\nSaisissez votre choix.");
						choixDuMenu = Console.ReadLine();
						break;
				}
			} while (!quitter);
		}

		/// <summary>
		/// Menu du choix de Paiement.
		/// </summary>
		/// <param name="commande">Conserve la commande en cours.</param>
		private static void Paiement(Commande commande)
		{
			string choixDuPaiement = "";
			bool quitter = false;

			if (commande.Paye)
			{
				Console.WriteLine("La commande est payée.");
				Console.ReadLine();
				choixDuPaiement = "Q";
				quitter = true;
			}

			do
			{
				switch (choixDuPaiement)
				{
					case "1":
						choixDuPaiement = "";
						Caissier.EncaisserCB(commande);
						quitter = true;
						break;
					case "2":
						choixDuPaiement = "";
						Caissier.EncaisserEspece(commande);
						quitter = true;
						break;
					case "3":
						choixDuPaiement = "";
						Caissier.EncaisserCheque(commande);
						quitter = true;
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
			}
			while (!quitter);

		}

		/// <summary>
		/// Affiche l'intégralité des articles de la commande en cours.
		/// </summary>
		/// <param name="commande">Conserve la commande en cours.</param>
		public static void AfficherCommande(Commande commande)
		{
			double Total = 0;
			Console.WriteLine("Commande {0}", commande.Numero);
			for (short i = 0; i < commande.ListeArticle.Length; i++)
			{
				Console.WriteLine("{0}. {1,12} * {2} Prix unit: {3} euros.", i + 1, commande.ListeArticle[i].Nom, commande.ListeArticle[i].Quantite, commande.ListeArticle[i].Prix);
				Total += commande.ListeArticle[i].Prix * commande.ListeArticle[i].Quantite;
			}
			Console.WriteLine("Total : {0} euros.", Total);
			Console.WriteLine("Commande payée: {0}", commande.Paye ? "OUI" : "NON");
			Console.WriteLine();
		}

		/// <summary>
		/// Choix de l'article et de la quantité à supprimer
		/// </summary>
		/// <param name="commande"></param>
		private static void SupprimerArticle(Commande commande)
		{
			int entreeUtilisateur = 0;
			int entreeQuantité;
			bool verifEntreeUtilisateur = false;
			
			Console.Clear();
			AfficherCommande(commande);
			if (commande.ListeArticle.Length > 1)
			{
				do
				{
					Console.WriteLine("Quel article souhaitez vous retirer ?");
					verifEntreeUtilisateur = lireEntier(out entreeUtilisateur);
				} while (!verifEntreeUtilisateur || (entreeUtilisateur < 1 || entreeUtilisateur > commande.ListeArticle.Length));
			}
			else if (commande.ListeArticle.Length == 1)
			{
				entreeUtilisateur = 1;
			}

			do
			{
				Console.WriteLine("Quel quantité de {0} souhaitez vous retirer ?", commande.ListeArticle[entreeUtilisateur - 1].Nom);
				verifEntreeUtilisateur = lireEntier(out entreeQuantité);
			} while (!verifEntreeUtilisateur || (entreeQuantité < 1 || entreeQuantité > commande.ListeArticle[entreeUtilisateur - 1].Quantite));

			commande.SupprimerArticle(entreeUtilisateur - 1, entreeQuantité);
		}

		/// <summary>
		/// Permet à l'utilisateur de choisir des articles un par un.
		/// </summary>
		/// <param name="commande">Conserve la commande en cours.</param>
		private static void ChoixArticle(Commande commande)
		{
			bool quitter = false;
			string choixTypeArticle = "";

			// Boucle forçant le client à choisir un menu valide.
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
						Console.WriteLine("Q. Quitter");
						Console.WriteLine("\nSaisissez votre choix.");
						choixTypeArticle = Console.ReadLine();
						break;
				}

			} while (!quitter);
		}
	}
}
