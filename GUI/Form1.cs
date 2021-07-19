using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        string returnData = "";
        string data = "";
        string dht_t = "";
        string dht_h = "";
        string svet = "";
        string temperature = "";

        string relayState1 = "";
        string relayState2 = "";
        string relayState3 = "";
        string relayState4 = "";

        string SetDHT_t = "";
        string SetDHT_h = "";
        string SetSvet = "";
        string SetTemperature = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonUpdatePorts_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            ComboBoxPorts.Text = "";
            ComboBoxPorts.Items.Clear();
            if (ports.Length != 0)
            {
                ComboBoxPorts.Items.AddRange(ports);
                ComboBoxPorts.SelectedIndex = 0;

            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (ButtonConnect.Text == "Connect")
            {
                try
                {
                    serialPort.PortName = ComboBoxPorts.Text;
                    serialPort.Open();
                    timer1.Enabled = true;
                    ButtonConnect.Text = "Disconnect";             
                    ComboBoxPorts.Enabled = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("Connection error");
                }
            }
            else if (ButtonConnect.Text == "Disconnect")
            {
                serialPort.Close();
                ComboBoxPorts.Enabled = true;
                timer1.Enabled = false;
                ButtonConnect.Text = "Connect";
            }
        }



        public void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
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

                Console.WriteLine(returnData.ToString());
                data = returnData.ToString();
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

                returnData = "";
                sp.DiscardInBuffer();
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (data != "")
            {
                LableDHT11_t.Text = "Температура воздуха: " + dht_t + " °C";
                LableDHT11_h.Text = "Влажность воздуха: " + dht_h + " %";
                LableDS18B20.Text = "Внутренняя температура: " + temperature + " °C";
                LableLight.Text = "Освещённость: " + svet + " попугаев";

                LableDHT11_t_fixed.Text = "Температура переключения реле: " + SetDHT_t + " °C";
                LableDHT11_h_fixed.Text = "Влажность переключения реле: " + SetDHT_h + " %";
                LabelSvet_fixed.Text = "Попугаи переключения реле: " + SetSvet + " попугаев";
                LableTemperature_fixed.Text = "Внутренняя температура для переключения реле: " + SetTemperature + " °C";

                LableReleyStateDHT11_t.Text = "Состояние реле температуры: " + relayState1;
                LableReleyStateDHT11_h.Text = "Состояние реле влажности: " + relayState2;
                LableReleyStateTemperature.Text = "Состояние реле внутренней температуры: " + relayState3;
                LableReleyStateSvet.Text = "Состояние реле Освещённости: " + relayState4;
            }
        }
    }
}

