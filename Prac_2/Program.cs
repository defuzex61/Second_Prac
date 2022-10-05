namespace Prac_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //а ведь я мог поиграть в киберпанк...
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1.Игра Угадай число ");
            Console.WriteLine("2.Таблица умножения ");
            Console.WriteLine("3.Вывод делителей числа");
            Console.WriteLine("4.Выход");
            int menu_num = Convert.ToInt32(Console.ReadLine());
            while (menu_num != 4)
            {
               if (menu_num == 1)
                {
                    Console.WriteLine("Вы должны вводить числа до тех пор, пока введенное число не будет равно загаданному.");
                    int user_num = Convert.ToInt32(Console.ReadLine());
                    Game(user_num);
                }
                else if (menu_num == 2)
                {
                    multiplication();
                }
               else if (menu_num == 3)
                {
                    Console.WriteLine("Введите число");
                    int user_value = Convert.ToInt32(Console.ReadLine());
                    divider(user_value);
                }
                Console.WriteLine(" ");
                Console.WriteLine("Выберите программу:");
                Console.WriteLine("1.Игра Угадай число ");
                Console.WriteLine("2.Таблица умножения ");
                Console.WriteLine("3.Вывод делителей числа");
                Console.WriteLine("4.Выход");
                menu_num = Convert.ToInt32(Console.ReadLine());
            }

                    
        }
        static void Game(int user_num)
        {
           
            Random rnd = new Random();
            int random_num = rnd.Next(0, 100);
           // Console.WriteLine(random_num);  # посмотреть число ответик чтоб как бы да... ага
            while (random_num != user_num)
            {
                if (user_num != random_num)
                {
                    if (user_num < random_num)
                    {
                        Console.WriteLine("Не Миш... Все фигня давай по новой! Больше!");
                    }
                    else if(user_num > random_num)
                    {
                        Console.WriteLine("Не фигня... Я ломал стеклоу... Меньше! ");
                    }
                    user_num = Convert.ToInt32(Console.ReadLine());
                }
                user_num = user_num;

            }
            Console.WriteLine("Вы угадали! Ура... Победа...");
        }
        static void multiplication()
        {
            int[,] table = new int[10, 10];
            table[1,1] = 1;
            for (int row = 1; row < table.GetLength(0); row++)
            {
                for (int line = 1; line < table.GetLength(1); line++)
                {
                    table[row, line] = row * line;
                    Console.Write(table[row, line]);
                    Console.Write("   ");
                }
                Console.WriteLine(" ");
            }
        }   
        static void divider(int user_value)
        {
            int num=1;
            while (user_value >= num)
            {
                if (user_value % num == 0)
                {
                    Console.Write(num);
                    Console.Write("  ");
                    num++;
                }  
                else
                {
                    num++;
                }
            }
        }
    }
}