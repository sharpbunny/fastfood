using System;

namespace fastfood
{
    /// <summary>
	/// Classe permettant la gestion des commandes
	/// </summary>
	public class Commande
    {
        // Attributs

        /// <summary>
		/// Compteur d'objet commande, indique le nombre de commandes crées
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

        /// <summary>
		/// Tableau d'articles de la commande
		/// </summary>
		public Article[] ListeArticle = { };

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

        /// <summary>
		/// Numéro de commande
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
		/// Indique si la commande est payée
		/// </summary>
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

        /// <summary>
		/// 
		/// </summary>
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

        /// <summary>
		/// 
		/// </summary>
		/// <param name="menu"></param>
		/// <returns>retourne un tableau d'articles</returns>
		public Article[] attributionListMenu(Menu menu)
        {
            ListeArticle = menu.TabArticle;
            return ListeArticle;
        }

        /// <summary>
		/// Fonction qui permet d'annuler un article d'une commande
		/// </summary>
		/// <param name="commande"></param>
		/// <returns>retourne une liste d'articles</returns>
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

            Article[] tabArticle = new Article[ListeArticle.Length - 1];

            int j = 0;
            for (int i = 0; i < ListeArticle.Length; i++)
            {
                if (entreeUtilisateur - 1 != i)
                {
                    tabArticle[j] = ListeArticle[i];
                    j++;
                }
            }

            return tabArticle;
        }

    }
}
