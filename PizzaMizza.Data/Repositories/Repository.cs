using PizzaMizza.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Data.Repositories
{
    public class Repository<T> where T :BaseModel
    {
        private readonly List<T> _items=new List<T>();


        public async Task CreateAsync(T item)
        {
            _items.Add(item);
        }

        public async Task DeleteAsync(T item)
        {
            _items.Remove(item);
        }

        public async Task UpdateAsync(T item)
        {
            _items.Remove(item);
        }

        public async Task<T> GetAsync(int id)
        {
            foreach (T item in _items)
            {
                if (item.Id==id)
                {
                    return item;
                }
            }
              return null;
        }


        public async Task<List<T>> GetAllAsync()
        {
            return _items;
        }

         
    }
}
