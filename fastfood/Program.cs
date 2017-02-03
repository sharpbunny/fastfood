using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace fastfood
{



    class Program
    {
        static int lireEntier()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

		/// <summary>
		/// Choix de l'utilisateur : fonction utile au développeur pour se mettre dans la position du client ou du personnel de Végétafood
		/// </summary>
        static void affichageMenuProg()
        {
            Console.WriteLine("Bonjour et bienvenue dans VégétaFood !");
            Console.WriteLine("Veuillez nous indiquer si vous êtes client ou si vous faites parti du personnel :");
			Console.WriteLine(" 1.Client");
			Console.WriteLine(" 2.Personnel");

            int nombre = lireEntier();
            switch (nombre)
            {
                case 1:
                    Console.WriteLine("Vous êtes authentifé en tant que client.");
                    break;
                case 2:
                    Console.WriteLine("Vous faites parti du personnel.\nVeuillez saisir le login : ");
                    if (Console.ReadLine() == "admin")
                    {
                        Console.WriteLine("Veuillez saisir le mot de passe : ");
                        if (Console.ReadLine() == "admin")
                        {
                            Console.WriteLine("Vous faites parti du personnel.");
                        }
                    }
                    break;
				case 3:
					debug();
					break;
                default:
                    Console.WriteLine("Erreur 404");
                    break;
            }

        }


        static void Main(string[] args)
        {

			//double ResultatMenu;
			

			foreach(Article articleList  in article.GetArticles())
			{
				Console.WriteLine(""+articleList.IDArticle+  "     "+articleList.Nom+ "     "+articleList.Prix+ " euros");
			}



			////Console.WriteLine(tab[1]);
			affichageMenuProg();


            Menu small = new Menu();
			ResultatMenu = small.CalculerPrixMenu(article.GetArticles());
			Console.WriteLine("Le prix du menu est de : "+ResultatMenu+" euros");

            double renduMonnay;
            Client gerard = new Client();
            gerard.Payer(ResultatMenu, 542, out renduMonnay);

            Console.WriteLine("Gérard Depardieu a payé "+542 +" euros. Il a payé "+ResultatMenu+" et on lui rends : "+renduMonnay+" euros");
        

			//Menu small = new Menu();
			//ResultatMenu = small.CalculerPrixMenu(article.GetArticles());
			//Console.WriteLine(ResultatMenu);

			
		}
    
            
	
       
		
	}
}