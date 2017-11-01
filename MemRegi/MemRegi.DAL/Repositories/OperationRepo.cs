using MemRegi.Entity.DBContext;
using MemRegi.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemRegi.DAL.Repositories
{
    public class OperationRepo
    {
        public static void Add(Operation model)
        {
            using (MemRegiEntities db = new MemRegiEntities())
            {
                db.Operation.Add(model);
                db.SaveChanges();
            }
        }
    }
}
