using NLog;
using System;
using System.IO.Ports;

namespace ConsoleTestApp
{ 
    public class Program
    {
        static string returnData = "";
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

            if (count > 0) // Если количество байт на входе больше 0
            {
                // string text = sp.ReadLine();
                // Console.WriteLine(text);
                for (int i = 0; i < count; ++i)
                {
                    char bt = (char)sp.ReadByte();
                    returnData = returnData + bt.ToString();
                    
                }
                Console.WriteLine(returnData.ToString());
                //  byte[] data = new byte[count]; // Создается массив байт
                //  sp.Read(data, 0, data.Length); // Считываются данные в созданный массив
                //  bool voltage = BitConverter.ToBoolean(data, 0);
                //   Console.WriteLine(voltage); // Выводится в консоль номер элемента
                // Console.WriteLine((data[0] & 0XFF) | ((data[1] & 0XFF) << 8));
                sp.DiscardInBuffer();
            }
}   }   }