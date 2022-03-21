using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] array = new string[2];
            Console.WriteLine("arrayin elementlerini daxil edin: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            foreach (var item in array)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    switch (item[i])
                    {
                        case '0':
                            count++;
                            break;
                        case '1':
                            count++;
                            break;
                        case '2':
                            count++;
                            break;
                        case '3':
                            count++;
                            break;
                        case '4':
                            count++;
                            break;
                        case '5':
                            count++;
                            break;
                        case '6':
                            count++;
                            break;
                        case '7':
                            count++;
                            break;
                        case '8':
                            count++;
                            break;
                        case '9':
                            count++;
                            break;
                        default:
                            break;
                    }
                }
            }
            if (count > 0)
                Console.WriteLine("sozlerde reqem var");
            else
                Console.WriteLine("sozlerde reqem yoxdur");


            Console.WriteLine("arrayin elementlerini daxil edin: ");
            string[] words = new string[4];
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Console.ReadLine();
            }
            foreach (var item in words)
            {
                for (int j = 0; j < item.Length - 1; j++)
                {
                    if (item[j] == 'a' && item[j + 1] == 'l')
                    {
                        count++;
                    }
                }
            }
            if (count > 0)
                Console.WriteLine("vardir");

            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);
            int sum = 0;
            int count = 0;
            if (number > 0)
            {
                while (number > 0)
                {
                    sum += number % 10;
                    number = (number - number % 10) / 10;
                    count++;
                }
                Console.WriteLine(sum / count);
            }


            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);
            int sum = 0;
            int count = 0;
            if (number > 0)
            {
                while (number > 0)
                {
                    sum += number % 10;
                    number = (number - number % 10) / 10;
                    count++;
                }
                Console.WriteLine(sum / count);
            }
        }

    }
}
