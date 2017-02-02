using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
	static class DonneePublique
	{
		// Attributs. 12 articles
		public static Article Coca = new Article(nom, categorie, prix);


		/// Tableau d'article
		public static Article[] ListeArticle = { Coca };

		// Fonctions.

		/// tri par catégorie.
		public static Article[] TriCategorie(Article[] tableauATrier)
		{
			Article[] nouveauTableau = new Article[tableauATrier.Length];

			int indiceNouveauTableau = 0;
			for (int j = 1; j < 4; j++)
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


		/// tri par prix

	}
}
