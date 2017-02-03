using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
	static class DonneePublique
	{
		// Attributs.
		// Catégorie 1 : Burger, 2 : Boisson, 3 : Salade, 4 : Glace.
		public static Article Coca = new Article("Coca", 2, 2);
		public static Article Soja = new Article("Soja", 6.50, 1);
		public static Article Tofu = new Article("Tofu", 6.50, 1);
		public static Article Fanta = new Article("Fanta", 2, 2);
		public static Article Seitan = new Article("Seitan",7,1);
		public static Article Sprite = new Article("Sprite", 2, 2);
		public static Article Chocolat = new Article("Chocolat", 3.50, 4);
		public static Article Vanille = new Article("Vanille", 3.50, 4);
		public static Article Fraise = new Article("Fraise", 3.50, 4);
		public static Article SaladeVerte = new Article("SaladeVerte", 4.20, 3);
		public static Article Oceane = new Article("Oceane", 4.20, 3);
		public static Article Caesar = new Article("Caesar", 4.20, 3);

		/// Tableau d'article
		public static Article[] ListeArticle = { Coca, Soja, Tofu, Fanta, Seitan, Sprite, Chocolat, Vanille, Fraise, SaladeVerte, Oceane, Caesar };

		// Fonctions.

		/// tri par catégorie.
		public static Article[] TriCategorie(Article[] tableauATrier)
		 {
			Article[] nouveauTableau = new Article[tableauATrier.Length];

			int indiceNouveauTableau = 0;
			for (int j = 1; j <= 4; j++)
			{
				for (int i = 0; i < tableauATrier.Length; i++)
				{

					if (j == 1 && tableauATrier[i].Categorie == 1)
					{
						nouveauTableau[indiceNouveauTableau] = tableauATrier[i];
						indiceNouveauTableau++;
					}
					else if (j == 2 && tableauATrier[i].Categorie == 2)
					{
						nouveauTableau[indiceNouveauTableau] = tableauATrier[i];
						indiceNouveauTableau++;
					}
					else if (j == 3 && tableauATrier[i].Categorie == 3)
					{
						nouveauTableau[indiceNouveauTableau] = tableauATrier[i];
						indiceNouveauTableau++;
					}
					else if (j == 4 && tableauATrier[i].Categorie == 4)
					{
						nouveauTableau[indiceNouveauTableau] = tableauATrier[i];
						indiceNouveauTableau++;
					}
				}
			}
			return nouveauTableau;
		}

		/// Tri alphabétique
		public static Article[] TriAlphabetique(Article[] tableauATrier)
		{
			Article[] nouveauTableau = new Article[tableauATrier.Length];

			int indiceNouveauTableau = 0;
			for (int j = 0; j <= 1; j++)
			{
				for (int i = 0; i < tableauATrier.Length; i++)
				{
					
				}
			}
			return nouveauTableau;
		}

		/// tri par prix

	}
}
