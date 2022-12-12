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
        internal int i = 0;

        public void rotateString()
        {
            foreach (string word in StringArray.arrayIn)
            {
                var rotateWord = word.Substring(1, word.Length - 1) + word.Substring(0, 1);
                StringArray.arrayRotateOut[i] = rotateWord;
                i++;
            }
        }
    }
}
