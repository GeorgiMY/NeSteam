using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [PrimaryKey("GameCompanyId", "CreatorId")]
    public class GameCompanyCreator
    {
        [ForeignKey(nameof(GameCompanyInstance))]
        public int GameCompanyId { get; set; }
        public GameCompany GameCompanyInstance { get; set; }
        [ForeignKey(nameof(CreatorInstance))]
        public int CreatorId { get; set; }
        public Creator CreatorInstance { get; set; }
    }
}
