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
		public static Article Seitan = new Article("Seitan", 7, 1);
		public static Article Sprite = new Article("Sprite", 2, 2);
		public static Article Chocolat = new Article("Chocolat", 3.50, 4);
		public static Article Vanille = new Article("Vanille", 3.50, 4);
		public static Article Fraise = new Article("Fraise", 3.50, 4);
		public static Article SaladeVerte = new Article("SaladeVerte", 4.20, 3);
		public static Article Oceane = new Article("Oceane", 4.20, 3);
		public static Article Caesar = new Article("Caesar", 4.20, 3);
		public static int debutBurger;
		public static int debutBoisson;
		public static int debutSalade;
		public static int debutGlace;

		/// Tableau d'article
		public static Article[] ListeArticle = { Coca, Soja, Tofu, Fanta, Seitan, Sprite, Chocolat, Vanille, Fraise, SaladeVerte, Oceane, Caesar };

		// Fonctions.
		/// Tri par catégorie.
		public static Article[] TriCategorie(Article[] tableauATrier, out int debutBurger, out int debutBoisson, out int debutSalade, out int debutGlace)
		{
			Article[] nouveauTableau = new Article[tableauATrier.Length];

			int indiceNouveauTableau = 0;
			debutBurger = -1; debutBoisson = -1; debutSalade = -1; debutGlace = -1;
			for (int j = 1; j <= 4; j++)
				for (int i = 0; i < tableauATrier.Length; i++)
				{

					if (j == 1 && tableauATrier[i].Categorie == 1)
					{
						nouveauTableau[indiceNouveauTableau] = tableauATrier[i];
						if (debutBurger == -1)
							debutBurger = indiceNouveauTableau;
						indiceNouveauTableau++;
					}
					else if (j == 2 && tableauATrier[i].Categorie == 2)
					{
						nouveauTableau[indiceNouveauTableau] = tableauATrier[i];
						if (debutBoisson == -1)
							debutBoisson = indiceNouveauTableau;
						indiceNouveauTableau++;
					}
					else if (j == 3 && tableauATrier[i].Categorie == 3)
					{
						nouveauTableau[indiceNouveauTableau] = tableauATrier[i];
						if (debutSalade == -1)
							debutSalade = indiceNouveauTableau;
						indiceNouveauTableau++;
					}
					else if (j == 4 && tableauATrier[i].Categorie == 4)
					{
						nouveauTableau[indiceNouveauTableau] = tableauATrier[i];
						if (debutGlace == -1)
							debutGlace = indiceNouveauTableau;
						indiceNouveauTableau++;
					}
				}
			return nouveauTableau;
		}

		/// Tri alphabétique
		public static Article[] TriAlphabetique(Article[] tableauATrier)
		{
			Article temporaryArticle = tableauATrier[0];
			bool switched = true;
			while (switched)
			{
				switched = false;

				for (int i = 0; i < tableauATrier.Length - 1; i++)
				{
					if (tableauATrier[i].Nom[0] > tableauATrier[i + 1].Nom[0])
					{
						temporaryArticle = tableauATrier[i + 1];
						tableauATrier[i + 1] = tableauATrier[i];
						tableauATrier[i] = temporaryArticle;
						switched = true;
					}
					else if (tableauATrier[i].Nom[0] == tableauATrier[i + 1].Nom[0])
					{
						if (tableauATrier[i].Nom[1] > tableauATrier[i + 1].Nom[1])
						{
							temporaryArticle = tableauATrier[i + 1];
							tableauATrier[i + 1] = tableauATrier[i];
							tableauATrier[i] = temporaryArticle;
							switched = true;
						}
					}
					else if ((tableauATrier[i].Nom[0] == tableauATrier[i + 1].Nom[0]) && (tableauATrier[i].Nom[1] == tableauATrier[i + 1].Nom[1]))
					{
						if (tableauATrier[i].Nom[2] > tableauATrier[i + 1].Nom[2])
						{
							temporaryArticle = tableauATrier[i + 1];
							tableauATrier[i + 1] = tableauATrier[i];
							tableauATrier[i] = temporaryArticle;
							switched = true;
						}
					}
				}
			}
			return tableauATrier;
		}
	}
}
