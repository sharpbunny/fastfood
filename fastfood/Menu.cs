//Version : 0.1
//Date de Création : 31/01/2017
//Créateur : DOMINGUES Chris
//Date de dernière modification : 31/01/2017

namespace fastfood
{
    /// <summary>
    /// Classe qui permet de gérer les menus, les prix et les quantités d'articles commandés.
    /// </summary>
    public class Menu
    {
        // Attributs.
        private Article[] _tabArticle;
        private int typeMenu;

        // Constructeurs.
		/// <summary>
		/// Constructeur de la classe menu.
		/// </summary>
        public Menu()
        {

        }

        // Accesseurs.
        /// <summary>
		/// Tableau d'articles qui composent un menu.
		/// </summary>
		public Article[] TabArticle
        {
            get
			{
				return _tabArticle;
			}
            set
			{
				_tabArticle = value; }
        }

        /// <summary>
		/// Type de menu.
		/// </summary>
		public int TypeMenu
        {
            get
			{
				return typeMenu;
			}
            set
			{
				typeMenu = value;
			}
        }

        // Methodes.
        
    }
}
