using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection();
            serviceProvider.
                AddScoped<FizzBuzzServices, FizzBuzzAppServices>();
        }
    }
}
