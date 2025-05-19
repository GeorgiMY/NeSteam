using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class GameCompany
    {
        [Key]
        public int GameCompanyId { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
