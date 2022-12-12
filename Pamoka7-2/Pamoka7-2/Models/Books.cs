using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka7_2.Models
{
    public struct Books
    {
        public string Title { get; set; }
        public int bookQnt { get; set; } 

        public Books()
        {
            Title= string.Empty;
            bookQnt= CreateRandomNum.GetRandomNumber(10);
        }
    }

}
