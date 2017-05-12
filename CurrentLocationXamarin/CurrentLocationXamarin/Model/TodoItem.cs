using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentLocationXamarin
{
    public class TodoItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime DueDate { get; set; }
        public string LocationCoordinates { get; set; }
    }
}
