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
		private long _IDClient;

		// Constructeurs.

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
			{
				for (int i = 0; i < nombreArticle; i++)
				{
					newTabArticle[i] = newArticle;
				}
			}
			else
			{
				for (int i = 0; i < tabArticle.Length; i++)
				{
					newTabArticle[i] = tabArticle[i];
				}
				for (int i = tabArticle.Length; i < nombreArticle; i++)
				{
					newTabArticle[i] = newArticle;
				}
			}
			return newTabArticle;
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
