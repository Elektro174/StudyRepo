using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Users")]
    public class User : EntityBase
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Column(TypeName = "NVARCHAR")]
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        [Column(TypeName = "NVARCHAR")]
        public string SecondName { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        [Column(TypeName = "NVARCHAR")]
        public string Login { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        [Column(TypeName = "NVARCHAR")]
        public string Pass { get; set; }
    }
}
