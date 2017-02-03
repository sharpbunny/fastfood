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
		//static int lireEntier()
		//{
		//    return Convert.ToInt32(Console.ReadLine());
		//}


		//static void debug()
		//{
		//    Article article = new Article("Data Source=U:\\Partage\\BaseDuFastFood.sqlite;Version=3;");
		//    // exemple pour afficher la liste d'articles
		//    Console.WriteLine("Affichage de la liste des articles");
		//    foreach (Article articlelist in article.GetArticles())
		//    {
		//        Console.WriteLine(articlelist.IDArticle + ": " + articlelist.Nom + " " + articlelist.Prix + " " + articlelist.Quantite);
		//    }

		//}

		static void Main(string[] args)
		{
			//         // init database
			//         if (!File.Exists("U:\\Partage\\BaseDuFastFood.sqlite"))
			//         {
			//             SQLiteConnection.CreateFile("U:\\Partage\\BaseDuFastFood.sqlite");
			//             SQLiteConnection maConnexion = new SQLiteConnection("Data Source=BaseDuFastFood.sqlite;Version=3;");
			//             maConnexion.Open();
			//             string sql = "CREATE TABLE Article ('ID' INTEGER PRIMARY KEY AUTOINCREMENT, 'Nom' VARCHAR(30), 'Quantite' INT, 'Prix' DOUBLE)";
			//             SQLiteCommand commande = new SQLiteCommand(sql, maConnexion);
			//             commande.ExecuteNonQuery();
			//             sql = "INSERT INTO Article ('Nom', 'Quantite', 'Prix') VALUES ('Burger', 10, 10.5)";
			//             SQLiteCommand commande2 = new SQLiteCommand(sql, maConnexion);
			//             commande2.ExecuteNonQuery();
			//             maConnexion.Close();
			//         }

			//double ResultatMenu;

			//         Article article = new Article("Data Source=U:\\Partage\\BaseDuFastFood.sqlite;Version=3;");
			//         //article.getArticleByID(1);
			//         //Console.WriteLine(article.IDArticle);
			//         //Console.WriteLine(article.Nom);
			//         //Console.WriteLine(article.Prix);
			//         article.GetArticles();


			//foreach(Article articleList  in article.GetArticles())
			//{
			//	Console.WriteLine(""+articleList.IDArticle+  "     "+articleList.Nom+ "     "+articleList.Prix+ "");
			//}


			////Console.WriteLine(tab[1]);

			//Menu small = new Menu();
			//ResultatMenu = small.CalculerPrixMenu(article.GetArticles());
			//Console.WriteLine(ResultatMenu);

			Fonction.AffichageMenuProg();
		}
	}
}