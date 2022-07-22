
namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LableTempDHT = new System.Windows.Forms.Label();
            this.LableHumDHT = new System.Windows.Forms.Label();
            this.PressBMP = new System.Windows.Forms.Label();
            this.TempBMP = new System.Windows.Forms.Label();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonUpdatePorts = new System.Windows.Forms.Button();
            this.ComboBoxPorts = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.ButtonWriteDataToDb = new System.Windows.Forms.Button();
            this.RunChart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LableTempDHT
            // 
            this.LableTempDHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableTempDHT.Location = new System.Drawing.Point(22, 191);
            this.LableTempDHT.Name = "LableTempDHT";
            this.LableTempDHT.Size = new System.Drawing.Size(334, 49);
            this.LableTempDHT.TabIndex = 0;
            this.LableTempDHT.Text = "TempDHT";
            this.LableTempDHT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableHumDHT
            // 
            this.LableHumDHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableHumDHT.Location = new System.Drawing.Point(22, 258);
            this.LableHumDHT.Name = "LableHumDHT";
            this.LableHumDHT.Size = new System.Drawing.Size(334, 50);
            this.LableHumDHT.TabIndex = 1;
            this.LableHumDHT.Text = "HumDHT";
            this.LableHumDHT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PressBMP
            // 
            this.PressBMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PressBMP.Location = new System.Drawing.Point(22, 323);
            this.PressBMP.Name = "PressBMP";
            this.PressBMP.Size = new System.Drawing.Size(334, 36);
            this.PressBMP.TabIndex = 2;
            this.PressBMP.Text = "PressBMP";
            this.PressBMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TempBMP
            // 
            this.TempBMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TempBMP.Location = new System.Drawing.Point(22, 359);
            this.TempBMP.Name = "TempBMP";
            this.TempBMP.Size = new System.Drawing.Size(334, 69);
            this.TempBMP.TabIndex = 3;
            this.TempBMP.Text = "TempBMP";
            this.TempBMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonConnect.Location = new System.Drawing.Point(450, 12);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(207, 68);
            this.ButtonConnect.TabIndex = 8;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = false;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonUpdatePorts
            // 
            this.ButtonUpdatePorts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonUpdatePorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUpdatePorts.Location = new System.Drawing.Point(987, 12);
            this.ButtonUpdatePorts.Name = "ButtonUpdatePorts";
            this.ButtonUpdatePorts.Size = new System.Drawing.Size(207, 68);
            this.ButtonUpdatePorts.TabIndex = 9;
            this.ButtonUpdatePorts.Text = "Available Ports";
            this.ButtonUpdatePorts.UseVisualStyleBackColor = false;
            this.ButtonUpdatePorts.Click += new System.EventHandler(this.ButtonUpdatePorts_Click);
            // 
            // ComboBoxPorts
            // 
            this.ComboBoxPorts.FormattingEnabled = true;
            this.ComboBoxPorts.Location = new System.Drawing.Point(722, 39);
            this.ComboBoxPorts.Name = "ComboBoxPorts";
            this.ComboBoxPorts.Size = new System.Drawing.Size(207, 21);
            this.ComboBoxPorts.TabIndex = 10;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // ButtonWriteDataToDb
            // 
            this.ButtonWriteDataToDb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonWriteDataToDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonWriteDataToDb.Location = new System.Drawing.Point(237, 12);
            this.ButtonWriteDataToDb.Name = "ButtonWriteDataToDb";
            this.ButtonWriteDataToDb.Size = new System.Drawing.Size(207, 68);
            this.ButtonWriteDataToDb.TabIndex = 15;
            this.ButtonWriteDataToDb.Text = "Write data to Db";
            this.ButtonWriteDataToDb.UseVisualStyleBackColor = false;
            this.ButtonWriteDataToDb.Click += new System.EventHandler(this.ButtonWriteDataToDb_Click);
            // 
            // RunChart
            // 
            this.RunChart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RunChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunChart.Location = new System.Drawing.Point(13, 12);
            this.RunChart.Name = "RunChart";
            this.RunChart.Size = new System.Drawing.Size(207, 68);
            this.RunChart.TabIndex = 16;
            this.RunChart.Text = "Run chart";
            this.RunChart.UseVisualStyleBackColor = false;
            this.RunChart.Click += new System.EventHandler(this.RunChart_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(387, 120);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.MarkerBorderWidth = 3;
            series4.Name = "Humidity";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "TemperatureDHT11";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "TemperatureBMP";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(807, 417);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 549);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.RunChart);
            this.Controls.Add(this.ButtonWriteDataToDb);
            this.Controls.Add(this.ComboBoxPorts);
            this.Controls.Add(this.ButtonUpdatePorts);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.TempBMP);
            this.Controls.Add(this.PressBMP);
            this.Controls.Add(this.LableHumDHT);
            this.Controls.Add(this.LableTempDHT);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LableTempDHT;
        private System.Windows.Forms.Label LableHumDHT;
        private System.Windows.Forms.Label PressBMP;
        private System.Windows.Forms.Label TempBMP;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonUpdatePorts;
        private System.Windows.Forms.ComboBox ComboBoxPorts;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button ButtonWriteDataToDb;
        private System.Windows.Forms.Button RunChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

