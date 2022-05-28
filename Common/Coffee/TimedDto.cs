using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Coffee
{
    public class TimedDto
    {
        public int Id { get; init; }
        public DateTime Time { get; set; }
        public bool Repeating  { get; set; }
    }
}
