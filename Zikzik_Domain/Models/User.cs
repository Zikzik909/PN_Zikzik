using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zikzik_Domain.Models
{
    public class User
    {
        [Key]
        public Guid id { get; set; }
        public string User_name { get; set; }
        public int Name { get; set; }
        public int Age { get; set; }
        public string contry { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string About_me { get; set; }
    }
}
