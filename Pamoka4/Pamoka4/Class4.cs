namespace Pamoka4
{
    internal class Class4
    {
        public void uzduotis4()


            // ivedu du skaicius, veiksma (dalyba sudetis ir pan), gaunu atsakyma, ciklas sukasi iki kol pasirenku baigti

        {
            List<int> inputNumberList = new List<int>();

            do
            {
                do
                {
                    Console.WriteLine("Ivesk skaiciu");
                    String input = Console.ReadLine();

                    if (int.TryParse(input, out int numValue))
                    {
                        inputNumberList.Add(numValue);
                    }
                    else
                    {
                        Console.WriteLine("Ivestas blogas simbolis, iveskite skaičių");
                    }

                } while (inputNumberList.Count <= 1);

                // -----------------------------------------------------------------------------------------------

                Console.WriteLine("Ivesk matematini veiksma");
                String inputOperator = Console.ReadLine();

                switch (inputOperator)
                {
                    case "*":
                        {
                            Console.WriteLine("Atsakymas: {0}",inputNumberList[0] * inputNumberList[1]);
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine("Atsakymas: {0}", inputNumberList[0] / inputNumberList[1]);
                            break;
                        }
                    case "+":
                        {
                            Console.WriteLine("Atsakymas: {0}", inputNumberList[0] + inputNumberList[1]);
                            break;
                        }

                    case "-":
                        {
                            Console.WriteLine("Atsakymas: {0}", inputNumberList[0] - inputNumberList[1]);
                            break;
                        }
                    default:
                        Console.WriteLine("Blogai ivestas simbolis");
                        break;
                }

                // -----------------------------------------------------------------------------------------------

                Console.WriteLine("Testi darbą [Y]. Baigti darbą [N]");
                string nextDo = Console.ReadLine();
                if (nextDo == "N" || nextDo=="n") 
                {
                    break;
                } 
                else 
                { 
                    inputNumberList.Clear(); 
                    continue; 
                };
            } while (true);
        }
    }
}
