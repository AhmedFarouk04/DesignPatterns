using Microsoft.Extensions.DependencyInjection;

namespace DI.Correct
{
    class Program
    {
        static void Main()
        {
            // ================================
            // OPTION 1: Manual Dependency Injection
            // ================================
            // - Simple
            // - Explicit
            // - Good for learning & small examples
            // - NOT scalable for real applications

            IOrderRepository manualRepo = new SqlOrderRepository();
            var manualService = new OrderService(manualRepo);
            manualService.CreateOrder();

            Console.WriteLine("-----------------------------");

            // ================================
            // OPTION 2: DI Container (ASP.NET style)
            // ================================
            // - Scalable
            // - Manages lifetimes
            // - Used in real ASP.NET Core apps
            // - Infrastructure concern only

            var services = new ServiceCollection();

            services.AddScoped<IOrderRepository, SqlOrderRepository>();
            services.AddScoped<OrderService>();

            var provider = services.BuildServiceProvider();

            var containerService = provider.GetRequiredService<OrderService>();
            containerService.CreateOrder();
        }
    }
}
