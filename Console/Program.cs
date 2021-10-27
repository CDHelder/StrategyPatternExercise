using Domain;
using Domain.Strategy;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<ITravelStrategy, BikeStrategy>()
                .AddScoped<ITravelStrategy, CarStrategy>()
                .AddScoped<ITravelStrategy, WalkingStrategy>();

            var service1 = new TravelTimeCalculator(new BikeStrategy());
            var time1 = service1.CalculateTravelTime(50);
            System.Console.WriteLine($"Bike: Distance({50}), Time({time1}min)");
            System.Console.WriteLine();

            var service2 = new TravelTimeCalculator(new CarStrategy());
            var time2 = service2.CalculateTravelTime(50);
            System.Console.WriteLine($"Car: Distance({50}), Time({time2}min)");
            System.Console.WriteLine();

            var service3 = new TravelTimeCalculator(new WalkingStrategy());
            var time3 = service3.CalculateTravelTime(50);
            System.Console.WriteLine($"Walking: Distance({50}), Time({time3}min)");

            System.Console.ReadLine();
        }
    }
}
