﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
	class Commande
	{
											// **********************************
											//			ATTRIBUTS
											// **********************************
		/// <summary>
		/// Numéro de la commande
		/// </summary>
		private int _numero;

		/// <summary>
		/// Le type représente le choix du client de manger sur place ou à emporter
		/// </summary>
		private string _type;

											// **********************************
											//			CONSTRUCTEURS
											// **********************************
	/// <summary>
	/// Constructeur de la classe Commande
	/// </summary>
		public Commande()
		{
			Numero++; //Le numéro de commande est incrémenté à chaque création de Commande
		}


											// **********************************
											//			GETTERS - SETTERS
											// **********************************
		/// <summary>
		/// Permet de lire ou de définir le type de la commande
		/// </summary>
		public int Numero
		{
			get
			{
				return _numero;
			}

			set
			{
				_numero = value;
			}
		}

		/// <summary>
		/// Permet de lire ou de définir le type de la commande : sur place ou à emporter
		/// </summary>
		/// 
		public string Type
		{
			get
			{
				return _type;
			}

			set
			{
				_type = value;
			}
		}

		// **********************************
		//				METHODES
		// **********************************

	}
}
