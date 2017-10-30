namespace MemRegi.Entity.DBContext
{
    using MemRegi.Entity.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class MemRegiEntities : DbContext
    {
        public MemRegiEntities()
            : base("name=MemRegiDB")
        {
            Database.SetInitializer(new MemRegiDBInitializer());
        }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Operation> Operation { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Role> Role { get; set; }
    }
    public class MemRegiDBInitializer : CreateDatabaseIfNotExists<MemRegiEntities>
    {
        protected override void Seed(MemRegiEntities db)
        {
            db.Role.AddRange(new List<Role>()
            {
                new Role() { Name = "Baþkan"},
                new Role() { Name = "Sekreter" },
                new Role() { Name = "Sayman"},
            });
            db.User.Add(new User()
            {
                UserName = "admin",
                Password = "1234"
            });
            db.SaveChanges();
        }
    }


}