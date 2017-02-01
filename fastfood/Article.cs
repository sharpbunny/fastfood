using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace fastfood
{
	class Article : Database<Article>
	{
		// Attributs.
		protected int _IDArticle;
		protected string _nom;
		private int quantite;
		protected float _prix;

        // Getters & Setters
        public int IDArticle
		{
			get { return _IDArticle; }
			set { _IDArticle = value; }
		}
	
		public string Nom
		{
			get { return _nom; }
			set{ _nom = value; }
		}

		public float Prix
		{
			get { return _prix; }
			set{ _prix = value; }
		}

		protected int Quantite
		{
			get
			{
				return quantite;
			}

			set
			{
				quantite = value;
			}
		}

		protected enum MyEnum
		{
			Boisson,
			Burger,
			Glace,
			Salade,
			Sauce
		}

        // Constructeurrs
        public Article(string connectionString) : base(connectionString)
        {

        }

        // récupère un article avec son ID
        public Article getArticleByID(int idArticle)
		{
			var sql = string.Format("SELECT * FROM Article WHERE ID={0}", idArticle);

            return GetUniqueItem(sql, this.MapArticle);
        }
        
        // recupère la liste des articles qui contient Nom
        public Article getArticleByName(string Nom)
        {
            var sql = string.Format("SELECT * FROM Article WHERE Nom LIKE '%{0}%'", Nom);

            return GetUniqueItem(sql, this.MapArticle);
        }
        
        // recupère la liste des articles
        public IEnumerable<Article> GetArticles()
        {
            string sql = "SELECT * FROM Article";

            return (IEnumerable<Article>)GetItems(sql, this.MapArticle);
        }
        
        // ajoute un article
        public bool AddArticle(Article article)
        {
            var sql = string.Format("INSERT INTO Article (Nom, Prix) VALUES ('{0}', '{1}')", article.Nom, article.Prix);

            return ExecuteNonQuery(sql) == 1;
        }

        // supprime un article
        public bool DeleteArticle(int idArticle)
        {
            var sql = string.Format("DELETE FROM Article WHERE ID = {0}", idArticle);

            return ExecuteNonQuery(sql) == 1;
        }

        // effectue le mappage entre les champs de la bdd et les attributs
        private Article MapArticle(SQLiteDataReader reader)
        {
			return new Article(ConnectionString)
			{
				IDArticle = (int)reader["ID"],
				Nom = reader["Nom"].ToString(),
				Quantite = (int)reader["Quantite"],
                Prix = (float)reader["Prix"],
            };
        }
    }
	

}
