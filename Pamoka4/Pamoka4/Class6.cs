using System.Collections;
using System.Collections.Generic;

namespace Pamoka4
{
    internal class Class6
    {
        public void uzduotis6()
        {
            List<int> listasFirst = new List<int>();
            List<int> listasSecond = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                int numberRandom = rnd.Next(5);
                listasFirst.Add(numberRandom);
            }

            for (int i = 0; i < 20; i++)
            {
                int numberRandom = rnd.Next(5);
                listasSecond.Add(numberRandom);
            }

            List<int> listasTotal = new List<int>();

            listasTotal.AddRange(listasFirst);
            listasTotal.AddRange(listasSecond);

            Console.WriteLine("First size: {0}", listasFirst.Count);
            Console.WriteLine("Second size: {0}", listasSecond.Count);
            Console.WriteLine("Total size: {0}", listasTotal.Count);

            listasTotal.Sort();
            Console.WriteLine("Po Sort pirmas listo skaicius: {0}", listasTotal[0]);

            listasTotal.Reverse();
            Console.WriteLine("Po Reverse pirmas listo skaicius: {0}", listasTotal[0]);

            foreach (int x in listasTotal) { Console.Write("{0}, ", x); };
            Console.WriteLine();

            // tikrina liste besikartojancius simbolius ir isveda i Dictionary kiek kartu
            var query = listasTotal.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => new { Element = y.Key, Counter = y.Count() })
            .ToList();
            
            // atspausdina Dictionary
            for(int i = 0; i <= query.Count-1; i++)
            {
                Console.WriteLine(query[i]);
            }


            // sukuriu nuja lista kuriame istrinu besikartojancius irasus
            List<int> myNoneDuplicateValue = listasTotal.Distinct().ToList();

            //Pasiimu antra pagal dydi reikšmę
            int maxValueSecond = myNoneDuplicateValue.OrderByDescending(z => z).Skip(1).First();   
            Console.WriteLine("Max second: {0}",maxValueSecond);





        }

    }
}
