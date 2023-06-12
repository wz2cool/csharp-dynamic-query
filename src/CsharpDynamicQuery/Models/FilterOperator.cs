using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDynamicQuery.Models
{
    // Summary:
    //     Operator used in FilterDescriptor class
    public enum FilterOperator
    {
        // Summary:
        //     Left operand must be smaller than the right one
        LessThan,
        //
        // Summary:
        //     Left operand must be smaller than or equal to the right one
        LessThanOrEqual,
        //
        // Summary:
        //     Left operand must be equal to the right one
        Equal,
        //
        // Summary:
        //     Left operand must be different from the right one
        NotEqual,
        //
        // Summary:
        //     Left operand must be larger than the right one
        GreaterThanOrEqual,
        //
        // Summary:
        //     Left operand must be larger than or equal to the right one
        GreaterThan,
        //
        // Summary:
        //     Left operand must start with the right one
        StartWith,
        //
        // Summary:
        //     Left operand must end with the right one
        EndWith,
        //
        // Summary:
        //     Left operand must contain the right one
        Contains,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        NotIn,
        /// <summary>
        /// 
        /// </summary>
        Between,
    }
}
