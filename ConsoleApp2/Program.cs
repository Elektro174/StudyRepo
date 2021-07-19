
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

        static string relayState1;
        static string relayState2;
        static string relayState3;
        static string relayState4;

        static string SetDHT_t;
        static string SetDHT_h;
        static string SetSvet;
        static string SetTemperature;

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
            arduinoPort.DiscardInBuffer();



            Logger.Info("MyMessage");
            Console.ReadKey();

        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            int count = sp.BytesToRead;

            if (count == 37)
            {

                for (int i = 0; i < count; i++)
                {


                    char bt = (char)sp.ReadByte();
                    returnData = returnData + bt.ToString();


                }
               // string[] aray = { " ", " ", " ", " ", " ", "", "", "", "", "", "", "" };
                //new string[12];
               // aray = { " ", " ", " ", " ", " ", "", "", "", "", "", "", "" };
                Console.WriteLine(returnData.ToString());
                data = returnData.ToString();
               string[] aray = data.ToString().Split(new [] { ',' });
                var col = aray.Length;
                // if (col != 0)
                //  {
                //    if (aray[col - 1].ToString() != "")
                temperature = aray[col - 1].ToString();
                //    else
                //       temperature = "";




                //     if (col != 0)
                //     {


                //       if (aray[col - 2].ToString() != "")
                //       {
                svet = aray[col - 2].ToString();
                //       }
                //       else
                //       {
                //          svet = "";
                //       }


                //      if (aray[col - 3].ToString() != "")
                //      {
                dht_h = aray[col - 3].ToString();
                //      }
                //      else
                //     {
                //        dht_h = "";
                //     }

                //    }
                //    else
                //   {
                //       svet = "";
                //       dht_h = "";
                //   }

                //   if (aray[col - 4].ToString() != "")
                dht_t = aray[col - 4].ToString();
                //   else
                //      dht_t = "";

                SetTemperature = aray[col - 5].ToString();
                SetSvet = aray[col - 6].ToString();
                SetDHT_h = aray[col - 7].ToString();
                SetDHT_t = aray[col - 8].ToString();



                relayState4 = aray[col - 9].ToString();
                relayState3 = aray[col - 10].ToString();
                relayState2 = aray[col - 11].ToString();
                relayState1 = aray[col - 12].ToString();
                
                
                

                


                //}

                CultureInfo ciEnUs = new CultureInfo("en-us");

                DHT_t = Int32.Parse(dht_t);
                DHT_h = Int32.Parse(dht_h);
                Svet = Int32.Parse(svet);
                Temperature = double.Parse(temperature, ciEnUs);
                Console.WriteLine(DHT_t);
                Console.WriteLine(DHT_h);
                Console.WriteLine(Svet);
                Console.WriteLine(Temperature);

                Console.WriteLine(SetDHT_t);
                Console.WriteLine(SetDHT_h);
                Console.WriteLine(SetSvet);
                Console.WriteLine(SetTemperature);

                Console.WriteLine(relayState1);
                Console.WriteLine(relayState2);
                Console.WriteLine(relayState3);
                Console.WriteLine(relayState4);

                returnData = "";

                sp.DiscardInBuffer();
            }
        }
    }
}