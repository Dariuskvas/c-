using Pamoka7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka7
{
    public class createBookLibrary
    {
        public void reateBooksLibrary(string title, string name)
        {

            Knyga knyga = new Knyga();
            knyga.BookTitle = title;
            knyga.BookReaderName = name;

            BookRespository.allBooks.Add(knyga);

            Console.WriteLine("");
        }
    }
}
