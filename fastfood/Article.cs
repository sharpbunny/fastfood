namespace fastfood
{
	class Article //: Database<Article>
	{
		// Attributs.
		/// <summary>
		/// ID de l'article.
		/// </summary>
		protected long _IDArticle;
		
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
			Prix = prix;
			Categorie = categorie;
		}

		// Getters & Setters
		public long IDArticle
		{
			get
			{
				return _IDArticle;
			}
			set
			{
				_IDArticle = value;
			}
		}

		public int Quantite
		{
			get
			{
				return _quantite;
			}

			set
			{
				_quantite = value;
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

    //// Constructeurrs
    //public Article(string connectionString) //: base(connectionString)
    //{

		//protected enum MyEnum
		//{
		//	Boisson,
		//	Burger,
		//	Glace,
		//	Salade,
		//	Sauce
		//}

		/// SQL
		///// <summary>
		///// récupère un article avec son ID
		///// </summary>
		///// <param name="idArticle"></param>
		///// <returns></returns>
		//public Article getArticleByID(long idArticle)
		//{
		//	var sql = string.Format("SELECT * FROM Article WHERE ID={0}", idArticle);

		//          return GetUniqueItem(sql, MapArticle);
		//      }

		///// <summary>
		///// recupère la liste des articles qui contient Nom
		///// </summary>
		///// <param name="Nom"></param>
		///// <returns></returns>
		//public Article getArticleByName(string Nom)
		//      {
		//          var sql = string.Format("SELECT * FROM Article WHERE Nom LIKE '%{0}%'", Nom);

		//          return GetUniqueItem(sql, MapArticle);
		//      }

		///// <summary>
		///// recupère la liste des articles
		///// </summary>
		///// <returns></returns>
		//public IEnumerable<Article> GetArticles()
		//      {
		//          string sql = "SELECT * FROM Article";

		//          return GetItems(sql, MapArticle);
		//      }

		///// <summary>
		///// ajoute un article
		///// </summary>
		///// <param name="article"></param>
		///// <returns></returns>
		//public bool AddArticle(Article article)
		//      {
		//          var sql = string.Format("INSERT INTO Article (Nom, Prix) VALUES ('{0}', '{1}')", article.Nom, article.Prix);

		//          return ExecuteNonQuery(sql) == 1;
		//      }

		///// <summary>
		///// supprime un article
		///// </summary>
		///// <param name="idArticle"></param>
		///// <returns></returns>
		//public bool DeleteArticle(long idArticle)
		//      {
		//          var sql = string.Format("DELETE FROM Article WHERE ID = {0}", idArticle);

		//          return ExecuteNonQuery(sql) == 1;
		//      }

		///// <summary>
		///// effectue le mappage entre les champs de la bdd et les attributs
		///// </summary>
		///// <param name="reader"></param>
		///// <returns></returns>
		//private Article MapArticle(SQLiteDataReader reader)
		//      {
		//	//Console.WriteLine((long)reader["ID"]);
		//	//Console.WriteLine(reader["Nom"].ToString());
		//	//Console.WriteLine((int)reader["Quantite"]);
		//	//Console.WriteLine((double)reader["Prix"]);
		//	return new Article(ConnectionString)
		//	{
		//		IDArticle = (long)reader["ID"],
		//		Nom = reader["Nom"].ToString(),
		//		Quantite = (int)reader["Quantite"],
		//		Prix = (double)reader["Prix"],
		//	};
		//      }
	}
}
