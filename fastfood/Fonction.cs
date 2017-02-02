using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
	/// <summary>
	/// Classe contenant toutes les fonctions utiles au fonctionnement de VégétaFood
	/// </summary>
	abstract class Fonction
	{
        public Menu ChoixTypeMenu()
        {
            Menu menu = new Menu();
            Console.WriteLine("Quel Menu voulez vous choisir : ");
            Console.WriteLine("1.Petit\n2.Moyen\n3.Grand");
            typeMenu = Console.Read();
            switch (typeMenu)
            {
                case 1:
                    choixBurger();

                    choixBoisson();
                    break;
                case 2:
                    choixBurger();
                    choixBoisson();
                    choixSalade();
                    break;
                case 3:
                    choixBurger();
                    choixBoisson();
                    choixSalade();
                    choixGlace();
                    break;
            }
            return menu;
        }
    }
}
