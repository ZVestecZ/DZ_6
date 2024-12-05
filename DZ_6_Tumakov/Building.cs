using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_Tumakov
{
    internal class Building
    {
        private int nextBuildingNumber = 1;
        private int buildingNumber;
        private double height;
        private int floors;
        private int apartments;
        private int entrances;

        public Building(double height, int floors, int apartments, int entrances)
        {
            this.buildingNumber = nextBuildingNumber++;
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }

        public int GetBuildingNumber() 
        { 
            return buildingNumber; 
        }
        public double GetHeight() 
        { 
            return height; 
        }
        public int GetFloors() 
        { 
            return floors; 
        }
        public int GetApartments() 
        { 
            return apartments; 
        }
        public int GetEntrances() 
        { 
            return entrances; 
        }


        public double GetFloorHeight()
        {
            if (floors == 0)
            {
                return 0;
            }
            return height / floors;
        }

        public int GetApartmentsPerEntrance()
        {
            if (entrances == 0)
            {
                return 0;
            }
            return apartments / entrances;
        }

        public int GetApartmentsPerFloor()
        {
            if (floors == 0)
            {
                return 0;
            }
            return apartments / floors;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Номер здания: {buildingNumber}");
            Console.WriteLine($"Высота: {height} м");
            Console.WriteLine($"Этажность: {floors}");
            Console.WriteLine($"Количество квартир: {apartments}");
            Console.WriteLine($"Количество подъездов: {entrances}");
            Console.WriteLine($"Высота этажа: {GetFloorHeight():F2} м");
            Console.WriteLine($"Квартир в подъезде: {GetApartmentsPerEntrance()}");
            Console.WriteLine($"Квартир на этаже: {GetApartmentsPerFloor()}");
        }
    }
}
