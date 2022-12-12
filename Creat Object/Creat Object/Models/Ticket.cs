using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creat_Object.Models
{
    public class Ticket
    {
        public bool Sold { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Place { get; set; }
        public int id { get; set; }

        public Ticket()
        {
            Sold = false;
            Title = "";
            Price = 0;
            Place = "1A";
            id = CreateRandomNum.GetRandomNumber(99);
        }

    }
}
