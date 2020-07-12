using AutoMapper;

using dnd.inventory.api.Exceptions;
using dnd.inventory.api.Model;

using System;
using System.Collections.Generic;
using System.Linq;

namespace dnd.inventory.api.Repo
{
    public class ProductsRepo : IProductsRepo
    {
        private readonly List<Item> products = new List<Item>()
        {
        };

        private IMapper Mapper { get; }

        public ProductsRepo(IMapper mapper)
        {
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public IQueryable<Item> Get()
        {
            return products.Select(Mapper.Map<Item>).AsQueryable();
        }

        public void Create(Item p)
        {
            if (p == null)
                throw new ArgumentNullException(nameof(p));

            if (products.Any(x => x.Id == p.Id))
            {
                throw new DuplicateKeyException($"Can't create an object of a type {nameof(Item)} with the key '{p.Id}'. The object with the same key is already exists");
            }

            products.Add(Mapper.Map<Item>(p));
        }

        public void Delete(int id)
        {
            var p = products.FirstOrDefault(x => x.Id == id);
            if (p == null)
            {
                throw new KeyNotFoundException($"An object of a type '{nameof(Item)}' with the key '{id}' not found");
            }

            products.RemoveAll(x => x.Id == p.Id);
        }

        public void Update(Item p)
        {
            if (p == null)
                throw new ArgumentNullException(nameof(p));

            var stored = products.FirstOrDefault(x => x.Id == p.Id);
            if (stored == null)
            {
                throw new KeyNotFoundException($"An object of a type '{nameof(Item)}' with the key '{p.Id}' not found");
            }

            products.RemoveAll(x => x.Id == stored.Id);
            products.Add(Mapper.Map<Item>(p));
        }
    }
}
