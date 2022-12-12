using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka3
{
    public class Class1
    {
        public void uzduotis1()
        {
            // ------------------------- 1 ---------------------------------------------
            // - Ivesti tris skaicius ir atsapausdinti atvirksciai
            Console.WriteLine("Ivesti tris skaicius ir atsapausdinti atvirksciai");
            int i = 0;
            String stringas1 = Console.ReadLine();
            char[] separatoriai = { ' ', ',' };
            String[] strlist = stringas1.Split(separatoriai);

            Console.WriteLine(strlist[2] + strlist[1] + strlist[0]);            //pirmas budas

            for (i = 2; i >= 0; i--)                                            // antras budas
            {
                Console.Write(strlist[i]);
            }
            Console.WriteLine();


            // ------------------------- 2 ---------------------------------------------
            // - Ivesk atstuma metrais ir laika sekundėmis, atsakymas greitis
            Console.WriteLine("Ivesk atstuma metrais ir laika sekundėmis, atsakymas greitis");

            Console.WriteLine("Ivesk greiti, m");
            Double greitis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ivesk laika,s");
            Double laikas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tavo kosminis greitis, km/h: " + (greitis / 1000) / (laikas / 3600));



            // ------------------------- 3 ---------------------------------------------
            // - Ivesk rutolio diametra. Gauk plota pi*r^2 ir diametra 2*pi*r
            Console.WriteLine("Ivesk rutolio diametra ir gauk plota bei diametra");
            Double diametras = Convert.ToDouble(Console.ReadLine());
            Double pi = Math.PI;
            Console.WriteLine("Plotas: " + (diametras / 2) * (diametras / 2) * pi);
            Console.WriteLine("Apskritimo ilgis: " + diametras * pi);


            // ------------------------- 4 ---------------------------------------------
            // - Ivesk 2 skaicius ir palyginti
            Console.WriteLine("Ivesti pirma skaiciu");
            Double pirmas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ivesti antra skaiciu");
            Double antras = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(pirmas == antras);

        }
    }
}
