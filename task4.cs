static void Main(string[] args)
        {
            string number = Number();
            if (Test(number))
            {
                Console.WriteLine(ConvertDouble(number));
            }
                else
            {
                Console.Write(ConvertInt(number));
            }

        }
        static string Number()
        {
            Console.Write("enter a number: ");
            string number = Console.ReadLine();
            return number;
        }
        static bool Test(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == ',')
                {
                    return true;
                }

            }
            return false;

        }
        static int ConvertInt(string number)
        {
            return Convert.ToInt32(number);
        }
        static double ConvertDouble(string number)
        {
            return Convert.ToDouble(number);
        }