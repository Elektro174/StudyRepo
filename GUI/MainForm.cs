using Data;
using GUI.Models.ViewModels;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {

        private string data = "";

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
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


            SerialPort sp = (SerialPort)sender;

            int count = sp.BytesToRead;

            if (count == 36)
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

        private void ButtonWriteDataToDb_Click(object sender, EventArgs e)
        {
            //CultureInfo ciEnUs = new CultureInfo("en-us");

            MainFormDataViewModel measurement = new MainFormDataViewModel(data);

            User user = new User();
            user.FirstName = "Глеб";
            user.SecondName = "Никифоров";
            user.CreationDate = DateTime.Now.ToString();
            user.Id = 1;

            CollectedData collectedData = new CollectedData();
            collectedData.Id = 1;
            collectedData.CreationDate = DateTime.Now.ToString();
            collectedData.DHT11_t = Convert.ToInt32(measurement.dht_t);
            collectedData.DHT11_h = Convert.ToInt32(measurement.dht_h);
            collectedData.Svet = Convert.ToInt32(measurement.svet);
            collectedData.Temperature = double.Parse(measurement.temperature, CultureInfo.InvariantCulture);

            collectedData.SetDHT11_t = Convert.ToInt32(measurement.SetDHT_t);
            collectedData.SetDHT11_h = Convert.ToInt32(measurement.SetDHT_h);
            collectedData.SetSvet = Convert.ToInt32(measurement.SetSvet);
            collectedData.SetTemperature = double.Parse(measurement.SetTemperature, CultureInfo.InvariantCulture);

            collectedData.relayState1 = measurement.relayState1;
            collectedData.relayState2 = measurement.relayState2;
            collectedData.relayState3 = measurement.relayState3;
            collectedData.relayState4 = measurement.relayState4;

            PracticeDbContext context = new PracticeDbContext();
            CollectedDataRepository collectedDataRepository = new CollectedDataRepository(context);
            UnitOfWork unitOfWork = new UnitOfWork(context);
            UsersRepository usersRepository = new UsersRepository(context);


            collectedDataRepository.Create(collectedData);
            usersRepository.Delete(user);
            //usersRepository.DeleteAll(user => true);
            unitOfWork.Save();
        }
    }
}

