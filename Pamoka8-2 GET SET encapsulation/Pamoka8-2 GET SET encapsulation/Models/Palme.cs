using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka8_2_GET_SET_encapsulation.Models
{
    public class Palme
    {
        public int age { get; private set; }                //private is mazosios raides pavadinimas

        public int fruitQNT { get; private set; }           

        public int FruitQNT                                 //public is didziosios raides
        { 
            get { return fruitQNT; }                        //return - Grazinu Privat reiksme per Public elementa
            set                                             // uzsetinu privat reiksme per public kintamaji
            {
                if (age <5) { fruitQNT = 0; }
               else { fruitQNT = value; }
            }
        }

        public Palme(int y) {                               // reiksmes priskiru public kintamajam
            age= y;
            FruitQNT = age * 3;
        }
    }

}
