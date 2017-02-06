﻿namespace fastfood
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
		/// Constructeur du client qui genère automatiquement son ID.
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
		/// <param name="newArticle">Le nouvel article selectionné par le client.</param>
		/// <param name="nombreArticle">Le nombre d'acticle choisi par le cient.</param>
		/// <returns>Renvoie le tableau d'article complété.</returns>
		public Article[] ChoixArticle(Article[] tabArticle, Article newArticle, short nombreArticle = 1)
		{
			Article[] newTabArticle = new Article[tabArticle.Length + nombreArticle];
			if (tabArticle.Length == 0)
				for (int i = 0; i < nombreArticle; i++)
					newTabArticle[i] = newArticle;
			else
			{
				for (int i = 0; i < tabArticle.Length; i++)
					newTabArticle[i] = tabArticle[i];
				for (int i = tabArticle.Length; i < nombreArticle; i++)
					newTabArticle[i] = newArticle;
			}
			return newTabArticle;
		}

		/// <summary>
		/// Permet au client de payer sa commande.
		/// </summary>
		/// <param name="prixMenu">Récupère le prix du menu que le client a choisi.</param>
		/// <param name="prixPaye">Récupère la somme que le clien a payé.</param>
		/// <param name="rendu">Si positif la somme à rendre au client, si négatif le client n'a pas donné assez d'argent.</param>
		/// <returns>Renvoie true si le paiement est valide. On peut donc passer à la préparation de la commande.</returns>
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
