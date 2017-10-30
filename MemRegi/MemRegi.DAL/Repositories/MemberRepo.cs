using MemRegi.Entity.DBContext;
using MemRegi.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemRegi.DAL.Repositories
{
    public class MemberRepo
    {
        public static List<Member> GetAll()
        {
            using (MemRegiEntities db = new MemRegiEntities())
            {
                return db.Member.ToList();
            }
        }

        public static void Add(Member member)
        {
            using (MemRegiEntities db = new MemRegiEntities())
            {
                db.Member.Add(member);
                db.SaveChanges();
            }
        }
    }
}
