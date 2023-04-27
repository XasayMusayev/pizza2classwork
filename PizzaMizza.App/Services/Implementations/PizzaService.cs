using PizzaMizza.App.Services.Interfaces;
using PizzaMizza.Core.Enum;
using PizzaMizza.Core.Models;
using PizzaMizza.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.App.Services.Implementations
{
    internal class PizzaService:IPizzaService
    {
        private readonly PizzaRepository _pizzas = new PizzaRepository();

        public async Task CreateAsync()
        {
            Pizza pizza = new Pizza();
            Console.WriteLine("Add name");
            string name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Add name*");
                name = Console.ReadLine();
            }
            pizza.Name = name;

            Console.WriteLine("Add price");
            double.TryParse(Console.ReadLine(), out double price);
            while (price <= 0)
            {
                Console.WriteLine("Salary not true");
                Console.WriteLine("Add price*");
                double.TryParse(Console.ReadLine(), out price);
            }

            pizza.Price = price;


        Again:
            Console.WriteLine("-Add size-");
            Console.WriteLine("1. " + Size.Small);
            Console.WriteLine("2. " + Size.Medium);
            Console.WriteLine("3. " + Size.Big);

            string result = Console.ReadLine();
            Size size;

            switch (result)
            {
                case "1":
                    size = Size.Small;
                    break;
                case "2":
                    size = Size.Medium;
                    break;
                case "3":
                    size = Size.Big;
                    break;
                default:
                    Console.WriteLine("Add valid option*");
                    goto Again;

            }
            pizza.Size = size;


            _pizzas.CreateAsync(pizza);


        }

        public async Task DeleteAsync()
        {
            Console.WriteLine("Add id");
            int.TryParse(Console.ReadLine(), out int id);

            Pizza pizza =await _pizzas.GetAsync(id);

            if (pizza == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                await _pizzas.DeleteAsync(pizza);
            }
        }

        public async Task GetAll()
        {
            List<Pizza> pizzas = await _pizzas.GetAllAsync();
            foreach (var item in pizzas)
            {
                Console.WriteLine(item);
            }
        }

        public async Task GetAsync()
        {
            Console.WriteLine("Add id");
            int.TryParse(Console.ReadLine(), out int id);
            Pizza pizza =await _pizzas.GetAsync(id);

            if (pizza == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                Console.WriteLine(pizza);
            }
        }

        public async Task UpdateAsync()
        {
            
        }
    }

    }

