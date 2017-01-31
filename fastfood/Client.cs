using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
	class Client
	{
		// Attributs.
		/// <summary>
		/// Identifiant du client.
		/// </summary>
		private int _IDClient;

		// Constructeurs.

		// Getters & Setters.
		/// <summary>
		/// Retourne l'id du client.
		/// </summary>
		public int IDClient
		{
			get	{ return _IDClient; }
		}

		/// <summary>
		/// Lors du premier choix d'un article créer un tableau de choix puis ajoute les choix ultérieurs dans le tableau.
		/// </summary>
		/// <param name="tabArticle">Tableau d'objet Article.</param>
		/// <param name="newArticle">Le nouvel aticle selectionné par le client.</param>
		/// <returns>Renvoie le tableau d'article complété.</returns>
		// Fonctions.
		public Article[] ChoixArticle(Article[]tabArticle, Article newArticle)
		{
			if (tabArticle.Length == 0)
				tabArticle[0] = newArticle;
			else
			{
				tabArticle[tabArticle.Length] = newArticle;
			}
			return tabArticle;
		}

		/// <summary>
		/// Permet au client de payer sa commande.
		/// </summary>
		/// <returns>Renvoie true si le paiement est valide. On peut donc passer à la préparation de la commande.</returns>
		public bool Payer()
		{
			bool paiementValide = false;
			return paiementValide;
		}
	}
}
