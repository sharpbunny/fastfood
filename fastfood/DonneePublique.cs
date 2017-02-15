using System;
using System.Collections.Generic;

namespace fastfood
{
	/// <summary>
	/// Classe permettant d'avoir une liste d'articles sans utiliser de bdd.
	/// </summary>
	static class DonneePublique
	{
		// Attributs.
		/// <summary>
		/// Burger : 1,
		/// Boisson : 2,
		/// Salade : 3,
		/// Glace : 4.
		/// </summary>
		public enum Categories { Burger = 1, Boisson, Salade, Glace }

		/// new Article(NOM, PRIX, CATEGORIE) => NPC.
		public static Article Coca = new Article("Coca", 2.10, 2, 10);
		public static Article Soja = new Article("Soja", 6.50, 1, 10);
		public static Article Tofu = new Article("Tofu", 6.50, 1, 10);
		public static Article Fanta = new Article("Fanta", 2.20, 2, 10);
		public static Article Cevenole = new Article("Cévenole", 9.50, 3, 10);
		public static Article Seitan = new Article("Seitan", 7.20, 1, 10);
		public static Article Sprite = new Article("Sprite", 2.30, 2, 10);
		public static Article SevenUp = new Article("SevenUp", 2.10, 2, 10);
		public static Article Chocolat = new Article("Chocolat", 3.50, 4, 10);
		public static Article Vanille = new Article("Vanille", 3.50, 4, 10);
		public static Article Fraise = new Article("Fraise", 3.50, 4, 10);
		public static Article SaladeVerte = new Article("Salade Verte", 4.20, 3, 10);
		public static Article Oceane = new Article("Océane", 4.20, 3, 10);
		public static Article Caesar = new Article("Caesar", 4.20, 3, 10);
		public static Article Pistache = new Article("Pistache", 4.15, 4, 10);
		public static Article Citron = new Article("Citron", 4.10, 4, 10);
		public static Article Tomate = new Article("Tomate", 3.30, 2, 10);

		/// <summary>
		/// Tableau répertoriant tous les articles disponibles.
		/// </summary>
		public static Article[] ListeArticle = { Coca, Soja, Tofu, Fanta, Seitan, Sprite, SevenUp, Chocolat, Vanille, Fraise,
												 SaladeVerte, Oceane, Caesar, Cevenole, Pistache, Citron, Tomate };

		/// <summary>
		/// Tri Alphabétique d'un tableau.
		/// </summary>
		/// <param name="tableauATrier">Le tableau à trier.</param>
		/// <returns>Renvoie le tableau trié.</returns>
		public static void TriAlphabetique(Article[] tableauATrier)
		{
			for (int i = 0; i < tableauATrier.Length - 1; i++)
			{
				for (int j=i; j< tableauATrier.Length; j++)
				{
					if (String.Compare(tableauATrier[i].Nom, tableauATrier[j].Nom) > 0)
					{
						PermuteArticle(tableauATrier, i, j);
					}
				}
			}
		}

		/// <summary>
		/// Renvoie une liste d'article triée appartenant à une catégorie.
		/// </summary>
		/// <param name="categorie">Catégorie de l'article.</param>
		public static List<Article> ListeArticleParCategorie(short categorie)
		{
			List<Article> listeArticles = new List<Article>();
			foreach (Article article in ListeArticle)
			{
				if (article.Categorie == categorie)
				{
					listeArticles.Add(article);
				}
			}
			return listeArticles;
		}

		/// <summary>
		/// Permutation de deux éléments du tableau.
		/// </summary>
		/// <param name="tableauATrier">Le tableauATrier.</param>
		/// <param name="i">le premier élément du tableau en cours.</param>
		/// <param name="j">le deuxième élément</param>
		private static void PermuteArticle(Article[] tableauATrier, int i, int j)
		{
			Article temporaryArticle = tableauATrier[j];
			tableauATrier[j] = tableauATrier[i];
			tableauATrier[i] = temporaryArticle;
		}
	}
}
