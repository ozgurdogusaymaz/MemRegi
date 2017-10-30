using MemRegi.Entity.DBContext;
using MemRegi.Entity.Models;
using MemRegi.Entity.ViewModels;
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
        public static List<MemberVM> GetAllMemberVM()
        {
            using (MemRegiEntities db = new MemRegiEntities())
            {
                return db.Member.Select(p => new MemberVM
                {
                    Id = p.Id,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Phone = p.Phone,
                    Email = p.Email,
                    MyProperty = p.MyProperty,
                    DateOfBirth = p.DateOfBirth,
                    Address = p.Address,
                    Title = p.Title
                }).ToList();
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


