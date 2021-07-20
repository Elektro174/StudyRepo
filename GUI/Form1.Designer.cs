
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
            this.LableTemperature_fixed = new System.Windows.Forms.Label();
            this.LabelSvet_fixed = new System.Windows.Forms.Label();
            this.LableDHT11_h_fixed = new System.Windows.Forms.Label();
            this.LableDHT11_t_fixed = new System.Windows.Forms.Label();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonUpdatePorts = new System.Windows.Forms.Button();
            this.ComboBoxPorts = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.LableReleyStateTemperature = new System.Windows.Forms.Label();
            this.LableReleyStateSvet = new System.Windows.Forms.Label();
            this.LableReleyStateDHT11_h = new System.Windows.Forms.Label();
            this.LableReleyStateDHT11_t = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LableDHT11_t
            // 
            this.LableDHT11_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableDHT11_t.Location = new System.Drawing.Point(47, 31);
            this.LableDHT11_t.Name = "LableDHT11_t";
            this.LableDHT11_t.Size = new System.Drawing.Size(334, 49);
            this.LableDHT11_t.TabIndex = 0;
            this.LableDHT11_t.Text = "DHT11_t";
            this.LableDHT11_t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableDHT11_h
            // 
            this.LableDHT11_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableDHT11_h.Location = new System.Drawing.Point(47, 98);
            this.LableDHT11_h.Name = "LableDHT11_h";
            this.LableDHT11_h.Size = new System.Drawing.Size(334, 50);
            this.LableDHT11_h.TabIndex = 1;
            this.LableDHT11_h.Text = "DHT11_h";
            this.LableDHT11_h.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableLight
            // 
            this.LableLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableLight.Location = new System.Drawing.Point(47, 163);
            this.LableLight.Name = "LableLight";
            this.LableLight.Size = new System.Drawing.Size(334, 36);
            this.LableLight.TabIndex = 2;
            this.LableLight.Text = "Light";
            this.LableLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableDS18B20
            // 
            this.LableDS18B20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableDS18B20.Location = new System.Drawing.Point(47, 199);
            this.LableDS18B20.Name = "LableDS18B20";
            this.LableDS18B20.Size = new System.Drawing.Size(334, 69);
            this.LableDS18B20.TabIndex = 3;
            this.LableDS18B20.Text = "DS18B20";
            this.LableDS18B20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableTemperature_fixed
            // 
            this.LableTemperature_fixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableTemperature_fixed.Location = new System.Drawing.Point(48, 465);
            this.LableTemperature_fixed.Name = "LableTemperature_fixed";
            this.LableTemperature_fixed.Size = new System.Drawing.Size(333, 58);
            this.LableTemperature_fixed.TabIndex = 7;
            this.LableTemperature_fixed.Text = "DS18B20_fixed";
            this.LableTemperature_fixed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSvet_fixed
            // 
            this.LabelSvet_fixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSvet_fixed.Location = new System.Drawing.Point(47, 393);
            this.LabelSvet_fixed.Name = "LabelSvet_fixed";
            this.LabelSvet_fixed.Size = new System.Drawing.Size(334, 56);
            this.LabelSvet_fixed.TabIndex = 6;
            this.LabelSvet_fixed.Text = "Light_fixed";
            this.LabelSvet_fixed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableDHT11_h_fixed
            // 
            this.LableDHT11_h_fixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableDHT11_h_fixed.Location = new System.Drawing.Point(48, 341);
            this.LableDHT11_h_fixed.Name = "LableDHT11_h_fixed";
            this.LableDHT11_h_fixed.Size = new System.Drawing.Size(333, 52);
            this.LableDHT11_h_fixed.TabIndex = 5;
            this.LableDHT11_h_fixed.Text = "DHT11_h_fixed";
            this.LableDHT11_h_fixed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableDHT11_t_fixed
            // 
            this.LableDHT11_t_fixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableDHT11_t_fixed.Location = new System.Drawing.Point(48, 281);
            this.LableDHT11_t_fixed.Name = "LableDHT11_t_fixed";
            this.LableDHT11_t_fixed.Size = new System.Drawing.Size(333, 50);
            this.LableDHT11_t_fixed.TabIndex = 4;
            this.LableDHT11_t_fixed.Text = "DHT11_t_fixed";
            this.LableDHT11_t_fixed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // LableReleyStateTemperature
            // 
            this.LableReleyStateTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableReleyStateTemperature.Location = new System.Drawing.Point(433, 163);
            this.LableReleyStateTemperature.Name = "LableReleyStateTemperature";
            this.LableReleyStateTemperature.Size = new System.Drawing.Size(339, 87);
            this.LableReleyStateTemperature.TabIndex = 14;
            this.LableReleyStateTemperature.Text = "DS18B20";
            this.LableReleyStateTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableReleyStateSvet
            // 
            this.LableReleyStateSvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableReleyStateSvet.Location = new System.Drawing.Point(433, 250);
            this.LableReleyStateSvet.Name = "LableReleyStateSvet";
            this.LableReleyStateSvet.Size = new System.Drawing.Size(339, 63);
            this.LableReleyStateSvet.TabIndex = 13;
            this.LableReleyStateSvet.Text = "Light";
            this.LableReleyStateSvet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableReleyStateDHT11_h
            // 
            this.LableReleyStateDHT11_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableReleyStateDHT11_h.Location = new System.Drawing.Point(433, 107);
            this.LableReleyStateDHT11_h.Name = "LableReleyStateDHT11_h";
            this.LableReleyStateDHT11_h.Size = new System.Drawing.Size(339, 50);
            this.LableReleyStateDHT11_h.TabIndex = 12;
            this.LableReleyStateDHT11_h.Text = "DHT11_h";
            this.LableReleyStateDHT11_h.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableReleyStateDHT11_t
            // 
            this.LableReleyStateDHT11_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableReleyStateDHT11_t.Location = new System.Drawing.Point(433, 40);
            this.LableReleyStateDHT11_t.Name = "LableReleyStateDHT11_t";
            this.LableReleyStateDHT11_t.Size = new System.Drawing.Size(339, 49);
            this.LableReleyStateDHT11_t.TabIndex = 11;
            this.LableReleyStateDHT11_t.Text = "DHT11_t";
            this.LableReleyStateDHT11_t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 549);
            this.Controls.Add(this.LableReleyStateTemperature);
            this.Controls.Add(this.LableReleyStateSvet);
            this.Controls.Add(this.LableReleyStateDHT11_h);
            this.Controls.Add(this.LableReleyStateDHT11_t);
            this.Controls.Add(this.ComboBoxPorts);
            this.Controls.Add(this.ButtonUpdatePorts);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.LableTemperature_fixed);
            this.Controls.Add(this.LabelSvet_fixed);
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
        private System.Windows.Forms.Label LableTemperature_fixed;
        private System.Windows.Forms.Label LabelSvet_fixed;
        private System.Windows.Forms.Label LableDHT11_h_fixed;
        private System.Windows.Forms.Label LableDHT11_t_fixed;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonUpdatePorts;
        private System.Windows.Forms.ComboBox ComboBoxPorts;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label LableReleyStateTemperature;
        private System.Windows.Forms.Label LableReleyStateSvet;
        private System.Windows.Forms.Label LableReleyStateDHT11_h;
        private System.Windows.Forms.Label LableReleyStateDHT11_t;
    }
}

