
namespace GUI
{
    partial class Form1
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
            this.LableDHT11_t = new System.Windows.Forms.Label();
            this.LableDHT11_h = new System.Windows.Forms.Label();
            this.LableLight = new System.Windows.Forms.Label();
            this.LableDS18B20 = new System.Windows.Forms.Label();
            this.LableDS18B20_fixed = new System.Windows.Forms.Label();
            this.LabelLight_fixed = new System.Windows.Forms.Label();
            this.LableDHT11_h_fixed = new System.Windows.Forms.Label();
            this.LableDHT11_t_fixed = new System.Windows.Forms.Label();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonUpdatePorts = new System.Windows.Forms.Button();
            this.ComboBoxPorts = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // LableDHT11_t
            // 
            this.LableDHT11_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableDHT11_t.Location = new System.Drawing.Point(47, 31);
            this.LableDHT11_t.Name = "LableDHT11_t";
            this.LableDHT11_t.Size = new System.Drawing.Size(266, 49);
            this.LableDHT11_t.TabIndex = 0;
            this.LableDHT11_t.Text = "DHT11_t";
            this.LableDHT11_t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableDHT11_h
            // 
            this.LableDHT11_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableDHT11_h.Location = new System.Drawing.Point(47, 98);
            this.LableDHT11_h.Name = "LableDHT11_h";
            this.LableDHT11_h.Size = new System.Drawing.Size(266, 50);
            this.LableDHT11_h.TabIndex = 1;
            this.LableDHT11_h.Text = "DHT11_h";
            this.LableDHT11_h.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableLight
            // 
            this.LableLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableLight.Location = new System.Drawing.Point(47, 165);
            this.LableLight.Name = "LableLight";
            this.LableLight.Size = new System.Drawing.Size(266, 36);
            this.LableLight.TabIndex = 2;
            this.LableLight.Text = "Light";
            this.LableLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableDS18B20
            // 
            this.LableDS18B20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableDS18B20.Location = new System.Drawing.Point(47, 218);
            this.LableDS18B20.Name = "LableDS18B20";
            this.LableDS18B20.Size = new System.Drawing.Size(266, 69);
            this.LableDS18B20.TabIndex = 3;
            this.LableDS18B20.Text = "DS18B20";
            this.LableDS18B20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableDS18B20_fixed
            // 
            this.LableDS18B20_fixed.Location = new System.Drawing.Point(47, 486);
            this.LableDS18B20_fixed.Name = "LableDS18B20_fixed";
            this.LableDS18B20_fixed.Size = new System.Drawing.Size(82, 36);
            this.LableDS18B20_fixed.TabIndex = 7;
            this.LableDS18B20_fixed.Text = "DS18B20_fixed";
            this.LableDS18B20_fixed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLight_fixed
            // 
            this.LabelLight_fixed.Location = new System.Drawing.Point(47, 429);
            this.LabelLight_fixed.Name = "LabelLight_fixed";
            this.LabelLight_fixed.Size = new System.Drawing.Size(68, 36);
            this.LabelLight_fixed.TabIndex = 6;
            this.LabelLight_fixed.Text = "Light_fixed";
            this.LabelLight_fixed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableDHT11_h_fixed
            // 
            this.LableDHT11_h_fixed.Location = new System.Drawing.Point(47, 362);
            this.LableDHT11_h_fixed.Name = "LableDHT11_h_fixed";
            this.LableDHT11_h_fixed.Size = new System.Drawing.Size(68, 36);
            this.LableDHT11_h_fixed.TabIndex = 5;
            this.LableDHT11_h_fixed.Text = "DHT11_h_fixed";
            this.LableDHT11_h_fixed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableDHT11_t_fixed
            // 
            this.LableDHT11_t_fixed.Location = new System.Drawing.Point(47, 304);
            this.LableDHT11_t_fixed.Name = "LableDHT11_t_fixed";
            this.LableDHT11_t_fixed.Size = new System.Drawing.Size(82, 36);
            this.LableDHT11_t_fixed.TabIndex = 4;
            this.LableDHT11_t_fixed.Text = "DHT11_t_fixed";
            this.LableDHT11_t_fixed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LableDHT11_t_fixed.Click += new System.EventHandler(this.label4_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(953, 98);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(207, 72);
            this.ButtonConnect.TabIndex = 8;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonUpdatePorts
            // 
            this.ButtonUpdatePorts.Location = new System.Drawing.Point(953, 12);
            this.ButtonUpdatePorts.Name = "ButtonUpdatePorts";
            this.ButtonUpdatePorts.Size = new System.Drawing.Size(207, 68);
            this.ButtonUpdatePorts.TabIndex = 9;
            this.ButtonUpdatePorts.Text = "Available Ports";
            this.ButtonUpdatePorts.UseVisualStyleBackColor = true;
            this.ButtonUpdatePorts.Click += new System.EventHandler(this.ButtonUpdatePorts_Click);
            // 
            // ComboBoxPorts
            // 
            this.ComboBoxPorts.FormattingEnabled = true;
            this.ComboBoxPorts.Location = new System.Drawing.Point(796, 40);
            this.ComboBoxPorts.Name = "ComboBoxPorts";
            this.ComboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPorts.TabIndex = 10;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 549);
            this.Controls.Add(this.ComboBoxPorts);
            this.Controls.Add(this.ButtonUpdatePorts);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.LableDS18B20_fixed);
            this.Controls.Add(this.LabelLight_fixed);
            this.Controls.Add(this.LableDHT11_h_fixed);
            this.Controls.Add(this.LableDHT11_t_fixed);
            this.Controls.Add(this.LableDS18B20);
            this.Controls.Add(this.LableLight);
            this.Controls.Add(this.LableDHT11_h);
            this.Controls.Add(this.LableDHT11_t);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LableDHT11_t;
        private System.Windows.Forms.Label LableDHT11_h;
        private System.Windows.Forms.Label LableLight;
        private System.Windows.Forms.Label LableDS18B20;
        private System.Windows.Forms.Label LableDS18B20_fixed;
        private System.Windows.Forms.Label LabelLight_fixed;
        private System.Windows.Forms.Label LableDHT11_h_fixed;
        private System.Windows.Forms.Label LableDHT11_t_fixed;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonUpdatePorts;
        private System.Windows.Forms.ComboBox ComboBoxPorts;
        private System.IO.Ports.SerialPort serialPort;
    }
}

