using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonObjects
{
    public class categories
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public int cntOfTaggedBooks { get; set; }
        public bool Active { get; set; }
    }
}
