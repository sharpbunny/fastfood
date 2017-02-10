namespace fastfood
{
	/// <summary>
	/// Classe permettant d'avoir une liste d'articles sans utiliser de bdd
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
		/// Indice du tableau DonneePublique.ListeArticle où commence la catégorie Burger qui se termine en DonneePublique.DebutBoisson.
		/// </summary>
		public static int debutBurger;
	
		/// <summary>
		/// Indice du tableau DonneePublique.ListeArticle où commence la catégorie Boisson qui se termine en DonneePublique.DebutSalade.
		/// </summary>
		public static int debutBoisson;
	
		/// <summary>
		/// Indice du tableau DonneePublique.ListeArticle où commence la catégorie Salade qui se termine en DonneePublique.DebutGlace.
		/// </summary>
		public static int debutSalade;
	
		/// <summary>
		/// Indice du tableau DonneePublique.ListeArticle où commence la catégorie Glace qui se termine en DonneePublique.ListeArticle.Length.
		/// </summary>
		public static int debutGlace;

		/// <summary>
		/// Tableau répertoriant tous les articles disponibles.
		/// </summary>
		public static Article[] ListeArticle = { Coca, Soja, Tofu, Fanta, Seitan, Sprite, SevenUp, Chocolat, Vanille, Fraise, SaladeVerte, Oceane, Caesar, Cevenole, Pistache };

		// Fonctions.
		/// <summary>
		/// Tri par catégorie.
		/// </summary>
		/// <param name="tableauATrier">Le tableau à trier.</param>
		/// <param name="debutBurger">Stockera l'indice du début du tableau de la catégorie Burger.</param>
		/// <param name="debutBoisson">Stockera l'indice du début du tableau de la catégorie Boisson.</param>
		/// <param name="debutSalade">Stockera l'indice du début du tableau de la catégorie Salade.</param>
		/// <param name="debutGlace">Stockera l'indice du début du tableau de la catégorie Glace.</param>
		/// <returns>Renvoie le tableau trié.</returns>
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

		/// <summary>
		/// Tri Alphabétique.
		/// </summary>
		/// <param name="tableauATrier">Le tableau à trier.</param>
		/// <returns>Renvoie le tableau trié.</returns>
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
