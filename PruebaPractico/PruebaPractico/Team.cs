using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPractico
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public String City { get; set; }
        public int FoundationalYear{ get; set; }
        public List<Player> Players { get; set; }
    }
}
