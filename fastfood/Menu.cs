using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Version : 0.1
//Date de Création : 31/01/2017
//Créateur : DOMINGUES Chris
//Date de dernière modification : 31/01/2017


namespace fastfood
{
    /// <summary>
    /// Classe qui permet de gérer les menus, les prix et les quantités d'articles commandés
    /// </summary>
    class Menu
    {
        // Attributs
        private Article[] _tabArticle;
        private int typeMenu;

        // Constructeurs
        public Menu()
        {

        }

        // Accesseurs
        
        public Article[] TabArticle
        {
            get
            {
                return _tabArticle;
            }

            set
            {
                _tabArticle = value;
            }
        }

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

        // Methodes
        /// <summary>
        /// Somme du prix du menu en fonction d'un ou plusieurs articles.
        /// </summary>
        /// <param name="tableauArticle">Tableau d'Article(s).</param>
        /// <returns></returns>
        
    }
}
