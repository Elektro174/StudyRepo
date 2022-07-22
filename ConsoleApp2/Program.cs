
using NLog;
using System;
using System.Globalization;
using System.IO.Ports;

namespace ConsoleTestApp
{
    public class Program
    {
        


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
        }
    }
}