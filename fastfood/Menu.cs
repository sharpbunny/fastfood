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
        private Article[] _composant;
        private string _taille;

        // Constructeurs
        public Menu()
        {

        }

        // Accesseurs
        public string Taille
        {
            get
            {
                return _taille;
            }

            set
            {
                _taille = value;
            }
        }

        public Article[] Composant
        {
            get
            {
                return _composant;
            }

            set
            {
                _composant = value;
            }
        }
        
        // Methodes
        /// <summary>
        /// Somme du prix du menu en fonction d'un ou plusieurs articles.
        /// </summary>
        /// <param name="tableauArticle">Tableau d'Article(s).</param>
        /// <returns></returns>
        public double CalculerPrixMenu(Article[] tableauArticle)
        {
            double somme = 0;
            for(int i = 0; i < tableauArticle.Length; i++)
            {
                somme = somme + tableauArticle[i].Prix;
            }

            return somme;
        }
    }
}
