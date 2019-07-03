using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPractico
{
    public class Player
    {
        public int Id { get; set; }
        public String Name { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateOfBirth { get; set; }
        public int skillLevel { get; set; }
    }
}
