namespace GUI.Models.ViewModels
{
    public class MainFormDataViewModel
    {
        public MainFormDataViewModel() { }

        public MainFormDataViewModel(string data)
        {
            string[] aray = data.ToString().Split(new[] { ';' });
            var col = aray.Length;
            
            TempDHT = aray[col - 5].ToString();

            HumDHT = aray[col - 4].ToString();
            PressBMP = aray[col - 3].ToString();
            TempBMP = aray[col - 2].ToString();
        }
        /// <summary>
        /// Получаемый пакет данных
        /// </summary>
        public string data { get; set; }
        /// <summary>
        /// Температура с датчика DHT11
        /// </summary>
        public string TempDHT { get; set; }
        /// <summary>
        /// Влажность с датчика DHT11
        /// </summary>
        public string HumDHT { get; set; }
        /// <summary>
        /// Давление с датчика BMP280
        /// </summary>
        public string PressBMP { get; set; }
        /// <summary>
        /// Температура с датчика BMP280
        /// </summary>
        public string TempBMP { get; set; }
       
    }
}
