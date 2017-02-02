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
            menu.TypeMenu = Console.Read();
            Console.WriteLine("Quel Menu voulez vous choisir : ");
            do {
                Console.WriteLine("1.Petit\n2.Moyen\n3.Grand");
                menu.TypeMenu = Console.Read();
            } while(menu.TypeMenu <1 || menu.TypeMenu >3 );
            switch (menu.TypeMenu)
            {
                case 1:

                    menu.TabArticle = new Article[2];
                    menu.TabArticle[0] = choixBurger();
                    menu.TabArticle[1] = choixBoisson();
                    break;
                case 2:
                    menu.TabArticle = new Article[3];
                    menu.TabArticle[0] = choixBurger();
                    menu.TabArticle[1] = choixBoisson();
                    menu.TabArticle[2] = choixSalade();
                    
                    break;
                case 3:
                    menu.TabArticle = new Article[4];
                    menu.TabArticle[0] = choixBurger();
                    menu.TabArticle[1] = choixBoisson();
                    menu.TabArticle[2] = choixSalade();
                    menu.TabArticle[3] = choixGlace();
                    break;
            }
            return menu;
        }
    }
}
