namespace Pamoka4
{
    internal class Class1
    {

        public void uzduotis1()


            // Ivedi skaiciu ir suskaiciuoja visu skaiciu iki jo suma, bei parodo progresa

        {
            Console.WriteLine("Ivesk skaiciu. Sumuos nuo 1 iki ivesto skaiciaus");
            int i = 1;
            int suma = 0;
            string listOfProgress = "#";
            Double bigNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            do
            {
                suma += i;
                int procentas = (int)(100 * i / bigNumber);

                Console.Write("\r{0}%", procentas);                 // " \r " perraso aktyve eilute                                                 

                if (procentas >= listOfProgress.Length)
                {
                    do
                    {
                        listOfProgress += "#";
                    } while (procentas >= listOfProgress.Length);
                    Console.WriteLine();
                    Console.WriteLine(listOfProgress);
                    Console.SetCursorPosition(0, Console.CursorTop - 2);                    //grazina kursioriu dviem eilutemis i virsu nuo esamos pozicijos
                }
                i++;
            } while (bigNumber >= i);
            Console.SetCursorPosition(0, Console.CursorTop - -2);           //nukelia kursioriu dviem eilutemis i apcia nuo esamos pozicijos (nes reiksme -2)
            Console.WriteLine();
            Console.WriteLine("Suma: {0}", suma);
        }
    }
}
