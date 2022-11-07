namespace прак2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a != 0)
            {
                Console.WriteLine("Выберите действие от 1 до 3");
                Console.WriteLine("1 - Угадай число");
                Console.WriteLine("2 - Таблица умножения");
                Console.WriteLine("3 - Вывод делителей числа");
                Console.WriteLine("4 - Выход");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Ugadaika();
                }
                else if (a == 2)
                {
                    tablitca();
                }
                else if (a == 3)
                {
                    delitel();
                }
                else if (a == 4)
                {
                    Console.WriteLine("Вы вышли из программы");
                }
                static void Ugadaika()
                {
                    Console.WriteLine("Угадай число от 1 до 100");
                    bool b = true;
                    Random r = new Random();
                    int Value = r.Next(0, 100);
                    while (b)
                    {
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a != Value)
                        {
                            if (a < Value)
                                Console.WriteLine("Попробуйте больше");
                            else
                                Console.WriteLine("Попробуйте меньше");
                        }
                        else
                        {
                            Console.WriteLine("Вы угадали");
                            b = false;
                        }
                    }
                }
                static void tablitca()
                {
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    int[,] tablica = new int[1, 9];
                    for (int z = 1; z < 10; z++)
                    {
                        for (int x = 1; x < 10; x++)
                        {
                            Console.Write("{0}\t", z * x);
                        }
                    }
                }
                static void delitel()
                {
                    int c = 0;
                    Console.WriteLine("Введите целое число");
                    c = Convert.ToInt32(Console.ReadLine());
                    for (int y = 0; y < y + 1; y++)
                    {
                        if (c % y == 0)
                        {
                            Console.WriteLine(y);
                        }
                        else
                        {
                            Console.WriteLine(c);
                        }
                    }
                }
            }
        }
    }
}