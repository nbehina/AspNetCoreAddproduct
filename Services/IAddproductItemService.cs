using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreAddproduct.Models;
namespace AspNetCoreAddproduct.Services
{
    public interface IAddproductItemService
    {
        Task<AddproductItem[]> GetIncompleteItemsAsync();
        Task<bool> AddItemAsync(AddproductItem newItem);
    }
}
