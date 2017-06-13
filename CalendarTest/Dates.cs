using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarTest
{
    class Dates
    {

        public DateTime Date { get; set; }

        public Dates()
        {
            Date = DateTime.Today;
        }

        public Dates(DateTime d)
        {
            Date = d;
        }
    }
}
