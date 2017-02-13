using System;
using System.Collections.Generic;
namespace fastfood
{
	class Preparateur:Personnel
	{
		// Attribut.
		static public List<Commande> Prepacommande = new List<Commande>();
		static private Article[] PrepaTabArticle = { };

		// Constructeur.
		public Preparateur()
		{

		}

		// Accesseur et Mutateur.

		// Methode.
		
		static public Article [] PreparationCommande(List<Commande> Prepacommande)
		{
			int compter=0, j = 0;
			//int fonctionverif = premierAppel(compter);		
			//int firstcall = 0;
			for (int i = 0; i < Prepacommande.Count; i++)
			{				
				while(j < Prepacommande[i].ListeArticle.Length)
				{				
					if (Prepacommande[i].ListeArticle[j].Quantite > 1)
					{
						compter = compter + Prepacommande[i].ListeArticle[j].Quantite;
					}
					else
					{
						compter++;
					}
					j++;
				}
				
			}
			
			PrepaTabArticle = new Article[compter];
			Console.WriteLine("Count" + Prepacommande.Count);//Compte la longueur de la list Prepacommande
			Console.WriteLine("Capacity" + Prepacommande.Capacity);//Compte le nombre de champ de l'objet dans 1 élement de la list
			Console.WriteLine("compter:"+compter);
			//Console.WriteLine(Prepacommande[0].ListeArticle[1]);

			//for (int j = 0; j < Prepacommande.Count; j++)//Positionne l'indice de la List[0] à [etc]
			//{
			//	for (int k = 0; k < Prepacommande.Capacity/2; k++)
			//	{
			//		PrepaTabArticle[k] = Prepacommande[j].ListeArticle[k];
			//	}
			//}

			for (int i = 0; i < PrepaTabArticle.Length; i++)
			{
				Console.WriteLine("Nom:" + PrepaTabArticle[i].Nom);
				Console.WriteLine("Catégorie:" + PrepaTabArticle[i].Categorie);
				Console.WriteLine("Quantité:" + PrepaTabArticle[i].Quantite);
				Console.WriteLine("Prix:" + PrepaTabArticle[i].Prix);
			}
			Console.ReadLine();
			return PrepaTabArticle;

		}
	}
}
