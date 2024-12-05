using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZ_6
{
    internal class User
    {
        private bool sex;
        private uint age;
        private string name;
        public List<Document> documents = new List<Document> { };
        public List<string> skills = new List<string> { };
        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public uint Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }   
            set { name = value; }
        }
        public bool TryToEmploy(int num)
        {
            return true;
        }


        public void GoToArmy()
        {
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Добро пожаловать");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("В вооружённые силы");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Российской Федерации");
            Console.ResetColor();
            Thread.Sleep(3000);
            while (true)
            {
                Thread.Sleep(100);
                Console.WriteLine("ГОЙДА");
                Thread.Sleep(100);
                Console.WriteLine("ZOV");
            }
        }
        public void CheckDocs()
        {
            Console.WriteLine("");
            Console.WriteLine("Вся информация добавленная вами:");
            Console.WriteLine($"Имя {this.name}");
            if (this.sex)
            {
                Console.WriteLine("М");
            }
            else
            {
                Console.WriteLine("Ж");
            }
            Console.WriteLine($"Возраст {Convert.ToString(this.age)}");
            Console.WriteLine("Ваши навыки:");
            foreach(string str in this.skills)
            {
                Console.WriteLine(str);
            }

        }
    }
}
