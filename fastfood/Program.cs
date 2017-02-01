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
		static void Main(string[] args)
		{
            // init database
            if (!File.Exists("BaseDuFastFood.sqlite"))
            {
                SQLiteConnection.CreateFile("BaseDuFastFood.sqlite");
                SQLiteConnection maConnexion;
                maConnexion = new SQLiteConnection("Data Source=BaseDuFastFood.sqlite;Version=3;");
                maConnexion.Open();
                string sql = "CREATE TABLE Article ('ID' INTEGER PRIMARY KEY AUTOINCREMENT, 'Nom' VARCHAR(30), 'Quantite' INT, 'Prix' DOUBLE)";
                SQLiteCommand commande = new SQLiteCommand(sql, maConnexion);
                commande.ExecuteNonQuery();
                sql = "INSERT INTO Article ('Nom', 'Quantite', 'Prix') VALUES ('Burger', 10, 10.5)";
                SQLiteCommand commande2 = new SQLiteCommand(sql, maConnexion);
                commande2.ExecuteNonQuery();
            }
        
                
            Article article = new Article ("Data Source=BaseDuFastFood.sqlite;Version=3;");
            article.getArticleByID(1);
			Console.WriteLine(article.IDArticle);
			Console.WriteLine(article.Nom);
            Console.WriteLine(article.Prix);
		}
	}
}
