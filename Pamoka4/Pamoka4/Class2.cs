namespace Pamoka4
{
    internal class Class2
    {
        public void uzduotis2()

            // Spausdina trikampi

        {

            Console.WriteLine("Ivesk eiluciu kieki ir gauk piramide");
            int linQnt = Convert.ToInt32(Console.ReadLine());
            string value = "* ";
            int naujastarpas = 1;

            for (int i = 1; i <= linQnt; i++)
            {
                for (int tarpas = naujastarpas; tarpas <= linQnt - 1; tarpas++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(value);
                value += "* ";
                naujastarpas++;
            }
        }
    }
}
