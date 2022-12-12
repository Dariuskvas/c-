using Pamoka7_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka7_4
{
    public class RotateString
    {
        public string rotateWord { get; set; }
        public void rotatestring() 
        {
            foreach(string word in StringArray.array1)
            {
                rotateWord = word[1..] + word[0];
                Console.WriteLine(rotateWord);
            }
        }

    }
}
