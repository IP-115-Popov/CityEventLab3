using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEventLab3.Models
{
    internal class MyEvent
    {
        public MyEvent() { }
        public string ImagePath { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }       
        public string Date { get; set; }
        public string Price { get; set; }

    }
}
