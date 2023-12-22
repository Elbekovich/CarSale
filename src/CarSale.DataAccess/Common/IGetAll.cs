using CarSale.Application.Utils;

namespace CarSale.DataAccess.Common
{
    public interface IGetAll<TModel>
    {
        public Task<IList<TModel>> GetAllAsync(PaginationParams @params);
    }
}
