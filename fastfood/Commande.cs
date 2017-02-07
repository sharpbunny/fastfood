﻿namespace fastfood
{
	class Commande
	{
		// Attributs

        /// <summary>
		/// Numéro de la commande.
		/// </summary>
		private int _numero;

		/// <summary>
		/// Le type représente le choix du client de manger sur place ou à emporter.
		/// </summary>
		private string _type;

		// Constructeurs

		/// <summary>
		/// Constructeur de la classe Commande. Le numéro de commande est incrémenté à chaque création de Commande.
		/// </summary>
		public Commande()
		{
			Numero++;
		}


		// Getters - Stters

        /// <summary>
		/// Permet de lire ou de définir le type de la commande.
		/// </summary>
		public int Numero
		{
			get { return _numero; }
			set	{ _numero = value; }
		}

		/// <summary>
		/// Permet de lire ou de définir le type de la commande : sur place ou à emporter.
		/// </summary>
		public string Type
		{
			get { return _type;	}
			set	{ _type = value; }
		}

		// Méthodes

	}
}
