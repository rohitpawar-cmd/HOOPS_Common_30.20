using System;
using System.Linq.Expressions;
using System.Threading;

namespace Hexagon.ALI.Analysis.Common.Models
{
    public class DbQueryOptions<T>
    {
        public DbQueryOptions() { }

        public DbQueryOptions(Expression<Func<T, bool>> filter, int numberOfRows, CancellationToken cancellationToken)
        {
            Filter = filter;
            NumberOfRows = numberOfRows;
            CancellationToken = cancellationToken;
        }

        public int NumberOfRows { get; set; } = Int32.MaxValue;

        public Expression<Func<T, bool>> Filter { get; set; } = s => true;

        public CancellationToken CancellationToken { get; set; } = default;
    }
}
