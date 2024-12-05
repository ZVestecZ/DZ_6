using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6
{
    internal class Employer
    {
        public bool blocked = false;
        public string sphere;
        public string company;
        public Requirements requirements;
        public Work work;
        public int mood;
        public int number_of_employer;

        public bool CheckUser(User user)
        {
            if (!CheckDocuments(user.documents) || !CheckSkills(user.skills) || Convert.ToInt32(user.Sex) >= Convert.ToInt32(this.requirements.men_only) || user.Age<this.requirements.minimal_age || user.Age > this.requirements.maximal_age)
            {
                if (this.mood >= 3)
                {
                    Block();
                }
                else
                {
                    SendToTheArmy(user);
                }
                return false;
            }
            Console.WriteLine("Поздравляю, вы приняты");

            return true;
        }
        public bool CheckDocuments(List<Document> documents)
        {
            List<string> list = new List<string>();
            foreach (Document document in documents)
            {
                list.Add(document.type.ToString());
            }
            foreach (string i in requirements.needed_documents)
            {
                if (!list.Contains(i))
                {
                    return false;
                }
            }
            return true;
        }
        public bool CheckSkills(List<string> skills)
        {
            foreach (string i in requirements.needed_skills)
            {
                if (!skills.Contains(i))
                {
                    return false;
                }
            }
            return true;
        }
        public void Block()
        {
            Console.WriteLine("Не приходи сюда больше!");
            this.blocked = true;
        }
        public void SendToTheArmy(User user)
        {
            Console.WriteLine("Всё, ты меня достал, я обращаюсь в военкомат по поводу твоей будущеё службы");
            user.GoToArmy();
        }
        public void Hire()
        {
            Console.WriteLine($"Добро пожаловать в компанию {this.company}");
            Console.ReadKey();
            Environment.Exit(1);
        }
        public void Inform(User user)
        {
            Console.WriteLine($"Сфера работы - {sphere}");
            Console.WriteLine($"Компания - {company}");
            Console.WriteLine("Введите 1, чтобы попробовать устроиться");
            string answer = Console.ReadLine();
            if ( answer == "1")
            {
                this.CheckUser(user);
            }
        }
    }
}
