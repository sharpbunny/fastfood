namespace fastfood
{
	/// <summary>
	/// Classe de Gestion des Articles.
	/// </summary>
	public class Article
	{
		// Attributs.
		/// <summary>
		/// Nom de l'article.
		/// </summary>
		protected string _nom;

		/// <summary>
		/// Le prix d'un article.
		/// </summary>
		protected double _prix;

		/// <summary>
		/// Le n° de la catégorie de l'article. Catégorie 1 : Burger, 2 : Boisson, 3 : Salade, 4 : Glace.
		/// </summary>
		protected short _categorie;
		
		/// <summary>
		/// Quantité en stock de l'article.
		/// </summary>
		private int _stock;

		// Constructeurs.
		/// <summary>
		/// Constructeur de l'article sous la norme NPC.
		/// </summary>
		/// <param name="nom">Nom de l'article.</param>
		/// <param name="prix">Prix unitaire de l'article.</param>
		/// <param name="categorie">Catégorie de l'article (1 : Burger, 2 : Boisson, 3 : Salade, 4 : Glace).</param>
		/// <param name="stock">Quantité en stock</param>
		public Article(string nom, double prix, short categorie, int stock)
		{
			Nom = nom;
			Prix = prix;
			Categorie = categorie;
			Stock = stock;
		}

		// Getters & Setters

		/// <summary>
		/// Nom de l'article.
		/// </summary>
		/// <return>une chaîne correspondant au nom.</return> 
		public string Nom
		{
			get
			{
				return _nom;
			}
			set
			{
				_nom = value;
			}
		}

		/// <summary>
		/// Prix de l'article.
		/// </summary>
		/// <return>un double indiquent le prix de l'article.</return> 
		public double Prix
		{
			get
			{
				return _prix;
			}
			set
			{
				_prix = value;
			}
		}

		/// <summary>
		/// Catégorie de l’article. 1 : Burger, 2 : Boisson, 3 : Salade, 4 : Glace.
		/// </summary>
		/// <return>Short correspondant à la catégorie.</return> 
		public short Categorie
		{
			get
			{
				return _categorie;
			}

			set
			{
				_categorie = value;
			}
		}

		/// <summary>
		/// Quantité en stock de l'article.
		/// </summary>
		/// <return>Une valeur entière</return>
		protected int Stock
		{
			get
			{
				return _stock;
			}

			set
			{
				_stock = value;
			}
		}
	}
}
