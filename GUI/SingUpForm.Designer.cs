
namespace GUI
{
    partial class SingUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSingUp = new System.Windows.Forms.Button();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.LableGetLogin = new System.Windows.Forms.Label();
            this.LableGetPass = new System.Windows.Forms.Label();
            this.LableSingUp = new System.Windows.Forms.Label();
            this.LableGetSecondName = new System.Windows.Forms.Label();
            this.LableGetFirstName = new System.Windows.Forms.Label();
            this.TextBoxSecondName = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.LableCraeteAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSingUp
            // 
            this.ButtonSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSingUp.Location = new System.Drawing.Point(250, 342);
            this.ButtonSingUp.Name = "ButtonSingUp";
            this.ButtonSingUp.Size = new System.Drawing.Size(300, 58);
            this.ButtonSingUp.TabIndex = 0;
            this.ButtonSingUp.Text = "Зарегистрироваться";
            this.ButtonSingUp.UseVisualStyleBackColor = true;
            this.ButtonSingUp.Click += new System.EventHandler(this.ButtonSingUp_Click);
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLogin.Location = new System.Drawing.Point(272, 229);
            this.TextBoxLogin.Multiline = true;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(516, 36);
            this.TextBoxLogin.TabIndex = 1;
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPass.Location = new System.Drawing.Point(272, 274);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(516, 38);
            this.TextBoxPass.TabIndex = 2;
            this.TextBoxPass.UseSystemPasswordChar = true;
            // 
            // LableGetLogin
            // 
            this.LableGetLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableGetLogin.Location = new System.Drawing.Point(2, 229);
            this.LableGetLogin.Name = "LableGetLogin";
            this.LableGetLogin.Size = new System.Drawing.Size(204, 36);
            this.LableGetLogin.TabIndex = 3;
            this.LableGetLogin.Text = "Введите логин:";
            this.LableGetLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LableGetPass
            // 
            this.LableGetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableGetPass.Location = new System.Drawing.Point(2, 265);
            this.LableGetPass.Name = "LableGetPass";
            this.LableGetPass.Size = new System.Drawing.Size(234, 45);
            this.LableGetPass.TabIndex = 4;
            this.LableGetPass.Text = "Введите пароль:";
            this.LableGetPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LableSingUp
            // 
            this.LableSingUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.LableSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableSingUp.Location = new System.Drawing.Point(0, 0);
            this.LableSingUp.Name = "LableSingUp";
            this.LableSingUp.Size = new System.Drawing.Size(800, 87);
            this.LableSingUp.TabIndex = 5;
            this.LableSingUp.Text = "Регистрация";
            this.LableSingUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableGetSecondName
            // 
            this.LableGetSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableGetSecondName.Location = new System.Drawing.Point(2, 150);
            this.LableGetSecondName.Name = "LableGetSecondName";
            this.LableGetSecondName.Size = new System.Drawing.Size(264, 45);
            this.LableGetSecondName.TabIndex = 9;
            this.LableGetSecondName.Text = "Введите фамилию:";
            this.LableGetSecondName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LableGetFirstName
            // 
            this.LableGetFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableGetFirstName.Location = new System.Drawing.Point(2, 114);
            this.LableGetFirstName.Name = "LableGetFirstName";
            this.LableGetFirstName.Size = new System.Drawing.Size(204, 36);
            this.LableGetFirstName.TabIndex = 8;
            this.LableGetFirstName.Text = "Введите имя:";
            this.LableGetFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxSecondName
            // 
            this.TextBoxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondName.Location = new System.Drawing.Point(272, 159);
            this.TextBoxSecondName.Multiline = true;
            this.TextBoxSecondName.Name = "TextBoxSecondName";
            this.TextBoxSecondName.Size = new System.Drawing.Size(516, 36);
            this.TextBoxSecondName.TabIndex = 7;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstName.Location = new System.Drawing.Point(272, 114);
            this.TextBoxFirstName.Multiline = true;
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(516, 36);
            this.TextBoxFirstName.TabIndex = 6;
            // 
            // LableCraeteAccount
            // 
            this.LableCraeteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableCraeteAccount.Location = new System.Drawing.Point(247, 403);
            this.LableCraeteAccount.Name = "LableCraeteAccount";
            this.LableCraeteAccount.Size = new System.Drawing.Size(303, 38);
            this.LableCraeteAccount.TabIndex = 10;
            this.LableCraeteAccount.Text = "Есть аккаунт? – Войдите";
            this.LableCraeteAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LableCraeteAccount.Click += new System.EventHandler(this.LableCraeteAccount_Click);
            // 
            // SingUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LableCraeteAccount);
            this.Controls.Add(this.LableGetSecondName);
            this.Controls.Add(this.LableGetFirstName);
            this.Controls.Add(this.TextBoxSecondName);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.LableSingUp);
            this.Controls.Add(this.LableGetPass);
            this.Controls.Add(this.LableGetLogin);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.ButtonSingUp);
            this.Name = "SingUpForm";
            this.Text = "SingUpForm";
            this.Load += new System.EventHandler(this.SingUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSingUp;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Label LableGetLogin;
        private System.Windows.Forms.Label LableGetPass;
        private System.Windows.Forms.Label LableSingUp;
        private System.Windows.Forms.Label LableGetSecondName;
        private System.Windows.Forms.Label LableGetFirstName;
        private System.Windows.Forms.TextBox TextBoxSecondName;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label LableCraeteAccount;
    }
}