using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
	class Commande
	{
		static private int _numero { get; set; }
		private string _type { get; set; }

											// **********************************
											//			CONSTRUCTEURS
											// **********************************

		public Commande()
		{
			_numero++; //Le numéro de commande est incrémenté à chaque création de Commande
		}

											// **********************************
											//				METHODES
											// **********************************
		
	}
}
