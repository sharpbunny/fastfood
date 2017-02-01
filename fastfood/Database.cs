using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace fastfood
{
    public abstract class Database<T>
    {
        public string ConnectionString { get; set; }

        public Database(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        
        ///<summary>
		/// execute une requète qui renvoie une seule donnée ex: select * from table where id=xx
		///</summary>
        protected T GetUniqueItem(string sql, Func<SQLiteDataReader, T> mappingMethod)
        {
            var connection = new SQLiteConnection(this.ConnectionString);
            connection.Open();

            try
            {
                var command = new SQLiteCommand(sql, connection);

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return mappingMethod(reader);
                }
            }
            finally
            {
                connection.Close();
            }

            return default(T);
        }

		///<summary>
		/// execute une requète qui renvoie des données ex: select * from table
		///</summary>
		protected IEnumerable<T> GetItems(string sql, Func<SQLiteDataReader, T> mappingMethod)
        {
            var connection = new SQLiteConnection(this.ConnectionString);
            connection.Open();

            try
            {
                var command = new SQLiteCommand(sql, connection);

                var reader = command.ExecuteReader();

                var result = new List<T>();

                while (reader.Read())
                {
                    result.Add(mappingMethod(reader));
                }

                return result;
            }
            finally
            {
                connection.Close();
            }
        }

		///<summary>
		/// execute une requète qui ne renvoie pas de données ex insert create delete
		///</summary>
		protected int ExecuteNonQuery(string sql)
        {
            SQLiteConnection connection = new SQLiteConnection(this.ConnectionString);
            connection.Open();
            try
            {
                var command = new SQLiteCommand(sql, connection);

                return command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
