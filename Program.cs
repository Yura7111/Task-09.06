using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp23
{
    class Program
    {
        
        //Завдання 2
        static void NewItemAdded(Tuple<string, int> item)
        {
            //Реалізуйте  анонімний метод як обробник події додавання об’єкта.
            Console.WriteLine("Додано новий об'єкт до рюкзака: " + item.Item1);
            //Якщо я правильно зрозумів в нас є клас рюкзак і кожен раз коли ми в любій відео грі щось піднімаєм і ставим в рюкзак 
            //нам виводить повідомлення в системках типу Отримано: 10 золота так само і цій задачі я так поняв 
        }
        static void Main(string[] args)
        {
            Backpack backpack = new Backpack("Синiй", "Nike", "Шкiра", 150, 1000, new List<Tuple<string, int>>());
            backpack.ItemAdded += NewItemAdded;// Відклідковуєм кожен примет який додається  в рюкзак
            backpack.AddBackpack(new Tuple<string, int>("Книга:Кобзар", 150));
            backpack.AddBackpack(new Tuple<string, int>("Книга:Вiд нервiр", 300));
            backpack.AddBackpack(new Tuple<string, int>("Книга:123214241231", 551));//Перевищує ліміт можливостей 
            Console.WriteLine();
            // Завдання 3  лямбда-вираз для підрахунку кількості чисел у масиві, кратних семи.
            int[] Arr = { -22,10,21,35,-45,5,7,8,-15,-15,-22,-10 };
            Func<int[], int> countSeven = arr => arr.Count(num => num % 7 == 0);
            int count = countSeven(Arr);
            Console.WriteLine("Кiлькiсть чисел кратних Семи:" + count);//21,35,7
            //Завдання 4 лямбда-вираз для підрахунку кількості позитивних чисел
            Func<int[], int> countPlus = arr => arr.Count(num => num >=0);
            count = countPlus(Arr);
            Console.WriteLine("Кiлькiсть позитивних чисел:" + count);
            //Завдання 5 лямбда-вираз для відображення унікальних негативни чисел
            var CountMinus = Arr.Where(num => num < 0).Distinct();
            Console.WriteLine("Унiкальнi негативнi числа:");
            foreach (var item in CountMinus)
            {
                Console.WriteLine(item);
            }
            //Завдання 6
            string text = "Перевiрка заданого слова";
            string word = "слово";
            Func<string, string, bool> containsWord = (txt, wrd) => txt.Contains(wrd);
            bool containsSample = containsWord(text, word);
            Console.WriteLine("Текст мiстить слово 'слово': " + containsSample);
        }
    }
}
namespace ConsoleApp23
{
    class P
    {
        delegate void RainbowColorHandler(string color);

        static void Main(string[] args)
        {
            RainbowColorHandler colorHandler = delegate (string color)
            {
                int red = 0;
                int green = 0;
                int blue = 0;

                switch (color.ToLower())
                {
                    case "red":
                        red = 255;
                        break;
                    case "orange":
                        red = 255;
                        green = 165;
                        break;
                    case "yellow":
                        red = 255;
                        green = 255;
                        break;
                    case "green":
                        green = 255;
                        break;
                    case "blue":
                        blue = 255;
                        break;
                    case "indigo":
                        blue = 75;
                        green = 0;
                        red = 130;
                        break;
                    case "violet":
                        red = 238;
                        green = 130;
                        blue = 238;
                        break;
                    default:
                        Console.WriteLine("Invalid color!");
                        return;
                }

                Console.WriteLine("RGB {0}: R={1}, G={2}, B={3}", color, red, green, blue);
            };

            colorHandler("red");
            colorHandler("orange");
            colorHandler("yellow");
            colorHandler("green");
            colorHandler("blue");
            colorHandler("indigo");
            colorHandler("violet");
        }
    }
}

