using GUI.Models.ViewModels;
using Models;
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
        

        public Form1()
        {
            InitializeComponent();
            CultureInfo ciEnUs = new CultureInfo("en-us");

            MainFormDataViewModel measurement = new MainFormDataViewModel();

            CollectedData collectedData = new CollectedData();
            collectedData.Id = 1;
            collectedData.CreationDate = DateTime.Now.ToString();
            collectedData.DHT11_t = Int32.Parse(measurement.dht_t);
            collectedData.DHT11_h = Int32.Parse(measurement.dht_h);
            collectedData.Svet = Int32.Parse(measurement.svet);
            collectedData.Temperature = Double.Parse(measurement.temperature);

            collectedData.SetDHT11_t = Int32.Parse(measurement.SetDHT_t);
            collectedData.SetDHT11_h = Int32.Parse(measurement.SetDHT_h);
            collectedData.SetSvet = Int32.Parse(measurement.SetSvet);
            collectedData.SetTemperature = Double.Parse(measurement.SetTemperature);

            collectedData.relayState1 = measurement.relayState1;
            collectedData.relayState2 = measurement.relayState2;
            collectedData.relayState3 = measurement.relayState3;
            collectedData.relayState4 = measurement.relayState4;
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

                MainFormDataViewModel model = new MainFormDataViewModel(data);

                this.Invoke((MethodInvoker)delegate
               {


                   LableDHT11_t.Text = "Температура воздуха: " + model.dht_t + " °C";
                   LableDHT11_h.Text = "Влажность воздуха: " + model.dht_h + " %";
                   LableDS18B20.Text = "Внутренняя температура: " + model.temperature + " °C";
                   LableLight.Text = "Освещённость: " + model.svet + " попугаев";

                   LableDHT11_t_fixed.Text = "Температура переключения реле: " + model.SetDHT_t + " °C";
                   LableDHT11_h_fixed.Text = "Влажность переключения реле: " + model.SetDHT_h + " %";
                   LabelSvet_fixed.Text = "Попугаи переключения реле: " + model.SetSvet + " попугаев";
                   LableTemperature_fixed.Text = "Внутренняя температура для переключения реле: " + model.SetTemperature + " °C";

                   LableReleyStateDHT11_t.Text = "Состояние реле температуры: " + model.relayState1;
                   LableReleyStateDHT11_h.Text = "Состояние реле влажности: " + model.relayState2;
                   LableReleyStateTemperature.Text = "Состояние реле внутренней температуры: " + model.relayState3;
                   LableReleyStateSvet.Text = "Состояние реле Освещённости: " + model.relayState4;

               });

                returnData = "";
                sp.DiscardInBuffer();
            }


        }


    }
}

