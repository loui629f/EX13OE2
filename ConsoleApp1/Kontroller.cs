using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Kontroller
    {

        static private List <Book> books = new List <Book>();

        public static void AddBook(Book book)
        {
            books.Add(book);

        }

        public static string GetBook(int i)
        {
			return books[i].Title;

        }
    }
}
