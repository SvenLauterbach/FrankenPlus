using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franken_.Model.Entities
{
    public class UsedImage
    {
        [Key]
        public int ID { get; set; }

        public string ImageId { get; set; }

        public int Count { get; set; }
    }
}
