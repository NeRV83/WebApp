using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EFUserRep : IUserRep
    {
        private EFDBContext context;
        public EFUserRep(EFDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.User.ToList();
        }

        public User GetUserById(int UserId)
        {
            return context.User.FirstOrDefault(x => x.UserId == UserId);
        }

        public void SaveUser(User User)
        {
            if (User.UserId == 0)
                context.User.Add(User);
            else
                context.Entry(User).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteUser(User User)
        {
            context.User.Remove(User);
            context.SaveChanges();
        }
    }
}
