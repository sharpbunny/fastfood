using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
	class Program
	{
		static void Main(string[] args)
		{
			Client test = new Client();
			Article[] tabArticle = new Article[0];
			Article patate = new Article(1, "patate", 1);
			test.ChoixArticle(tabArticle, patate, 3);
		}
	}
}
