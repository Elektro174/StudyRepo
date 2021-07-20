using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EntityBase
    {
        [Key]
        [Index]
        public int Id { get; set; }
        public string CreationDate { get; set; }
    }
}
