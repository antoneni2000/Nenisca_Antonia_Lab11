using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nenisca_Antonia_Lab11;
using Nenisca_Antonia_Lab11.Models;

namespace Nenisca_Antonia_Lab11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item,. bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
