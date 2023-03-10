using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingManegment.Models
{
    internal class Greeting : BaseModel
    {
        public string firstname { get; set; }

        public string lastname { get; set; }

        public DateTime DOB { get; set; }

        public DateTime DOA { get; set; }
    }
    
}
