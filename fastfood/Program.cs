using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
	/// <summary>
	/// Programme principal.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			DonneePublique.ListeArticle = DonneePublique.TriAlphabetique(DonneePublique.ListeArticle);

			Fonction.AffichageMenuProg();
		}
	}
}
