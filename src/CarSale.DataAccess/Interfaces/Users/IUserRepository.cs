using CarSale.Application.Utils;
using CarSale.DataAccess.Common;
using CarSale.Domain.Entities;
using CarSale.Domain.Entities.users;

namespace CarSale.DataAccess.Interfaces.Users;

public interface IUserRepository : IRepository<User, User>, IGetAll<User>
{
    public Task<User?> GetByPhoneAsync(string phone);
    Task<int> UpdateAsync(long id, User user);
    public Task<IList<User>> SearchUserAsync(string search, PaginationParams @params);
    public Task<int> SearchCountAsync(string search);
    public Task<IList<User>> GetALlPostByUserId(long userId);

}
