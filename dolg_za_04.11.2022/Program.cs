using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ierarhiya
{
    class Work
    {
        string person;
        public string Person
        {
            get { return person; }
            set { person = value; }
        }
        string[] bosses;
        public string[] Bosses
        {
            get { return bosses; }
            set { bosses = value; }
        }
        string group;
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        public Work(string person, string[] bosses, string group)
        {
            this.person = person;
            this.bosses = bosses;
            this.group = group;
        }
        public Work(string person, string boss, string group)
        {
            this.person = person;
            this.bosses = new string[] { boss };
            this.group = group;
        }
        public void GiveTask(string a, string b, string c)
        {
            if ((bosses.Contains(a)) && b.Equals(person))
            {
                if (c.Equals(group))
                {
                    Console.Write($"Задача от {a} успешно передана {person}, в раздел {group}");
                }
                else
                {
                    Console.Write($"Ошибка, {person} не состоит в {group}");
                }
            }


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Work a = new Work("Рашид", "Борис", "Финансовый директор");
            Work b = new Work("О Ильхам", "Борис", "Директор по автоматизации");
            Work c = new Work("Лукас", "Рашид", "Бухгалтер");
            Work d = new Work("Оркадий", "О Ильхам", "Начальство");
            Work e = new Work("Володя", "Оркадий", "Начальство");
            Work f = new Work("Ильшат", new string[] { "Оркадий", "Володя" }, "Системщики");
            Work h = new Work("Иваныч", "Ильшат", "Системщики");
            Work i = new Work("Илья", "Иваныч", "Системщики");
            Work j = new Work("Витя", "Иваныч", "Системщики");
            Work k = new Work("Женя", "Иваныч", "Системщики");
            Work l = new Work("Сергей", new string[] { "Оркадий", "Володя" }, "Разработчики");
            Work n = new Work("Ляйсан", "Серегей", "Разработчики");
            Work o = new Work("Марат", "Лясан", "Разработчики");
            Work p = new Work("Дина", "Лясан", "Разработчики");
            Work q = new Work("Ильдар", "Лясан", "Разработчики");
            Work r = new Work("Антон", "Лясан", "Разработчики");
            Work[] z = new Work[] { a, b, c, d, e, f, h, i, j, k, l, n, o, p, q, r };
            Console.WriteLine("От кого передать");
            string a1 = Console.ReadLine();
            Console.WriteLine("Кому передать");
            string a2 = Console.ReadLine();
            Console.WriteLine("Какая задача");
            Console.WriteLine("1 - для начальства");
            Console.WriteLine("2 - для системщиков");
            Console.WriteLine("3 - для разработчиков");
            int a3 = int.Parse(Console.ReadLine());
            string a4 = "";
            switch (a3)
            {
                case 1:
                    a4 = "Начальтсво";
                    break;
                case 2:
                    a4 = "Системщики";
                    break;
                case 3:
                    a4 = "Разработчики";
                    break;
            }

            for (int x = 0; x < z.Length; x++)
            {
                f = z[x];
                f.GiveTask(a1, a2, a4);
            }








        }
    }
}
