using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IUserRep
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int UserId);
        void SaveUser(User achieve);
        void DeleteUser(User achieve);
    }
}
