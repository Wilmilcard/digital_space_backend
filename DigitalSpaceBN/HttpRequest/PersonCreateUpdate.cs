using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalSpaceBN.HttpRequest
{
    public class PersonCreateUpdate
    {
        public int? PersonID { set; get; }
        public string Name { get; set; }
        public string Telephone { set; get; }
        public string Document { set; get; }
        public int RolID { get; set; }
    }
}
