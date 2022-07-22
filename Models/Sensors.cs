using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Sensors")]
   public class Sensors : EntityBase
    {
        /// <summary>
        /// Id авторизованного пользователя
        /// </summary>
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        /// <summary>
        /// Температура с датчика DHT11
        /// </summary>
        public int TempDHT { get; set; }
        /// <summary>
        /// Влажность с датчика DHT11
        /// </summary>
        public int HumDHT { get; set; }
        /// <summary>
        /// Давление  датчика BMP280
        /// </summary>
        public int PressBMP { get; set; }
        /// <summary>
        /// Температура с датчика BMP280
        /// </summary>
        public double TempBMP { get; set; }

    }
}
