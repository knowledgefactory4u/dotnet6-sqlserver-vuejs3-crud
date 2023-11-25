namespace WebApi.Services;

using WebApi.Entities;
using WebApi.Models.Users;

public interface IUserService
{
    IEnumerable<User> GetAll(string filter);
    User GetById(int id);
    void Create(CreateRequest model);
    void Update(int id, UpdateRequest model);
    void Delete(int id);
}

