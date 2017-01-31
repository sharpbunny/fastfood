using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
	class Commande
	{
		/// <summary>
		/// Numéro de la commande
		/// </summary>
		static private int _numero { get; set; }

		/// <summary>
		/// Le type représente le choix du client de manger sur place ou à emporter
		/// </summary>
		private string _type { get; set; }

											// **********************************
											//			CONSTRUCTEURS
											// **********************************
	/// <summary>
	/// Constructeur de la classe Commande
	/// </summary>
		public Commande()
		{
			_numero++; //Le numéro de commande est incrémenté à chaque création de Commande
		}

											// **********************************
											//				METHODES
											// **********************************
		
	}
}
