using Specification.DP.Models;

namespace Specification.DP.Specifications;

public class ProductsByBrandSpec : BaseSpecification<Product>
{
    public ProductsByBrandSpec(string brand)
        : base(p => p.Brand == brand)
    {
    }
}
