//Version : 0.1
//Date de Création : 31/01/2017
//Créateur : DOMINGUES Chris
//Date de dernière modification : 31/01/2017

namespace fastfood
{
    /// <summary>
    /// Classe qui permet de gérer les menus, les prix et les quantités d'articles commandés.
    /// </summary>
    class Menu
    {
        // Attributs.
        private Article[] _tabArticle;
        private int typeMenu;

        // Constructeurs.
        public Menu()
        {

        }

        // Accesseurs.
        public Article[] TabArticle
        {
            get { return _tabArticle; }
            set { _tabArticle = value; }
        }

        public int TypeMenu
        {
            get { return typeMenu; }
            set { typeMenu = value; }
        }

        // Methodes.
        
    }
}
