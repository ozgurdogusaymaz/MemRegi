using MemRegi.Entity.DBContext;
using MemRegi.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemRegi.DAL.Repositories
{
    public class RoleRepo
    {
        public static List<Role> GetAll()
        {
            using (MemRegiEntities db = new MemRegiEntities())
            {
                return db.Role.ToList();
            }

        }
        public static bool Add(Role r)
        {
            using (MemRegiEntities db = new MemRegiEntities())
            {
                var result = db.Role.FirstOrDefault(p => p.Name.ToLower() == r.Name.ToLower());

                if(result==null)
                {
                    db.Role.Add(r);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
                
            
        }
    }
}
