using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Creator
    {
        [Key]
        public int CreatorId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
