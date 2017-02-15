using System;

namespace fastfood
{
	/// <summary>
	/// Classe permettant la gestion des commandes.
	/// </summary>
	public class Commande
	{
		// Attributs
		/// <summary>
		/// Compteur d'objet commande, indique le nombre de commandes crées.
		/// </summary>
		public static int counter = 0;

		/// <summary>
		/// Le type représente le choix du client de manger sur place ou à emporter.
		/// </summary>
		private string _type;

		/// <summary>
		/// Numéro de commande.
		/// </summary>
		private int _numero;

		/// <summary>
		/// Total de la commande.
		/// </summary>
		private double _total;


		/// <summary>
		/// Commande payée.
		/// </summary>
		private bool _paye = false;

		private Menu _menu;

		private ArticleCommande[] _listeArticle;

		/// <summary>
		/// Tableau d'articles de la commande
		/// </summary>
		public ArticleCommande[] ListeArticle
		{
			get
			{
				return _listeArticle;
			}
			set
			{
				_listeArticle = value;
			}
		}

		// Constructeurs
		/// <summary>
		/// Constructeur de la classe Commande. Le numéro de commande est incrémenté à chaque création de Commande.
		/// </summary>
		public Commande()
		{
			counter++;
			ListeArticle = new ArticleCommande[] { };
		}

		// Getters - Setters
		/// <summary>
		/// Permet de lire ou de définir le type de la commande : sur place ou à emporter.
		/// </summary>
		public string Type
		{
			get
			{
				return _type;
			}
			set
			{
				_type = value;
			}
		}

		/// <summary>
		/// Numéro de commande.
		/// </summary>
		public int Numero
		{
			get
			{
				return _numero;
			}

			set
			{
				_numero = value;
			}
		}

		/// <summary>
		/// Indique si la commande est payée.
		/// </summary>
		public bool Paye
		{
			get
			{
				return _paye;
			}

			set
			{
				_paye = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public Menu Menu
		{
			get
			{
				return _menu;
			}

			set
			{
				_menu = value;
			}
		}

		/// <summary>
		/// Total de la commande.
		/// </summary>
		public double Total
		{
			get
			{
				return _total;
			}

			set
			{
				_total = value;
			}
		}

		// Méthodes
		/// <summary>
		/// 
		/// </summary>
		/// <param name="menu"></param>
		/// <returns>retourne un tableau d'articles</returns>
		//public ArticleCommande[] attributionListMenu(Menu menu)
		//{
		//	ListeArticle = menu.TabArticle;
		//	return ListeArticle;
		//}

		/// <summary>
		/// Méthode pour ajouter un article à la commande
		/// </summary>
		/// <param name="article">L'article dans le tableau à ajouter</param>
		/// <param name="quantité">La quantité</param>
		public ArticleCommande [] AjouterArticle(Article article, int quantité)
		{
			bool found = false;
			for (int i=0; i<ListeArticle.Length; i++)
			{
				if (ListeArticle[i].Nom == article.Nom)
				{
					// La ligne existe, on modifie la quantité
					ListeArticle[i].Quantite += quantité;
					found = true;
				}
			}
			if (! found)
			{
				int i;
				// on crée un tableau temporaire plus grand pour ajouter la ligne de commande
				ArticleCommande[] tempTab = new ArticleCommande[ListeArticle.Length+1];
				for (i = 0; i < ListeArticle.Length; i++)
				{
					tempTab[i] = ListeArticle[i];
				}
				// on crée la nouvelle ligne de commande
				tempTab[i] = new ArticleCommande(article.Nom, article.Prix, quantité);
				// on remplace la liste d'articles commandés par la nouvelle
				ListeArticle = tempTab;
			}
			return  ListeArticle;
		}

		/// <summary>
		/// Méthode pour retirer un article de la commande
		/// </summary>
		/// <param name="idarticle">L'id de l'article dans le tableau à retirer</param>
		/// <param name="quantité">La quantité</param>
		public void SupprimerArticle(int idarticle, int quantité)
		{
			ListeArticle[idarticle].Quantite -= quantité;
			if (ListeArticle[idarticle].Quantite ==0)
			{
				ArticleCommande[] tempTab = new ArticleCommande[ListeArticle.Length - 1];
				for (int i = 0; i < idarticle; i++)
				{
					tempTab[i] = ListeArticle[i];
				}
				for (int i=idarticle; i<ListeArticle.Length-1; i++)
				{
					tempTab[i] = ListeArticle[i + 1];
				}
				ListeArticle = tempTab;
			}
		}

		/// <summary>
		/// Permet de calculer la commande totale.
		/// </summary>
		public void CalculerTotalCommande()
		{
			Total = 0;
			for (short i = 0; i < ListeArticle.Length; i++)
			{
				Total += ListeArticle[i].Prix * ListeArticle[i].Quantite;
			}
		}
	}

}
