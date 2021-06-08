using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acab3
{
    class Product
    {
        string date = "03.06.2021";
        public string name;
        public string cdate;
        public string creator;
        public string sostav;
        public string nametype;
        public float cost;
        public void Show()
        {
            Console.WriteLine($"Название продукта: {name}\nДата изготовления: {cdate}\nПроизводитель: {creator}\nСостав: {sostav}\nВид продукта: {nametype}\nЦена продукта: {cost} руб.");
        }
        public void Show1(string cdate, string tape)
        {
            int day = Convert.ToInt32(date.Substring(0, 2));
            int month = Convert.ToInt32(date.Substring(3, 2));
            int cday1 = Convert.ToInt32(cdate.Substring(0, 2));
            int cmonth1 = Convert.ToInt32(cdate.Substring(3, 2));
            if (tape.Contains("Хлебобулочное"))
            {
                
                if ((month-cmonth1)<1&&(day-cday1==0))
                {
                    Console.WriteLine($"Сегодняшняя дата: {date}, Дата изготовдения продукта: {cdate} -> Продукт свежий");
                }
                else
                {
                    Console.WriteLine($"Сегодняшняя дата: {date}, Дата изготовдения продукта: {cdate} -> Продукт несвежий");
                }
            }
            else if (tape.Contains("Молочное"))
            {
                
                if (((day - cday1) <= 14&& (day - cday1) <= -14))
                {
                    Console.WriteLine($"Сегодняшняя дата: {date}, Дата изготовдения продукта: {cdate} -> Продукт несвежий");
                }
                else
                {
                    Console.WriteLine($"Сегодняшняя дата: {date}, Дата изготовдения продукта: {cdate} -> Продукт свежий");
                }
            }
            else if (tape.Contains("Мясное"))
            {

                if ((day - cday1 <= 15 && (day - cday1) <= -15))
                {
                    Console.WriteLine($"Сегодняшняя дата: {date}, Дата изготовдения продукта: {cdate} -> Продукт несвежий");
                }
                else
                {
                    Console.WriteLine($"Сегодняшняя дата: {date}, Дата изготовдения продукта: {cdate} -> Продукт свежий");
                }
            }
            else if (tape.Contains("Кондитерское"))
            {
                if ((day - cday1 <= 1 && (day - cday1) <= -1))
                {
                    Console.WriteLine($"Сегодняшняя дата: {date}, Дата изготовдения продукта: {cdate} -> Продукт несвежий");
                }
                else
                {
                    Console.WriteLine($"Сегодняшняя дата: {date}, Дата изготовдения продукта: {cdate} -> Продукт свежий");
                }
            }
            Console.WriteLine("======================================");
            

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Product hleb = new Product();
            hleb.name = "Хлеб Бородино";
            hleb.cdate = "03.05.2021";
            hleb.creator = "Слобода";
            hleb.sostav = "Мука, Молоко";
            hleb.nametype = "Хлебобулочное изделие";
            hleb.cost = 30;
            hleb.Show(); 
            hleb.Show1(hleb.cdate,hleb.nametype);
            Product milk = new Product();
            milk.name = "Молоко Домик в деревне";
            milk.cdate = "27.06.2021";
            milk.creator = "Бабушка";
            milk.sostav = "Корова, концентрат";
            milk.nametype = "Молочное изделие";
            milk.cost = 50;
            milk.Show();
            milk.Show1(milk.cdate,milk.nametype);
            Product kefir = new Product();
            kefir.name = "Кефир Простоквашино";
            kefir.cdate = "31.06.2021";
            kefir.creator = "ООО Матроскин & Ко";
            kefir.sostav = "Молоко, Эмульгаторы";
            kefir.nametype = "Молочное изделие";
            kefir.cost = 50;
            kefir.Show();
            kefir.Show1(kefir.cdate, kefir.nametype);
            Product meat = new Product();
            meat.name = "Сосиски молочные";
            meat.cdate = "08.06.2021";
            meat.creator = "ООО Матроскин & Ко";
            meat.sostav = "Говядина, Свинина, Соль, Специи";
            meat.nametype = "Мясное изделие";
            meat.cost = 300;
            meat.Show();
            meat.Show1(meat.cdate,meat.nametype);
            Product candy = new Product();
            candy.name = "Петушок на палочке";
            candy.cdate = "03.06.2021";
            candy.creator = "ООО Ясно Солнышко";
            candy.sostav = "Сахар, Карамель, Усилитель вкуса";
            candy.nametype = "Кондитерское изделие";
            candy.cost = 10;
            candy.Show();
            candy.Show1(candy.cdate, candy.nametype);
            Console.ReadKey();
        }
    }
}
