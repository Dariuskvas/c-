using System;

namespace pamoka_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----- 1 uzduotis -----------------

            Console.WriteLine("//1: Kokia tavo megstama spalva:?"); //1
            string spalva = Console.ReadLine();
            Console.WriteLine("//2: " + spalva + " Mano irgi");                    //2

            //----- 2 uzduotis -----------------

            int x = 17;
            int y = 23;
            int sum = x + y;
            Console.WriteLine("//3: " + sum);          //3

            //----- 3 uzduotis -----------------

            int a = 24;
            int b = 5;
            int sum2 = a / b;
            Console.WriteLine("//4: " + sum2);         //4

            //----- 4 uzduotis -----------------

            int count1 = -6 + 3 * 5;
            Console.WriteLine("//5: " + count1);        //5
            int count2 = (13 - 2) * 7;
            Console.WriteLine("//6: " + count2);           //6
            Console.WriteLine("//7: " + (5 + 2) + (20 / 10));       //7


            //----- 5 uzduotis -----------------

            Console.WriteLine("//8: Ivesk pirma skaiciu");      //8
            int pirmasSkaicius = int.Parse(Console.ReadLine());
            Console.WriteLine("//9: Ivesk antra skaiciu");     //9
            int antrasSkaicius = int.Parse(Console.ReadLine());

            Console.WriteLine("//10: Sandauga: " + (pirmasSkaicius * antrasSkaicius));      //10
            Console.WriteLine("//11: Dalyba: " + (pirmasSkaicius / antrasSkaicius));        //11
            Console.WriteLine("//12: Suma: " + (pirmasSkaicius + antrasSkaicius));          //12
            Console.WriteLine("//13: Skirtumas: " + (pirmasSkaicius - antrasSkaicius));     //13

            //----- 6 uzduotis -----------------


            Console.WriteLine("Ivesk sveika skaiciu");
            int i = 0;
            int skaiciusSandauga = int.Parse(Console.ReadLine());
            while (i <= 10)
            {
                i++;
                Console.WriteLine("//14: " + skaiciusSandauga + "*" + i + "=" + skaiciusSandauga * i);    //14
            }


            //----- 7 uzduotis -----------------

            i = 0;
            double suma3 = 0;
            while (i <= 3)
            {
                i++;
                Console.WriteLine("Ivest {0}/4 skaicius:", i);
                double ff = double.Parse(Console.ReadLine());                   //15
                suma3 += ff;
            }

            Console.WriteLine("Vidurkis: {0}", suma3 / 4);


            //----- 8 uzduotis -----------------

            i = 0;
            int[] myNum = new int[4];
            while (i <= 2)
            {
                Console.WriteLine("Ivest {0}/3 skaicius:", i);
                myNum[i] = int.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine("//16  (A+B)*C = {0}", (myNum[0] + myNum[1]) * myNum[2]);                            //16
            Console.WriteLine("//17  (A*C)+(B*C) = {0}", (myNum[0] + myNum[2]) + (myNum[2] + myNum[0]));        //17

            //----- 9 uzduotis -----------------

            i = 0;
            Console.WriteLine("//18 Ivest bet koki simboli:");                                                  //18
            string betkoks = Console.ReadLine();
            string betkoks1 = $"{betkoks}{betkoks}{betkoks}";
            string betkoks2 = $"{betkoks} {betkoks}";
            string betkoks3 = $"{betkoks} {betkoks}";
            string betkoks4 = $"{betkoks} {betkoks}";
            string betkoks5 = $"{betkoks}{betkoks}{betkoks}";

           /* for (i = 1; i < 5; i++)
            {*/
               Console.WriteLine(betkoks1);
               Console.WriteLine(betkoks2);
               Console.WriteLine(betkoks3);
               Console.WriteLine(betkoks4);
               Console.WriteLine(betkoks5);
            /*}*/

            //----- 10 uzduotis -----------------

            Console.ReadLine();

    }
}
}
