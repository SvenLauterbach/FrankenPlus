using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franken_.Model.Entities
{
    public class Statistic
    {
        [Key]
        public int ID { get; set; }

        public DateTime Run { get; set; }

        public string Glyph { get; set; }

        public virtual List<UsedImage> UsedImages { get; set; } 
    }
}
