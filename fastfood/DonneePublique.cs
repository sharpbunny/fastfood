using System.Collections.Generic;

namespace fastfood
{
	/// <summary>
	/// Classe permettant d'avoir une liste d'articles sans utiliser de bdd.
	/// </summary>
	static class DonneePublique
	{
		// Attributs.
		/// Catégorie 1 : Burger, 2 : Boisson, 3 : Salade, 4 : Glace.
		public enum Categories { Burger = 1, Boisson, Salade, Glace }

		/// new Article(NOM, PRIX, CATEGORIE) => NPC.
		public static Article Coca = new Article("Coca", 2.10, 2);
		public static Article Soja = new Article("Soja", 6.50, 1);
		public static Article Tofu = new Article("Tofu", 6.50, 1);
		public static Article Fanta = new Article("Fanta", 2.20, 2);
		public static Article Cevenole = new Article("Cévenole", 9.50, 3);
		public static Article Seitan = new Article("Seitan", 7.20, 1);
		public static Article Sprite = new Article("Sprite", 2.30, 2);
		public static Article SevenUp = new Article("SevenUp", 2.10, 2);
		public static Article Chocolat = new Article("Chocolat", 3.50, 4);
		public static Article Vanille = new Article("Vanille", 3.50, 4);
		public static Article Fraise = new Article("Fraise", 3.50, 4);
		public static Article SaladeVerte = new Article("SaladeVerte", 4.20, 3);
		public static Article Oceane = new Article("Océane", 4.20, 3);
		public static Article Caesar = new Article("Caesar", 4.20, 3);
		public static Article Pistache = new Article("Pistache", 4.15, 4);

		/// <summary>
		/// Tableau répertoriant tous les articles disponibles.
		/// </summary>
		public static Article[] ListeArticle = { Coca, Soja, Tofu, Fanta, Seitan, Sprite, SevenUp, Chocolat, Vanille, Fraise, SaladeVerte, Oceane, Caesar, Cevenole, Pistache };

		/// <summary>
		/// Tri Alphabétique d'un tableau.
		/// </summary>
		/// <param name="tableauATrier">Le tableau à trier.</param>
		/// <returns>Renvoie le tableau trié.</returns>
		public static Article[] TriAlphabetique(Article[] tableauATrier)
		{
			bool switched = true;
			while (switched)
			{
				switched = false;

				for (int i = 0; i < tableauATrier.Length - 1; i++)
				{
					if (tableauATrier[i].Nom[0] > tableauATrier[i + 1].Nom[0])
						switched = _triBulleArticle(tableauATrier, i, switched);

					else if ((tableauATrier[i].Nom[0] == tableauATrier[i + 1].Nom[0]) && (tableauATrier[i].Nom[1] > tableauATrier[i + 1].Nom[1]))
						switched = _triBulleArticle(tableauATrier, i, switched);

					else if ((tableauATrier[i].Nom[0] == tableauATrier[i + 1].Nom[0]) && (tableauATrier[i].Nom[1] == tableauATrier[i + 1].Nom[1]) && (tableauATrier[i].Nom[2] > tableauATrier[i + 1].Nom[2]))
						switched = _triBulleArticle(tableauATrier, i, switched);
				}
			}
			return tableauATrier;
		}

		/// <summary>
		/// Renvoie une liste d'article triée appartenant à une catégorie.
		/// </summary>
		/// <param name="categorie">Catégorie de l'article.</param>
		public static List<Article> ListeArticleParCategorie(short categorie)
		{
			List<Article> listeArticles = new List<Article>();
			foreach (Article article in DonneePublique.ListeArticle)
			{
				if (article.Categorie == categorie)
				{
					listeArticles.Add(article);
				}
			}
			return listeArticles;
		}

		/// <summary>
		/// Dry du Tri Alphabétique.
		/// </summary>
		/// <param name="tableauATrier">Le tableauATrier.</param>
		/// <param name="i">l'indice du tableau en cours.</param>
		/// <param name="switched">Booléen indiquant si on a effectué une permutation.</param>
		/// <returns>Retourne le booléen de pérmutation.</returns>
		private static bool _triBulleArticle(Article[] tableauATrier, int i, bool switched)
		{
			Article temporaryArticle = tableauATrier[0];
			temporaryArticle = tableauATrier[i + 1];
			tableauATrier[i + 1] = tableauATrier[i];
			tableauATrier[i] = temporaryArticle;
			return switched = true;
		}
	}
}
