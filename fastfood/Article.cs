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
		/// Le nombre d'article.
		/// </summary>
		protected int _quantite;
		
		/// <summary>
		/// Le prix d'un article.
		/// </summary>
		protected double _prix;

		/// <summary>
		/// Le prix d'un article.
		/// </summary>
		protected double prixUnitaire;

		/// <summary>
		/// Le n° de la catégorie de l'article. Catégorie 1 : Burger, 2 : Boisson, 3 : Salade, 4 : Glace.
		/// </summary>
		protected short _categorie;

		// Constructeurs.
		/// <summary>
		/// Constructeur de l'article sous la norme NPC.
		/// </summary>
		/// <param name="nom">Nom de l'article.</param>
		/// <param name="prix">Prix unitaire de l'article.</param>
		/// <param name="categorie">Catégorie de l'article (1 : Burger, 2 : Boisson, 3 : Salade, 4 : Glace).</param>
		public Article(string nom, double prix, short categorie)
		{
			Nom = nom;
			PrixUnitaire = prix;
			Categorie = categorie;
		}

		// Getters & Setters
		/// <summary>
		/// Quantité d'article
		/// </summary>
		/// <return>un entier correspondant à la quantité</return> 
		public int Quantite
		{
			get
			{
				return _quantite;
			}

			set
			{
				_quantite = value;
				_prix = PrixUnitaire * Quantite;
			}
		}

		/// <summary>
		/// Nom de l'article
		/// </summary>
		/// <return>une chaine correspondant au nom</return> 
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
		/// Prix de l'article
		/// </summary>
		/// <return>un double indiquent le prix de l'article</return> 
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
		/// Catégorie de l'articlee. Catégorie 1 : Burger, 2 : Boisson, 3 : Salade, 4 : Glace.
		/// </summary>
		/// <return>un short correspondant à la catégorie</return> 
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
		/// Prix de l'article
		/// </summary>
		/// <return>un double correspondant au prix</return> 
		protected double PrixUnitaire
		{
			get
			{
				return prixUnitaire;
			}

			set
			{
				prixUnitaire = value;
			}
		}
	}
}
