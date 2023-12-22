using CarSale.Application.Utils;
using CarSale.Domain.Entities.cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.DataAccess.Interfaces.Cars
{
    public interface ICarRepository : IRepository<Car, Car>
    {
        public Task<IList<Car>> SearchAsync(string search, PaginationParams @params);
        public Task<int> SearchCountAsync(string search);
        public Task<IList<Car>> GetUserAllPostAsync(long id, PaginationParams @params);
        public Task<Car> GetByIdJoin(long id);

    }

}
