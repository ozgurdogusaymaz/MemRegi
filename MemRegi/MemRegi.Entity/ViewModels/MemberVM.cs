using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemRegi.Entity.ViewModels
{
    public class MemberVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int MyProperty { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }
        public String Address { get; set; }
        public string Title { get; set; }
    }
}
