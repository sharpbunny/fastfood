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

		public Article[] ListeArticle = {};

		// Constructeurs
		/// <summary>
		/// Constructeur de la classe Commande. Le numéro de commande est incrémenté à chaque création de Commande.
		/// </summary>
		public Commande()
		{
			counter++;
		}

        // Getters - Stters
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

        // Méthodes

    }
}
