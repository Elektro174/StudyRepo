using NLog;
using System;
using System.Globalization;
using System.IO.Ports;

namespace ConsoleTestApp
{ 
    public class Program
    {
        static string returnData = "";
        static string data;
        static string dht_t;
        static string dht_h;
        static string svet;
        static string temperature;

        static int DHT_t;
        static int DHT_h;
        static int Svet;
        static double Temperature;


        static Logger Logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            SerialPort arduinoPort = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            arduinoPort.DataReceived += DataReceivedHandler;
            arduinoPort.Open();
            arduinoPort .DiscardInBuffer();



            Logger.Info("MyMessage");
            Console.ReadKey();

        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender; // Получение доступа к созданному последовательному порту

            int count = sp.BytesToRead; // Получение количества байт на входе последовательного порта

            if (count == 16) // Если количество байт на входе больше 0
            {
                // string text = sp.ReadLine();
                // Console.WriteLine(text);
                for (int i = 0; i < count; i++)
                {

                    
                    char bt = (char)sp.ReadByte();
                    returnData = returnData + bt.ToString();
                   

                }
                
                Console.WriteLine(returnData.ToString());
                data = returnData.ToString();
                var array = Program.data.ToString().Split(new[] { ',' });
                var col = array.Length;
                if (col != 0)
                {
                    if (array[col - 1].ToString() != "") // Country
                        temperature = array[col - 1].ToString();
                    else
                        temperature = "";


                   // var sTemp = array[col - 2].ToString().Split(new[] { ' ' });
                   // var col1 = sTemp.Length;

                    if (col != 0)
                    {

                        // PostalCode
                        if (array[col - 2].ToString() != "")
                        {
                            svet = array[col - 2].ToString();
                        }
                        else
                        {
                            svet = "";
                        }

                        //State Name
                        if (array[col - 3].ToString() != "")
                        {
                            dht_h = array[col - 3].ToString();
                        }
                        else
                        {
                            dht_h = "";
                        }

                    }
                    else
                    {
                        svet = "";
                        dht_h = "";
                    }

                    if (array[col - 4].ToString() != "") // City
                        dht_t = array[col - 4].ToString();
                    else
                        dht_t = "";

                    

                }

                CultureInfo ciEnUs = new CultureInfo("en-us");

                DHT_t = Int32.Parse(dht_t);
                DHT_h = Int32.Parse(dht_h);
                Svet = Int32.Parse(svet);
                Temperature = double.Parse(temperature, ciEnUs);
                Console.WriteLine(DHT_t);
                Console.WriteLine(DHT_h);
                Console.WriteLine(Svet);
                Console.WriteLine(Temperature);

                returnData = "";
                //  byte[] data = new byte[count]; // Создается массив байт
                //  sp.Read(data, 0, data.Length); // Считываются данные в созданный массив
                //  bool voltage = BitConverter.ToBoolean(data, 0);
                //   Console.WriteLine(voltage); // Выводится в консоль номер элемента
                // Console.WriteLine((data[0] & 0XFF) | ((data[1] & 0XFF) << 8));
                sp.DiscardInBuffer();
            }
}   }   }