namespace fastfood
{
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
		private double prixUnitaire;

		/// <summary>
		/// Le n° de la catégorie de l'article. Catégorie 1 : Burger, 2 : Boisson, 3 : Salade, 4 : Glace.
		/// </summary>
		private short _categorie;

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
