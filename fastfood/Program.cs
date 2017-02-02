﻿using System;
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

        static void affichageMenuProg()
        {
            Console.WriteLine("Bonjour et bienvenue dans VégétaFood !");
            Console.WriteLine("Veuillez nous indiquer si vous êtes client ou si vous faites parti du personnel :");
			Console.WriteLine(" 1.Client");
			Console.WriteLine(" 2.Personnel");
			Console.WriteLine(" 3.Debug");

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
            // init database
            if (!File.Exists("BaseDuFastFood.sqlite"))
            {
                SQLiteConnection.CreateFile("BaseDuFastFood.sqlite");
                SQLiteConnection maConnexion = new SQLiteConnection("Data Source=BaseDuFastFood.sqlite;Version=3;");
                maConnexion.Open();
                string sql = "CREATE TABLE Article ('ID' INTEGER PRIMARY KEY AUTOINCREMENT, 'Nom' VARCHAR(30), 'Quantite' INT, 'Prix' DOUBLE)";
                SQLiteCommand commande = new SQLiteCommand(sql, maConnexion);
                commande.ExecuteNonQuery();
                sql = "INSERT INTO Article ('Nom', 'Quantite', 'Prix') VALUES ('Burger', 10, 10.5)";
                SQLiteCommand commande2 = new SQLiteCommand(sql, maConnexion);
                commande2.ExecuteNonQuery();
                maConnexion.Close();
            }


            
			affichageMenuProg();
        }

		static void debug()
		{
			Article article = new Article("Data Source=BaseDuFastFood.sqlite;Version=3;");
			// exemple pour afficher la liste d'articles
			Console.WriteLine("Affichage de la liste des articles");
			foreach (Article articlelist in article.GetArticles())
			{
				Console.WriteLine(articlelist.IDArticle + ": " + articlelist.Nom + " " + articlelist.Prix + " " + articlelist.Quantite);
			}

		}
	}
}