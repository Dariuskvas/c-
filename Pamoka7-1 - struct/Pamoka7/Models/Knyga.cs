using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka7.Models
{
    public struct Knyga
    {
        public int ID { get; set; }
        public string BookTitle { get; set; }
        public string BookReaderName { get; set; }
        public DateTime TakeBookDate { get; set; }

        public Knyga()
        {
            ID = BookRespository.allBooks.Count+1;
            BookTitle = string.Empty;
            BookReaderName = string.Empty;
            TakeBookDate = Convert.ToDateTime("11/20/2022");
        }
    }
}