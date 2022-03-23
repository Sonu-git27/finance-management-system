using System.Collections.Generic;

namespace Finance_Management.DataAccessLayer
{
    internal class FinanceDbContext
    {
        public IEnumerable<object> UserType { get; internal set; }
        public IEnumerable<object> EmiTable { get; internal set; }
    }
}