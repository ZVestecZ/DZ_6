using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6
{
    internal class CertificateOfNonCriminalRecord : Document
    {
        public List<string> criminal_record_list = new List<string>();
        Random random = new Random();
        public CertificateOfNonCriminalRecord()
        {
            this.type = "certificate of non criminal record";
            this.fake = true;
            this.digital_copy = false;
            this.valid_by = random.Next(2020, 2030);
        }
    }
}
