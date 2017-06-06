using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Line
    {
        public int LineId { get; set; }
        public string Content { get; set; }
        public Story Story { get; set; }
    }
}
