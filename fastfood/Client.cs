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
		private int IDClient;

		// Constructeurs.

		// Getters & Setters.
		public int IDClient1
		{
			get	{ return IDClient; }
		}

		// Fonctions.
		public Article[] ChoixArticle()
		{
			Article[] tabArticle;
			return tabArticle;
		}

		public bool Payer()
		{
			bool paiementValide = false;
			return paiementValide;
		}
	}
}
