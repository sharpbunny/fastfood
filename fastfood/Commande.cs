﻿using System;

namespace fastfood
{
	public class Commande
	{
        // Attributs
				
        /// <summary>
		/// </summary>
		public static int counter = 0;
		
		/// <summary>
        /// Le type représente le choix du client de manger sur place ou à emporter.
        /// </summary>
        private string _type;
        
        /// <summary>
        /// Numéro de commande.
        /// </summary>
        private int _numero;
        
        /// <summary>
        /// Commande payée.
        /// </summary>
        private bool _paye = false;
		
        private Menu _menu;

		public Article[] ListeArticle = {};

		// Constructeurs
		/// <summary>
		/// Constructeur de la classe Commande. Le numéro de commande est incrémenté à chaque création de Commande.
		/// </summary>
		public Commande()
		{
			counter++;
		}

        // Getters - Setters
		/// <summary>
		/// Permet de lire ou de définir le type de la commande : sur place ou à emporter.
		/// </summary>
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

        public bool Paye
        {
            get
            {
                return _paye;
            }

            set
            {
                _paye = value;
            }
        }

        public Menu Menu
        {
            get
            {
                return _menu;
            }

            set
            {
                _menu = value;
            }
        }

        // Méthodes

        public Article[] attributionListMenu(Menu menu)
        {
            ListeArticle = menu.TabArticle;
            return ListeArticle;
        }

        public Article[] annulerArticle(Commande commande)
        {
            int entreeUtilisateur;
            bool verifEntreeUtilisateur = false;
            do
            {
                Console.WriteLine("Quel article souhaitez vous retirer ?");
                Fonction.AfficherCommande(commande);
                verifEntreeUtilisateur = Fonction.lireEntier(out entreeUtilisateur);
            } while (!verifEntreeUtilisateur || (entreeUtilisateur < 1 || entreeUtilisateur > ListeArticle.Length));

            Article[] tabArticle = new Article[ListeArticle.Length-1];

            bool trouve = false;
            int i = 0;
            while (!trouve)
            {
                if (entreeUtilisateur-1 != i)
                {
                    tabArticle[i] = ListeArticle[i];
                    trouve = true;
                }
                i++;
            }

            return tabArticle;
            
        }

    }
}
