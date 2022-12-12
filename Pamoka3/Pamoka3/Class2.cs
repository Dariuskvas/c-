namespace Pamoka3
{
    internal class Class2
    {
        public void uzduotis1()
        {
            // -- 1 -----------------------------------------------------------
            // - Ivesti simboli ir gauk trikampi

            Console.WriteLine("Ivesti simboli ir gauk trikampi");
            String simbolis = Console.ReadLine();
            int[] skaiciai = { 1, 2, 3 };
            foreach (int skaicius in skaiciai)
            {
                for (Double i = skaicius - 1; i >= 0; i--)
                {
                    Console.Write(simbolis);
                }
                Console.WriteLine();
            }


            // -- 2 -----------------------------------------------------------
            // - Ivesti prisijungimus, neatspejus gauni error'a
            Console.WriteLine("Ivesti prisijungimus, neatspejus gauni error'a");
            int i2 = 0;
            do
            {
                Console.WriteLine("Ivesti Logina");
                String login = Console.ReadLine();
                Console.WriteLine("Ivesti Slaptazodi");
                String pasw = Console.ReadLine();
                i2++;

                if (login == "111" && pasw == "222")
                {
                    Console.WriteLine("PRISILOGINAI");
                    /*break*/;                                                              //Iseina is do while
                }
                else
                {
                    Console.WriteLine("blogi loginai: {0}", i2);
                    continue;                                                           //kartoja do while
                }
            } while (i2 <= 2);



            // -- 4 -----------------------------------------------------------
            // - Double konvertuoja i INT, SHORT, BYTE.

            Double pirminis = 1000000000;
            Console.WriteLine("Double: {0}", pirminis/3);
            Console.WriteLine("Int: {0}", (int)pirminis/3);
            Console.WriteLine("Short: {0}", (short)pirminis/3);
            Console.WriteLine("Byte: {0}", (byte)pirminis/3);




        }
    }
}
