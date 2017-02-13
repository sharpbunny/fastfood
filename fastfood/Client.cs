namespace fastfood
{
	class Client
	{
		// Attributs.
		/// <summary>
		/// Identifiant du client.
		/// </summary>
		private long _IDClient;

		// Constructeurs.
		/// <summary>
		/// Constructeur du client qui génère automatiquement son ID.
		/// </summary>
		public Client()
		{
			_IDClient++;
		}

		// Getters & Setters.
		/// <summary>
		/// Retourne l'id du client.
		/// </summary>
		public long IDClient
		{
			get { return _IDClient; }
		}

		// Fonctions.
		/// <summary>
		/// Lors du premier choix d'un article créer un tableau de choix puis ajoute les choix ultérieurs dans le tableau.
		/// </summary>
		/// <param name="tabArticle">Tableau d'objet Article.</param>
		/// <param name="newArticle">Le nouvel article sélectionné par le client.</param>
		/// <returns>Renvoie le tableau d'article complété.</returns>
		public static Article[] ChoixArticle(Article[] tabArticle, Article newArticle)
		{
			bool added = false, check = false;
			Article[] newTabArticle;
			int indice = 0;
			for (int i = 0; i < tabArticle.Length; i++)
			{
				if (tabArticle[i].Nom == newArticle.Nom)
				{
					check = true;
				}
			}

			if (check)
			{
				indice = tabArticle.Length;
			}
			else
			{
				indice = tabArticle.Length + newArticle.Quantite;
			}

			newTabArticle = new Article[indice];

			if (tabArticle.Length == 0)
				newTabArticle[0] = newArticle;
			else
			{
				for (int i = 0; i < tabArticle.Length; i++)
				{
					newTabArticle[i] = tabArticle[i];
					if (tabArticle[i].Nom == newArticle.Nom)
					{
						newTabArticle[i] = tabArticle[i];
						added = true;
					}
				}
				if (!added)
					newTabArticle[tabArticle.Length] = newArticle;
			}
			return newTabArticle;
		}

		/// <summary>
		/// Permet au client de payer sa commande.
		/// </summary>
		/// <param name="prixMenu">Récupère le prix du menu que le client a choisi.</param>
		/// <param name="prixPaye">Récupère la somme que le client a payé.</param>
		/// <param name="rendu">Si positif la somme à rendre au client, si négatif le client n'a pas donné assez d'argent.</param>
		/// <returns>Renvoie vrai si le paiement est valide. On peut donc passer à la préparation de la commande.</returns>
		public bool Payer(double prixMenu, double prixPaye, out double rendu)
		{
			bool paiementValide = false;
			rendu = 0;
			double diff = prixPaye - prixMenu;
			if (diff == 0) { paiementValide = true; }
			else if (diff < 0) { paiementValide = false; rendu = diff; }
			else if (diff > 0) { paiementValide = true; rendu = diff; }
			else { paiementValide = false; }
			return paiementValide;
		}
	}
}
