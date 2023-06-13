using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDynamicQuery.Models
{
    [Serializable]
    public class FilterDescriptor : IEqualityComparer<FilterDescriptor>
    {
        public bool IsCaseSensitive { get; set; }
        public FilterCondition Condition { get; set; }
        public FilterOperator Operator { get; set; }
        public string PropertyPath { get; set; }
        public object Value { get; set; }

        public FilterDescriptor() { }
        public FilterDescriptor(string propertyPath, FilterOperator filterOperator, object filterValue)
        {
            PropertyPath = propertyPath;
            Operator = filterOperator;
            Value = filterValue;
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj is FilterDescriptor descriptor)
            {
                result = Equals(this, descriptor);
            }
            return result;
        }

        public override int GetHashCode()
        {
            return GetHashCode(this);
        }

        public bool Equals(FilterDescriptor x, FilterDescriptor y)
        {
            bool result = false;
            if (x != null && y != null)
            {
                result = x.IsCaseSensitive == y.IsCaseSensitive
                    && x.Condition == y.Condition
                    && x.Operator == y.Operator
                    && x.PropertyPath == y.PropertyPath
                    && x.Value == y.Value;
            }
            return result;
        }

        public int GetHashCode(FilterDescriptor obj)
        {
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return obj.ToString().GetHashCode();
            }
        }

        public FilterCondition GetCondition()
        {
            throw new NotImplementedException();
        }

        public void SetCondition(FilterCondition condition)
        {
            throw new NotImplementedException();
        }
    }
}
