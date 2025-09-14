using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zikzik_Domain.Models
{
    internal class Work
    {
        [Key]
        public Guid id { get; set; }
        public string Name_Corporations { get; set; }
        public string Requirements { get; set; }
        public string Terms { get; set; }
        public string Experience { get; set; }
    }
}
