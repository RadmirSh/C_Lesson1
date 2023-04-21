// 1. Написать программу, которая на вход принимает 2 числа и выдает, какое из них больше, а какое меньше
Console.WriteLine("Please write number 1: ");
            int num_a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please write number 2: ");
            int num_b = Convert.ToInt32(Console.ReadLine());

            if (num_a > num_b)
            {
                Console.WriteLine("max value " + num_a);
            }
           if (num_a == num_b)
            {
                Console.WriteLine("values are equal ");
            }
            else
            {
                Console.WriteLine("max value " + num_b);
            }