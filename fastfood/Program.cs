using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{

    
   
	class Program
	{
        static int lireEntier()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void affichageMenuProg()
        {
            Console.WriteLine("Bonjour et bienvenue dans VégétaFood !");
            Console.WriteLine("Veuillez nous indiquer si vous êtes client ou si vous faites parti du personnel :");
            Console.Write("1.Client\n2.Personnel\n");
           
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
                default:
                    Console.WriteLine("Erreur 404");
                    break;
            }

        }
        
        static void Main(string[] args)
		{
            affichageMenuProg();
		}
	}
}
