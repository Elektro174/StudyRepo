using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("CollectedData")]
   public class CollectedData : EntityBase
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
        public int DHT11_t { get; set; }
        /// <summary>
        /// Влажность с датчика DHT11
        /// </summary>
        public int DHT11_h { get; set; }
        /// <summary>
        /// Освещённость
        /// </summary>
        public int Svet { get; set; }
        /// <summary>
        /// Температура с датчика 18b20
        /// </summary>
        public double Temperature { get; set; }
        /// <summary>
        /// Температура переключения реле по датчику DHT11
        /// </summary>
        public int SetDHT11_t { get; set; }
        /// <summary>
        /// Влажность переключения реле по датчику DHT11
        /// </summary>
        public int SetDHT11_h { get; set; }
        /// <summary>
        /// Освещённость переключения реле по фоторезистору
        /// </summary>
        public int SetSvet { get; set; }
        /// <summary>
        /// Температура переключения реле по датчику 18b20
        /// </summary>
        public double SetTemperature { get; set; }
        /// <summary>
        /// Состояние реле 1
        /// </summary>
        [Column(TypeName = "NVARCHAR")]
        public string relayState1 { get; set; }
        /// <summary>
        /// Состояние реле 2
        /// </summary>
        [Column(TypeName = "NVARCHAR")]
        public string relayState2 { get; set; }
        /// <summary>
        /// Состояние реле 3
        /// </summary>
        [Column(TypeName = "NVARCHAR")]
        public string relayState3 { get; set; }
        /// <summary>
        /// Состояние реле 4
        /// </summary>
        [Column(TypeName = "NVARCHAR")]
        public string relayState4 { get; set; }
    }
}
