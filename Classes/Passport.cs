using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6
{
    internal class Passport : Document
    {
        public string passport_number;
        Random random = new Random();
        Passport(string number) 
        { 
            this.passport_number = number;
            this.type = "passport";
            this.fake = true;
            this.digital_copy = false;
            this.valid_by = random.Next(2020, 2030);
        }
        public Passport()
        {
            this.passport_number = "8820" + Convert.ToString(random.Next(100000, 999999));
            this.type = "passport";
            this.fake = true;
            this.digital_copy = false;
            this.valid_by = random.Next(2020, 2030);
        }
    }
}
