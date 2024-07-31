using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{// tüzel müşteri
    internal class CoorporateCustomer:Customer // inheritance
    {
     
        public string CompanyName { get; set; }

        public string TaxNumber { get; set; }
    }
}
