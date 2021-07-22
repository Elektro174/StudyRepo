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

        public string data { get; set; }
        public string dht_t { get; set; }
        public string dht_h { get; set; }
        public string svet { get; set; }
        public string temperature { get; set; }

        public string relayState1 { get; set; }
        public string relayState2 { get; set; }
        public string relayState3 { get; set; }
        public string relayState4 { get; set; }

        public string SetDHT_t { get; set; }
        public string SetDHT_h { get; set; }
        public string SetSvet { get; set; }
        public string SetTemperature { get; set; }
    }
}
