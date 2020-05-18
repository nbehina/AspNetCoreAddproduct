using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreAddproduct.Data;
using AspNetCoreAddproduct.Models;
using Microsoft.EntityFrameworkCore;
namespace AspNetCoreAddproduct.Services
{
    public class AddproductItemService : IAddproductItemService
    {
        private readonly ApplicationDbContext _context;
        public AddproductItemService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<AddproductItem[]> GetIncompleteItemsAsync()
        {
            return await _context.Items
            .Where(x => x.IsDone == false)
            .ToArrayAsync();
        }

        public async Task<bool> AddItemAsync(AddproductItem newItem)
        {
            newItem.Id = Guid.NewGuid();
            newItem.IsDone = false;
            newItem.DueAt = DateTimeOffset.Now.AddDays(3);
            _context.Items.Add(newItem);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }

    }
}

