using MemRegi.DAL.Repositories;
using MemRegi.Entity.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemRegi.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (MemRegiEntities db = new MemRegiEntities())
            //{
            //    var result = db.Member.ToList();
            //}

            var result = MemberRepo.GetAll();
        }
    }
}
