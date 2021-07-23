using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Models.ViewModels
{
    public class MainFormDataViewModel
    {
        public MainFormDataViewModel() { }

        public MainFormDataViewModel(string data)
        {
            string[] aray = data.ToString().Split(new[] { ',' });
            var col = aray.Length;
            
            temperature = aray[col - 1].ToString();

            svet = aray[col - 2].ToString();
            dht_h = aray[col - 3].ToString();
            dht_t = aray[col - 4].ToString();
            SetTemperature = aray[col - 5].ToString();
            SetSvet = aray[col - 6].ToString();
            SetDHT_h = aray[col - 7].ToString();
            SetDHT_t = aray[col - 8].ToString();
            relayState4 = aray[col - 9].ToString();
            relayState3 = aray[col - 10].ToString();
            relayState2 = aray[col - 11].ToString();
            relayState1 = aray[col - 12].ToString();

            if (relayState1 == "1")
                relayState1 = "Включено";
            else relayState1 = "Выключено";

            if (relayState2 == "1")
                relayState2 = "Включено";
            else relayState2 = "Выключено";

            if (relayState3 == "1")
                relayState3 = "Включено";
            else relayState3 = "Выключено";

            if (relayState4 == "1")
                relayState4 = "Включено";
            else relayState4 = "Выключено";
        }
        /// <summary>
        /// Получаемый пакет данных
        /// </summary>
        public string data { get; set; }
        /// <summary>
        /// Температура с датчика DHT11
        /// </summary>
        public string dht_t { get; set; }
        /// <summary>
        /// Влажность с датчика DHT11
        /// </summary>
        public string dht_h { get; set; }
        /// <summary>
        /// Освещённость
        /// </summary>
        public string svet { get; set; }
        /// <summary>
        /// Температура с датчика 18b20
        /// </summary>
        public string temperature { get; set; }
        /// <summary>
        /// Состояние реле 1
        /// </summary>
        public string relayState1 { get; set; }
        /// <summary>
        /// Состояние реле 2
        /// </summary>
        public string relayState2 { get; set; }
        /// <summary>
        /// Состояние реле 3
        /// </summary>
        public string relayState3 { get; set; }
        /// <summary>
        /// Состояние реле 4
        /// </summary>
        public string relayState4 { get; set; }
        /// <summary>
        /// Температура переключения реле по датчику DHT11
        /// </summary>
        public string SetDHT_t { get; set; }
        /// <summary>
        /// Влажность переключения реле по датчику DHT11
        /// </summary>
        public string SetDHT_h { get; set; }
        /// <summary>
        /// Освещённость переключения реле по фоторезистору
        /// </summary>
        public string SetSvet { get; set; }
        /// <summary>
        /// Температура переключения реле по датчику 18b20
        /// </summary>
        public string SetTemperature { get; set; }
    }
}
