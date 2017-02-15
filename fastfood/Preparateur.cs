using System;
using System.Collections.Generic;

namespace fastfood
{
	class Preparateur : Personnel
	{
		// Attribut.
		static public List<ArticleCommande> Prepacommande = new List<ArticleCommande>();
		static private Article[] PreparateurTab = { };
		static private int  _saveQuantité;
		static private int _debut;
		static private int _fin;

		private string _nomarticle;

		/// <summary>
		/// Le nombre d'article.
		/// </summary>
		private int _quantite;

		private short _categorie;

		/// <summary>
		/// Le prix d'un article.
		/// </summary>
		private double _prix;

		/// <summary>
		/// Le prix d'un article.
		/// </summary>
		private double _prixUnitaire;

		/// <summary>
		/// Le n° de la catégorie de l'article. Catégorie 1 : Burger, 2 : Boisson, 3 : Salade, 4 : Glace.
		/// </summary>
		

		// Constructeur.
		public Preparateur(string name,int qte, short cate)
		{
			this._nomarticle = name;
			this._quantite = qte;
			this._categorie = cate;

		}

		// Accesseur et Mutateur.
		protected string Nomarticle
		{
			get
			{
				return _nomarticle;
			}

			set
			{
				_nomarticle = value;
			}
		}
		
		protected int Quantite
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

		protected short Categorie
		{
			get
			{
				return _categorie;
			}

			set
			{
				_categorie = value;
			}
		}

		protected double Prix
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

		protected double PrixUnitaire
		{
			get
			{
				return _prixUnitaire;
			}

			set
			{
				_prixUnitaire = value;
			}
		}
	
		
		// Methode.

		static public Preparateur [] PreparationCommande(ArticleCommande[] Prepacommande) 
		{
			int compter = 0, j = 0, k = 0, x=0;
			int CapacityTotal=0;
			for (int i = 0; i < Prepacommande.Length; i++)
			{									
				compter++;				
			}
			Console.WriteLine("Commande:" + Prepacommande.Length);
			Console.WriteLine(" Prepacommande.Length:" + Prepacommande.Length);
			Console.WriteLine("compter:" + compter);
			
				Preparateur[] PreparateurTab = new Preparateur[Prepacommande.Length];				
				//Article SaveQuantite = new Article(Quantite);
				Console.WriteLine("┌─────┬────────┐");
				Console.WriteLine("│ Qté │ Article│");
				Console.WriteLine("├─────┼────────┤");
				while (k < Prepacommande.Length)
				{
					foreach (ArticleCommande item in Prepacommande)
					{
					
						//Preparateur CloneArticle = new Preparateur(item.Nom, item.Quantite, item.Categorie);
					Preparateur CloneArticle = new Preparateur(item.Nom, item.Quantite, 1);
					if (k % 2 != 0 && x < compter)
						{
							PreparateurTab[x] = CloneArticle;
							Console.ForegroundColor = ConsoleColor.Cyan;
							Console.WriteLine("| " + PreparateurTab[x].Quantite + "  |  " + PreparateurTab[x].Nomarticle);
							//Console.WriteLine("| " + item.Quantite + "  |  " + item.Nom);
							Console.ResetColor();
							x++;
						}
						else if (k % 2 == 0 && x < compter)
						{
							PreparateurTab[x] = CloneArticle;
							Console.ForegroundColor = ConsoleColor.Magenta;
							Console.WriteLine("| " + PreparateurTab[x].Quantite + "  |  " + PreparateurTab[x].Nomarticle);
							//Console.WriteLine("| " + item.Quantite + "  |  " + item.Nom);
							Console.ResetColor();
							x++;
						}
					}
					k++;
				}
			Console.WriteLine("└─────┴────────┘");
			Console.ReadLine();
		
			return PreparateurTab;
		}


	}
}
