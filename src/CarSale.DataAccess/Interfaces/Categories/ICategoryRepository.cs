using CarSale.Application.Utils;
using CarSale.Domain.Entities.categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.DataAccess.Interfaces.Categories
{
    public interface ICategoryRepistory : IRepository<Cateogory, Cateogory>
    {
        public Task<IList<CarViewModel>> GetPostsByCategory(long category, PaginationParams @params);
    }
}
