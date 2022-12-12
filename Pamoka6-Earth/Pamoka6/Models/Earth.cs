using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka6.Models
{
    public class Earth
    {
        // sukuriu kintamuosius apie Earth

        public float radius { get; set; }
        public float age { get; set; }


        // konstruktorius pasiima is Program.cs reiksmes ir jas perduoda i kintamuosius
        public Earth(float Radius, float Age)  
        {
            radius = Radius;
            age = Age;
        }
    } 
}
