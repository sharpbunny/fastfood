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
    class Menu
    {
        //Attributs
        private Article[] _composant;
        private string _taille;

        //Constructeurs
        public Menu()
        {

        }
        
        //Accesseurs
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

        //Methodes
        public double CalculerPrixMenu()
        {
            int somme = 0;
            for(int i = 0; i < Composant.Length; i++)
            {
                somme = somme + Composant[i].Prix;
            }

            return somme;
        }
    }
}
