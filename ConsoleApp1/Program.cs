using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
		{
			Start();
			void Start ()
            {
                List<string> titles = new List<string>();
                titles.Add("Larman");
                titles.Add("Green");
                titles.Add("Larman2");

                for (int i = 0; i < titles.Count; i++)
                {
                    Book book = new Book(titles[i]);

                    Kontroller.AddBook(book);
                }
				int index = 0;
                Print(Kontroller.GetBook(index));

                
            }

            void Print (string str)
            {
                Console.WriteLine(str);
            }
        }
    }
}
