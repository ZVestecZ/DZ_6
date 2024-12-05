using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6
{
    internal class MilitaryCard : Document
    {
        public bool military_ticked = false;
        Random random = new Random();
        public MilitaryCard()
        {
            this.type = "military card";
            this.fake = true;
            this.digital_copy = false;
            this.valid_by = random.Next(2020, 2030);
        }
    }
}
