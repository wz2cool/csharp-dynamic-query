using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDynamicQuery.Models
{
    public class SortDescriptor
    {
        public string PropertyPath { get; set; }

        public SortDirection Direction { get; set; }

        public SortDescriptor() { }

        public SortDescriptor(string propertyPath, SortDirection direction)
        {
            PropertyPath = propertyPath;
            Direction = direction;
        }
    }
}
