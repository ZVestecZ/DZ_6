using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6
{
    internal class Requirements
    {
        public int minimal_age = 0;
        public int maximal_age = 100;
        public bool men_only;
        public List<string> needed_documents = new List<string>();
        public List<string> needed_skills = new List<string>();
    }
}
