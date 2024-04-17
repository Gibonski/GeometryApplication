using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using GeometryLib;


namespace GeometryConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var featureManagement = new Dictionary<string, string> {
                { "FeatureManagement:Square", "true" },
                { "FeatureManagement:Rectangle", "true" },
                { "FeatureManagement:Triangle", "true" }
            };

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(featureManagement)
                .Build();

            var services = new ServiceCollection();
            services.AddFeatureManagement(configuration);
            services.AddTransient<IShape, Square>();
            services.AddTransient<IShape, Rectangle>();
            services.AddTransient<IShape, Triangle>();
            var serviceProvider = services.BuildServiceProvider();

            var featureManager = serviceProvider.GetRequiredService<IFeatureManagerSnapshot>();

            // Access to shapes 
            if (await featureManager.IsEnabledAsync("Square"))
            {
                var square = serviceProvider.GetRequiredService<Square>();
                Console.WriteLine($"Square Area: {square.CalculateArea()}, Perimeter: {square.CalculatePerimeter()}");
            }

            if (await featureManager.IsEnabledAsync("Rectangle"))
            {
                var rectangle = serviceProvider.GetRequiredService<Rectangle>();
                Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}");
            }

            if (await featureManager.IsEnabledAsync("Triangle"))
            {
                var triangle = serviceProvider.GetRequiredService<Triangle>();
                Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}, Perimeter: {triangle.CalculatePerimeter()}");
            }

            
        }
    }
}
