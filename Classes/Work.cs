using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6
{
    internal class Work
    {
        public int number_of_days;
        public int number_of_hours;
        public int salary = 0;
        public string post = "";
        public bool vacations;
        public int ChangeNumberOfDays()
        {
            if (number_of_days > 4)
            { 
                number_of_days--;
                Console.WriteLine("Хорошо, будите работать на 1 день меньше");
            }
            else
            {
                Console.WriteLine("Нет, рабочих дней и так мало");
            }
            return number_of_days;
        }
        public int ChangeNumberOfHours()
        {
            if (number_of_hours > 6)
            {
                number_of_hours--;
                Console.WriteLine("Хорошо, будите работать на 1 час меньше");
            }
            else
            {
                Console.WriteLine("Нет, рабочая смена и так коротка");
            }
            return number_of_hours;
        }
        public int ChangeSalary()
        {
            double new_salary = salary * 1.2;
            return Convert.ToInt32(new_salary);
        }
        public void ChangePost()
        {
            Console.WriteLine("Извинити, нет другой должности");
        }
        public void ChangeVacations()
        {
            if (!vacations)
            {
                vacations = true;
                Console.WriteLine("Теперь отпуск будет");
            }
            else
            {
                Console.WriteLine("Отпуск и так есть");
            }
        }
    }
}
