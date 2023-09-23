using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //инициализация переменных
            int flat = 0; //квартиры
            int entrance = 0; //подъезды
            int floor = 0; //этажи
            const int countFlatInFloor = 4;

            for (; ; )
            {
                Console.WriteLine("Информацию необходимо вносить числах. \nВведите количество подъездов: ");
                entrance = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество этажей: ");
                floor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номер квартиры: ");
                flat = Convert.ToInt32(Console.ReadLine());
                if (flat > entrance * floor * countFlatInFloor)
                {
                    Console.WriteLine("Максимальное количество квартир в доме: " + floor * entrance * 4 + ". Введите реальное количество квартир.");
                }
                else
                {
                    entrance = 1;
                    break;
                }
            }
            int[] arrayFlat = new int[countFlatInFloor] {3, 1, 2, 3 };
            int[][] arrayFloor = new int[floor][];
            int a = flat;
            for(int i = 0; i <= floor; i++)
            {
                if(i == floor)
                {
                    entrance += 1;
                    i = 0;
                }
                arrayFloor[i] = new int[arrayFlat.Length];

                for (int j = 0; j < arrayFlat.Length; j++)
                {
                    arrayFloor[i][j] = arrayFlat[j];
                    a--;
                    if(a == 0)
                    {
                        Console.WriteLine(arrayFlat[j] + " - комнатная квартира под номером " + flat + " находится на " + (i+1) + " этаже в " + entrance + " подъезде.");
                        Console.ReadLine();
                        return;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
