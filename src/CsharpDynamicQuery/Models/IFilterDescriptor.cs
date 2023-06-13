using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDynamicQuery.Models
{
    /// <summary>
    /// The descriptor of filter.
    /// </summary>
    public interface IFilterDescriptor
    {
        /// <summary>
        /// Get filter condition.
        /// </summary>
        /// <returns>filter condition</returns>
        FilterCondition GetCondition();

        /// <summary>
        /// Set filter condition.
        /// </summary>
        /// <param name="condition">filter condition</param>
        void SetCondition(FilterCondition condition);
    }
}
