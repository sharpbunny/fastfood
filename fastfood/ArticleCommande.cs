using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fastfood
{
	/// <summary>
	/// Article d'une commande.
	/// </summary>
	public class ArticleCommande
	{
		private string _nom;
		private double _prix;
		private int _quantite;

		/// <summary>
		/// Nom de l'article d'une commande.
		/// </summary>
		public string Nom
		{
			get
			{
				return _nom;
			}

			set
			{
				_nom = value;
			}
		}

		/// <summary>
		/// Prix de l'article d'une commande
		/// </summary>
		public double Prix
		{
			get
			{
				return _prix;
			}

			set
			{
				_prix = value;
			}
		}

		/// <summary>
		/// Quantité d'article dans une commande.
		/// </summary>
		public int Quantite
		{
			get
			{
				return _quantite;
			}

			set
			{
				_quantite = value;
			}
		}

		/// <summary>
		/// Constructeur de ArticleCommande.
		/// </summary>
		public ArticleCommande()
		{

		}
		
		/// <summary>
		/// Constructeur de ArticleCommande.
		/// </summary>
		/// <param name="nom">Nom de l'article commandé</param>
		/// <param name="prix">Prix de l'article commandé</param>
		/// <param name="quantite">Quantité commandée</param>
		public ArticleCommande(string nom, double prix, int quantite)
		{
			Nom = nom;
			Prix = prix;
			Quantite = quantite;
		}

	}
}
