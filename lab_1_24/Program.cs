using System;

namespace lab_1_24
{
    class Menu
    {
        private string UserChoice; //Для исключения ошибок ввода тип данных можно взять string 
        private int arraySize;
        private int arrayMin;
        private int arrayMax;
        private string typeArray; //тип последовательности (случайный, упорядоченный, обратный) (random,ordered,reverce)
        private int rangeMin;
        private int rangeMax;
        private string sortType;

        public void startMenu()
        {
            Console.WriteLine("Выберите режим работы программы: \n\n" +
                "1: Сортировка одного массива, сформированного соучайным образом;\n" +
                "2: Режим накопления статистических данных;\n");

            UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                default:
                    startMenu();
                    break;
                case "1":
                    Console.Clear();

                    Console.WriteLine("Укажите размер массива;");
                    arraySize = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Укажите диапазон значений элементов массива;");
                    Console.Write("Min = ");
                    arrayMin = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Max = ");
                    arrayMax = Convert.ToInt32(Console.ReadLine());

                    break;
                case "2":
                    Console.Clear();

                    Console.WriteLine("Выберите способ формирования элементов массива\n\n" +
                        "1: Случайные значения;\n" +
                        "2: Упорядоченная последовательность;\n" +
                        "3: Обратно упорядоченная последовательность;");

                    UserChoice = Console.ReadLine();

                    switch (UserChoice)
                    {
                        default:
                            startMenu();
                            break;
                        case "1":
                            typeArray = "random";
                            break;
                        case "2":
                            typeArray = "ordered";
                            break;
                        case "3":
                            typeArray = "reverce";
                            break;
                    }

                    Console.WriteLine("Введите границы диапазона размеров массивов");
                    Console.WriteLine("Min = ");
                    rangeMin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Max = ");
                    rangeMax = Convert.ToInt32(Console.ReadLine());

                    break;
            }

            Console.WriteLine("Выберите метод сортировки:\n\n" +
                "1: Метод1;\n" +
                "2: Метод2;");

            UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                default:
                    startMenu();
                    break;
                case "1":

                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Menu menu = new Menu();

            menu.startMenu();
        }
    }
}
