using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6
{
    internal class MedicalCard : Document
    {
        public List<string> list_of_diseases = new List<string>();
        Random random = new Random();
        public MedicalCard()
        {
            this.type = "medical card";
            this.fake = true;
            this.digital_copy = false;
            this.valid_by = random.Next(2020, 2030);
        }
    }
}
