using System.Linq.Expressions;

namespace Specification.DP.Specifications;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }
}
