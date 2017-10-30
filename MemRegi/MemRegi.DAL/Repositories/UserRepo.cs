using MemRegi.Entity.DBContext;
using MemRegi.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemRegi.DAL.Repositories
{
    public class UserRepo
    {
        public static User Users(User user)
        {
            using (MemRegiEntities db = new MemRegiEntities())
            {
                return db.User.FirstOrDefault
                    (a => a.UserName == user.UserName && a.Password == user.Password);  
            }
        }
    }
}
