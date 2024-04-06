using System;

class Program {
  public static void Main (string[] args) {
    {
        int n;
        Console.WriteLine("Oscilliate Fan? Y/N");
        string choco = Console.ReadLine().ToUpper();
        if (choco == "Y")
        {
            do
            {
                Console.Write("Enter Fan Speed [1, 2, or 3]: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
                    continue;
                }
                if (n == 0)
                {
                    Console.WriteLine("Closing Program...");
                    return;
                }
                else if (n >= 4)
                {
                    Console.Write("Invalid, Please Enter a valid input");
                    continue;
                }

                PrintTriangle(n);

            } while (true);


        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n * 10; i++)
            {
                for (int j = 0; j <= n - i; j++)
                {
                    Console.Write("");
                }
                for (int k = 0; k <= 1 * i - 1; k++)
                {
                    Console.Write("~");
                }
                Console.WriteLine();
            }
            for (int i = n * 10; i >= 1; i--)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("");
                }
                for (int k = 0; k <= 1 * i - 1; k++)
                {
                    Console.Write("~");
                }
                Console.WriteLine();
            }
        }
        }
        else if (choco == "N"){
            do
            {
                Console.Write("Enter Fan Speed [1, 2, or 3]: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
                    continue;
                }
                if (n == 0)
                {
                    Console.WriteLine("Closing Program...");
                    return;
                }
                else if (n >= 4)
                {
                    Console.Write("Invalid, Please Enter a valid input");
                    continue;
                }

                PrintTriangle(n);

            } while (true);


        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= n - i; j++)
                {
                    Console.Write("");
                }
                for (int k = 0; k <= n * i - 1; k++)
                {
                    Console.Write("~");
                }
                Console.WriteLine();
            }
            for (int i = n; i >= 1; i--)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("");
                }
                for (int k = 0; k <= n * i - 1; k++)
                {
                    Console.Write("~");
                }
                Console.WriteLine();
            }
        }

        }

  }
}
}