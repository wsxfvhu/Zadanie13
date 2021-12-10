using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес здания ");
            string ad = Console.ReadLine();
            Console.WriteLine("Введите длинну здания");
            int dl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину здания");
            int sh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту здания");
            int vy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество этажей");
            int et = Convert.ToInt32(Console.ReadLine());
            Building dom1 = new Building(ad, dl, sh, vy);
            MultiBuilding dom2 = new MultiBuilding(ad, dl, sh,vy, et);
            dom1.Print();
            Console.WriteLine();
            dom2.Print();
            Console.ReadKey();
        }
        class Building
        {
            protected string Adres { get; set; }
            double dlinna;
            double shirina;
            double vysota;
            public double Dlinna
            {
                set
                {
                    if (value > 0)
                    {
                        dlinna = value;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка длинна должна быть больше 0");
                    }
                }
                get { return dlinna; }
            }
            public double Shirina
            {
                set
                {
                    if (value > 0)
                    {
                        shirina = value;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ширина должна быть больше 0");
                    }
                }
                get { return shirina; }
            }
            public double Vysota
            {
                set
                {
                    if (value > 0)
                    {
                        vysota = value;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка высота должна быть больше 0");
                    }
                }
                get { return vysota; }
            }
            public Building(string adres, double dlinna, double shirina, double vysota)
            {
                Adres = adres;
                Dlinna = dlinna;
                Shirina = shirina;
                Vysota = vysota;
            }
            public void Print()
            {
                Console.WriteLine($"Адрес  здания: {Adres}");
                Console.WriteLine($"Длинна здания: {Dlinna}");
                Console.WriteLine($"Ширина здания: {Shirina}");
                Console.WriteLine($"Высота здания: {Vysota}");
            }
        }
        class MultiBuilding : Building
        {
            int etazh;
            public int Etazh
            {
                set
                {

                    if (value >= 1)
                    {
                        etazh = value;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка этажей должно быть 1 или больше");
                    }
                }
                get { return etazh; }
            }
            public MultiBuilding(string adres, double dlinna, double shirina, double vysota, int etazh = 1)
                : base(adres, dlinna, shirina, vysota)
            {
                //base.Adres = adres;
                //base.Dlinna = dlinna;
                //base.Shirina = shirina;
                //base.Vysota = vysota;
                Etazh = etazh;
            }
            public new void Print()
            {
                base.Print();
                Console.WriteLine($"Количество этажей: {Etazh}");

            }

        }
    }

}