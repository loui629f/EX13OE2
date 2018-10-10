using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {

        private string title;

		public string Title {
			get
			{
				return title;
			}
			set
			{
				title = value;
			}
		}

		public Book(string title)
        {

            this.title = title;

        }

    }
}
