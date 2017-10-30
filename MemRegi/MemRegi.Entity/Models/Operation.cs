using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemRegi.Entity.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MemberId { get; set; }
        public string Description { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
        public virtual Member Member { get; set; }
    }
}
