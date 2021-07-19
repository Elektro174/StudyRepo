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
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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



        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string returnData = "";
            string data;
            string dht_t = "";
            string dht_h = "";
            string svet = "";
            string temperature = "";

            int DHT_t;
            int DHT_h;
            int Svet;
            double Temperature;

            SerialPort sp = (SerialPort)sender;

            int count = sp.BytesToRead;

            if (count == 16)
            {

                for (int i = 0; i < count; i++)
                {


                    char bt = (char)sp.ReadByte();
                    returnData = returnData + bt.ToString();


                }

                Console.WriteLine(returnData.ToString());
                data = returnData.ToString();
                var array = data.ToString().Split(new[] { ',' });
                var col = array.Length;
                if (col != 0)
                {
                    if (array[col - 1].ToString() != "")
                        temperature = array[col - 1].ToString();
                    else
                        temperature = "";




                    if (col != 0)
                    {


                        if (array[col - 2].ToString() != "")
                        {
                            svet = array[col - 2].ToString();
                        }
                        else
                        {
                            svet = "";
                        }


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

                    if (array[col - 4].ToString() != "")
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

                sp.DiscardInBuffer();
            }

            LableDHT11_t.Text = "Температура воздуха: " + dht_t + " градусов";
            LableDHT11_h.Text = "Влажность воздуха: " + dht_h + " %";
            LableDS18B20.Text = "Температура почвы: " + temperature + " градусов";
            LableLight.Text = "Освещённость: " + svet + " попугаев";

        }

        
        
        

     
        

        
    }
}

