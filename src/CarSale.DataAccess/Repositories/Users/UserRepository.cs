using CarSale.Application.Utils;
using CarSale.DataAccess.Interfaces.Users;
using CarSale.Domain.Entities.users;
using Dapper;

namespace CarSale.DataAccess.Repositories.Users
{
    public class UserRepository : BaseRepository,IUserRepository
    {
        public async Task<long> CountAsync()
        {
            //throw new NotImplementedException();
            try
            {
                await _connection.OpenAsync();
                string query = "select * from users";
                var res = await _connection.QuerySingleAsync<long>(query);

                return res;
            }
            catch
            {

                return 0;
            }
            finally
            {
                await   _connection.CloseAsync();
            }
            

        }

        public async Task<int> CreateAsync(User entity)
        {
            try
            {
                await _connection.OpenAsync();
                string query = "insert into public.users(first_name, last_name, phone_number, " +
                    "password_hash, salt, created_at, updated_at) Values (@FirstName, @LastName, @PhoneNumber, @PasswordHash, @Salt, @CreatedAt, @UpdatedAt);";
                return await _connection.ExecuteAsync(query, entity);
            }
            catch
            {
                return 0;
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async Task<int> DeleteAsync(long id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = "delete from users where id=@Id";
                var res = await _connection.ExecuteAsync(query, new {Id = id});
                return res;
            }
            catch { return 0; }
            finally { await _connection.CloseAsync(); }
           
        }

        public async Task<IList<User>> GetAllAsync(PaginationParams @params)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"select * from public.users order by id desc offset {@params.GetSkipCount()}" +
                    $"limit {@params.PageSize}";
                var res = (await _connection.QueryAsync<User>(query)).ToList();

                return res;

            }
            catch
            {
                return new List<User>();
            }
            finally
            {
                await _connection.CloseAsync(); 
            }
        }

        public  Task<IList<User>> GetALlPostByUserId(long userId)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetByIdAsync(long id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"select * from users where id = @Id";
                var res = await _connection.QuerySingleAsync<User>(query, new { Id = id });

                return res;
            }
            catch
            {
                return null;
            }
            finally
            {
                await _connection.CloseAsync(); 
            }
        }

        public async Task<User?> GetByPhoneAsync(string phone)
        {
            //throw new NotImplementedException();
            try
            {
                await _connection.OpenAsync();
                string query = "select * from public.users where phone_number=@PhoneNumber;";
                var result = await _connection.QueryFirstOrDefaultAsync<User>(query, new { PhoneNumber = phone });
                return result;
            }
            catch
            {
                return null;
            }
            finally
            {
                await _connection.CloseAsync();
            }
            

        }

        public Task<int> SearchCountAsync(string search)
        {
            throw new NotImplementedException();
        }

        public Task<IList<User>> SearchUserAsync(string search, PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateAsync(long id, User user)
        {
            //throw new NotImplementedException();
            try
            {
                await _connection.OpenAsync();
                string query = $"UPDATE public.users set first_name = @FirstName, last_name = @LastName, phone_number = @PhoneNumber, updated_at = @UpdatedAt where id = @Id";

                var res = await _connection.ExecuteAsync(query, new { Id = id });
                return res;
            }
            catch
            {
                return 0;
            }
            finally
            {
                await _connection.CloseAsync();
            }


        }
    }
}
