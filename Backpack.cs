using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace ConsoleApp23
{
    internal class Backpack
    {
        private string ColorB { get; set; }
        private string Brand { get; set; }
        private string Cloth { get; set; }
        private int loadB { get; set; } // в грамах
        private int VolumeB { get; set; } // в грамах
        public List<Tuple<string, int>> Ob;
        public event Action<Tuple<string, int>> ItemAdded;
        //Реалізуйте  анонімний метод як обробник події додавання об’єкта. 

        public Backpack()
        {
        }

        public Backpack(string _colorB, string _brand, string _cloth, int _loadB, int _volumeB, List<Tuple<string, int>> _ob)
        {
            ColorB = _colorB;
            Brand = _brand;
            Cloth = _cloth;
            loadB = _loadB;
            VolumeB = _volumeB;
            Ob = _ob;
        }

        public void AddBackpack(Tuple<string, int> _Ob)
        {
            if (_Ob.Item2 < VolumeB)
            {
                VolumeB -= _Ob.Item2;
                if (VolumeB > 1)
                {
                    Ob.Add(_Ob);
                    ItemAdded?.Invoke(_Ob); // Подія
                }
                else
                {
                    Console.WriteLine("Error: Не вистачає мiсця");
                }
            }
            else
            {
                Console.WriteLine("Error: Не вистачає мiсця");
            }
        }

        public void ShowB()
        {
            Console.WriteLine("Опис:");
            Console.WriteLine("Color: " + ColorB);
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Cloth: " + Cloth);
            Console.WriteLine("loadB: " + loadB + " грам");
            Console.WriteLine("VolumeB: " + VolumeB + " грам");
            Console.WriteLine();
        }

        public void ShowItem()
        {
            foreach (var item in Ob)
            {
                Console.WriteLine("Item: " + item.Item1 + ", Quantity: " + item.Item2);
            }
            Console.WriteLine();
        }
    }
}
