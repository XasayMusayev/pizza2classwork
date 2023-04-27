using PizzaMizza.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.App.Services.Interfaces
{
    internal interface IPizzaService
    {
        Task CreateAsync();
        Task DeleteAsync();
        Task UpdateAsync();
        Task<Pizza> GetAsync();
        Task GetAll();
    }
}
