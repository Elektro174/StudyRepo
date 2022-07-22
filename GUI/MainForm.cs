using Castle.Windsor;
using GUI.Models.ViewModels;
using Models;
using System;
using System.Globalization;
using System.IO.Ports;
using System.Windows.Forms;
using Service.Interfaces;

namespace GUI
{
    public partial class MainForm : Form
    {
        Timer timer;
        decimal x;
        WindsorContainer _container;
        private string data = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object s, EventArgs e)
        {
            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
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
            if (count == 13)
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
                   LableTempDHT.Text = "Температура воздуха: " + model.TempDHT + " °C";
                   LableHumDHT.Text = "Влажность воздуха: " + model.HumDHT + " %";
                   TempBMP.Text = "Внутренняя температура: " + model.TempBMP + " °C";
                   PressBMP.Text = "Давление: " + model.PressBMP + " мм рт. ст.";

               });

                returnData = "";
                sp.DiscardInBuffer();
            }
        }

        private void ButtonWriteDataToDb_Click(object sender, EventArgs e)
        {           
            _container = Bootstrap.BuildContainer();
            ISensorService sensorSerrvicee = _container.Resolve<ISensorService>();
            MainFormDataViewModel measurement = new MainFormDataViewModel(data);
            Sensors sensor = new Sensors();
            sensor.CreationDate = DateTime.Now.ToString();
            sensor.UserId = SingInDataViewModel.CurrentUserId;
            sensor.TempDHT = Convert.ToInt32(measurement.TempDHT);
            sensor.HumDHT = Convert.ToInt32(measurement.HumDHT);
            sensor.PressBMP = Convert.ToInt32(measurement.PressBMP);
            sensor.TempBMP = double.Parse(measurement.TempBMP, CultureInfo.InvariantCulture);

            sensorSerrvicee.Create(sensor);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            MainFormDataViewModel model = new MainFormDataViewModel(data);
            chart1.Series[0].Points.AddXY(x, model.HumDHT);
            chart1.Series[1].Points.AddXY(x, model.TempDHT);
            chart1.Series[2].Points.AddXY(x, model.TempBMP);

            if (chart1.Series[0].Points.Count > 10)
                chart1.Series[0].Points.RemoveAt(0);
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[1].BorderWidth = 3;
            chart1.Series[2].BorderWidth = 3;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = (double)x;

            x = x + (decimal)1;
        }

        private void RunChart_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Stop();
            else timer.Start();
        }
    }
}

