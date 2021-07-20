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
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int DHT11_t { get; set; }
        public int DHT11_h { get; set; }
        public int Svet { get; set; }

        [Column(TypeName = "DOUBLE")]
        public double Temperature { get; set; }
        public int SetDHT11_t { get; set; }
        public int SetDHT11_h { get; set; }
        public int SetSvet { get; set; }

        [Column(TypeName = "DOUBLE")]
        public double SetTemperature { get; set; }
        
        [Column(TypeName = "NVARCHAR")]
        public string relayState1 { get; set; }

        [Column(TypeName = "NVARCHAR")]
        public string relayState2 { get; set; }

        [Column(TypeName = "NVARCHAR")]
        public string relayState3 { get; set; }

        [Column(TypeName = "NVARCHAR")]
        public string relayState4 { get; set; }
    }
}
