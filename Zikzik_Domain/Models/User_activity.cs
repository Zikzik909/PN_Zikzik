using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zikzik_Domain.Models
{
    internal class User_activity
    {
        [Key]
        public Guid id { get; set; }
        public string Start_data { get; set; }
        public string End_Data { get; set; }
        public string List_of_responses { get; set; }
    }
}
