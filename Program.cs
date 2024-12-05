using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string name;
            string sex;
            string age;
            string answer;
            string disease = "";
            string crime = "";
            string skill = "";
            Console.WriteLine("Создадим ваш профиль");
            bool flag = true;
            User user = new User();

            while (flag)
            {
                Console.WriteLine("Введите имя");
                name = Console.ReadLine();
                user.Name = name;
                flag = false;
            }
            flag = true;

            while (flag)
            {
                Console.WriteLine("Введите пол (М/Ж)");
                sex = Console.ReadLine();
                if (sex.ToLower() == "м")
                {
                    user.Sex = true;
                    flag = false;
                }
                if (sex.ToLower() == "ж")
                {
                    user.Sex = false;
                    flag = false;
                }
            }
            flag = true;

            while (flag)
            {
                Console.WriteLine("Введите возраст");
                age = Console.ReadLine();
                if (Convert.ToInt32(age) > 0 && Convert.ToInt32(age) < 100)
                {
                    user.Age = Convert.ToUInt32(age);
                    flag = false;
                }
            }
            flag = true;

            Console.WriteLine("Введите ваши навыки в разных строках");
            Console.WriteLine("Введите 0 когда закончите");
            skill = Console.ReadLine();
            while (skill != "0")
            {
                user.skills.Add(skill);
                skill = Console.ReadLine();
            }

            Console.WriteLine("Теперь добавим документы");
            Console.WriteLine("Введите 1, чтобы добавить паспорт");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                Passport passport = new Passport();
                user.documents.Add(passport);
            }

            Console.WriteLine("Введите 1, чтобы добавить медецинскую книжку");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                MedicalCard medicalCard = new MedicalCard();
                Console.WriteLine("Введите ваши болезни в разных строках");
                Console.WriteLine("Введите 0 когда закончите");
                disease = Console.ReadLine();
                while (disease != "0")
                {
                    medicalCard.list_of_diseases.Add(disease);
                    disease = Console.ReadLine();
                }
                user.documents.Add(medicalCard);
            }

            Console.WriteLine("Введите 1, чтобы добавить справку о несудимости");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                CertificateOfNonCriminalRecord certificateOfNonCriminalRecord = new CertificateOfNonCriminalRecord();
                Console.WriteLine("Введите ваши судимости в разных строках");
                Console.WriteLine("Введите 0 когда закончите");
                crime = Console.ReadLine();
                while (crime != "0")
                {
                    certificateOfNonCriminalRecord.criminal_record_list.Add(crime);
                    crime = Console.ReadLine();
                }
                user.documents.Add(certificateOfNonCriminalRecord);
            }
            user.CheckDocs();
            Console.ReadKey();

            //ПОВАР
            Employer chef = new Employer();
            chef.sphere = "Хорека";
            chef.company = "Вилка и точка";
            Requirements chef_requirements = new Requirements();
            chef_requirements.minimal_age = 18;
            chef_requirements.maximal_age = 60;
            chef_requirements.men_only = false;
            chef_requirements.needed_documents.Add("passport");
            chef_requirements.needed_documents.Add("medical card");
            chef_requirements.needed_skills.Add("Готовить");
            chef.requirements = chef_requirements;
            Work chef_work = new Work();
            chef_work.number_of_days = 5;
            chef_work.number_of_hours = 6;
            chef_work.salary = 30000;
            chef_work.post = "Повар";
            chef_work.vacations = true;
            chef.work = chef_work;
            chef.number_of_employer = 1;
            chef.mood = rnd.Next(1, 10);

            //Дворник
            Employer street_sweeper = new Employer();
            street_sweeper.sphere = "Убощик территорий";
            street_sweeper.company = "До блеска";
            Requirements street_sweeper_requirements = new Requirements();
            street_sweeper_requirements.minimal_age = 14;
            street_sweeper_requirements.maximal_age = 70;
            street_sweeper_requirements.men_only = false;
            street_sweeper.requirements = street_sweeper_requirements;
            Work street_sweeper_work = new Work();
            street_sweeper_work.number_of_days = 4;
            street_sweeper_work.number_of_hours = 8;
            street_sweeper_work.salary = 15000;
            street_sweeper_work.post = "Дворник";
            street_sweeper_work.vacations = true;
            street_sweeper.work = street_sweeper_work;
            street_sweeper.number_of_employer = 2;
            street_sweeper.mood = 5;

            //Програмист
            Employer programmer = new Employer();
            programmer.sphere = "IT";
            programmer.company = "GVSS team";
            Requirements programmer_requirements = new Requirements();
            programmer_requirements.minimal_age = 1;
            programmer_requirements.maximal_age = 100;
            programmer_requirements.men_only = true;
            programmer_requirements.needed_skills.Add("Кодить");
            programmer.requirements = programmer_requirements;
            Work programmer_work = new Work();
            programmer_work.number_of_days = 8;
            programmer_work.number_of_hours = 25;
            programmer_work.salary = 0;
            programmer_work.post = "Раб";
            programmer_work.vacations = false;
            programmer.work = programmer_work;
            programmer.number_of_employer = 3;
            programmer.mood = rnd.Next(1, 10);

            flag = true;
            while (flag)
            {
                Console.WriteLine("Вот выши варианты:");
                Console.WriteLine("а. Повар");
                Console.WriteLine("б. Дворник");
                Console.WriteLine("в. Програмист");
                Console.WriteLine("г. Солдат");
                Console.WriteLine("д. Безработный");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "а":
                        if (!chef.blocked)
                        {
                            chef.CheckUser(user);
                        }
                        else
                        {
                            Console.WriteLine("Нет доступа, попробуёте устроиться в другое место");
                        }
                        break;
                    case "б":
                        if (!street_sweeper.blocked)
                        {
                            street_sweeper.CheckUser(user);
                        }
                        else
                        {
                            Console.WriteLine("Нет доступа, попробуёте устроиться в другое место");
                        }
                        break;
                    case "в":
                        if (!programmer.blocked)
                        {
                            programmer.CheckUser(user);
                        }
                        else
                        {
                            Console.WriteLine("Нет доступа, попробуёте устроиться в другое место");
                        }
                        break;
                    case "г":
                        if (user.Sex)
                        {
                            user.GoToArmy();
                        }
                        else
                        {
                            Console.WriteLine("Недоступная работа(я не сексист)");
                            continue;
                        }
                        break;
                    case "д":
                        if (user.Sex)
                        {
                            user.GoToArmy();
                        }
                        else
                        {
                            Console.WriteLine("Не знаю где будешь брать деньги, ну ладно");
                            Console.ReadKey();
                            Environment.Exit(1);
                        }
                        break;
                    default:
                        continue;
                }
            }


        }
    }
}
