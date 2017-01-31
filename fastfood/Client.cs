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
		private int _IDClient;

		// Constructeurs.

		// Getters & Setters.
		public int IDClient
		{
			get	{ return _IDClient; }
		}

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

		public bool Payer()
		{
			bool paiementValide = false;
			return paiementValide;
		}
	}
}
