using Pamoka6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka6
{
    public class Calculations
    {
        //sukuriam kintamuosius

        public float earthArea { get; set; }
        public float totalArea { get; set; }

        // pasileidzia kalkuliatorius ir pasiima is Earth reiksmes
        // kalkuliatorius paleidzia metodus 

        public Calculations(Earth earth)
        {
            calcEarthArea(earth.radius, earth.age) ;            //metodas paleidziamas ir jam paduodama reiksme
            calcEarthVolume(earth.radius);

        }

        private void calcEarthArea(float radius, float age)        //metodas pasiima reiksmes
        {
           
            earthArea= radius*5;
            Console.WriteLine(age);
            Console.WriteLine(earthArea);
        }

        private void calcEarthVolume(float radius)         //metodas pasiima reiksmes
        {
            
            totalArea= radius*2;
            Console.WriteLine(totalArea);
        }

    }
}
 