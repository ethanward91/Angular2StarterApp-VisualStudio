using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular2StarterApp.Models
{
    public class Todo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }

        public Todo()
        {
            Status = "Incomplete";
        }
    }
}
