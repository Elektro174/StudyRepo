using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class EntityBase
    {
        /// <summary>
        /// Id 
        /// </summary>
        [Key]
        [Index]
        public int Id { get; set; }
        /// <summary>
        /// Дата создания записи
        /// </summary>
        public string CreationDate { get; set; }

    }
}
