using AspNetCoreAddproduct.Models;
using System.Threading.Tasks;

namespace AspNetCoreAddproduct.Services
{
    public interface IAddproductItemService
    {
        Task<AddproductItem[]> GetIncompleteItemsAsync();

        Task<bool> AddItemAsync(AddproductItem newItem);

    }
}

