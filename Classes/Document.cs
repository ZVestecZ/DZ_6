using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6
{
    internal abstract class Document
    {
        public string type;
        public bool fake;
        public int valid_by;
        public bool digital_copy;
        public void MakeDigitalCopy()
        {
            this.digital_copy = true;
        }
        public int Extend(uint extend_by)
        {
            this.valid_by += Convert.ToInt32(extend_by);
            return this.valid_by;
        }
        public void MakeTrue()
        {
            this.fake = false;
        }
    }
}
