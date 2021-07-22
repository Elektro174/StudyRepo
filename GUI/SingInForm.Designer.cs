
namespace GUI
{
    partial class SingInForm
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
            this.ButtonSingIn = new System.Windows.Forms.Button();
            this.SingInTextBoxLogin = new System.Windows.Forms.TextBox();
            this.SingInTextBoxPass = new System.Windows.Forms.TextBox();
            this.SingInLableGetLogin = new System.Windows.Forms.Label();
            this.SingInLableGetPass = new System.Windows.Forms.Label();
            this.LableSingIn = new System.Windows.Forms.Label();
            this.LableCraeteAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSingIn
            // 
            this.ButtonSingIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSingIn.Location = new System.Drawing.Point(250, 285);
            this.ButtonSingIn.Name = "ButtonSingIn";
            this.ButtonSingIn.Size = new System.Drawing.Size(300, 58);
            this.ButtonSingIn.TabIndex = 0;
            this.ButtonSingIn.Text = "Войти";
            this.ButtonSingIn.UseVisualStyleBackColor = true;
            this.ButtonSingIn.Click += new System.EventHandler(this.ButtonSingIn_Click);
            // 
            // SingInTextBoxLogin
            // 
            this.SingInTextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingInTextBoxLogin.Location = new System.Drawing.Point(272, 108);
            this.SingInTextBoxLogin.Multiline = true;
            this.SingInTextBoxLogin.Name = "SingInTextBoxLogin";
            this.SingInTextBoxLogin.Size = new System.Drawing.Size(516, 36);
            this.SingInTextBoxLogin.TabIndex = 1;
            // 
            // SingInTextBoxPass
            // 
            this.SingInTextBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingInTextBoxPass.Location = new System.Drawing.Point(272, 190);
            this.SingInTextBoxPass.Multiline = true;
            this.SingInTextBoxPass.Name = "SingInTextBoxPass";
            this.SingInTextBoxPass.Size = new System.Drawing.Size(516, 36);
            this.SingInTextBoxPass.TabIndex = 2;
            // 
            // SingInLableGetLogin
            // 
            this.SingInLableGetLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingInLableGetLogin.Location = new System.Drawing.Point(2, 108);
            this.SingInLableGetLogin.Name = "SingInLableGetLogin";
            this.SingInLableGetLogin.Size = new System.Drawing.Size(204, 36);
            this.SingInLableGetLogin.TabIndex = 3;
            this.SingInLableGetLogin.Text = "Введите логин:";
            this.SingInLableGetLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SingInLableGetPass
            // 
            this.SingInLableGetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingInLableGetPass.Location = new System.Drawing.Point(2, 181);
            this.SingInLableGetPass.Name = "SingInLableGetPass";
            this.SingInLableGetPass.Size = new System.Drawing.Size(234, 45);
            this.SingInLableGetPass.TabIndex = 4;
            this.SingInLableGetPass.Text = "Введите пароль:";
            this.SingInLableGetPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LableSingIn
            // 
            this.LableSingIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LableSingIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableSingIn.Location = new System.Drawing.Point(0, 0);
            this.LableSingIn.Name = "LableSingIn";
            this.LableSingIn.Size = new System.Drawing.Size(800, 87);
            this.LableSingIn.TabIndex = 5;
            this.LableSingIn.Text = "Авторизация";
            this.LableSingIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LableCraeteAccount
            // 
            this.LableCraeteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableCraeteAccount.Location = new System.Drawing.Point(247, 403);
            this.LableCraeteAccount.Name = "LableCraeteAccount";
            this.LableCraeteAccount.Size = new System.Drawing.Size(303, 38);
            this.LableCraeteAccount.TabIndex = 6;
            this.LableCraeteAccount.Text = "Ещё нет аккаунта?";
            this.LableCraeteAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LableCraeteAccount.Click += new System.EventHandler(this.LableCraeteAccount_Click);
            // 
            // SingInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LableCraeteAccount);
            this.Controls.Add(this.LableSingIn);
            this.Controls.Add(this.SingInLableGetPass);
            this.Controls.Add(this.SingInLableGetLogin);
            this.Controls.Add(this.SingInTextBoxPass);
            this.Controls.Add(this.SingInTextBoxLogin);
            this.Controls.Add(this.ButtonSingIn);
            this.Name = "SingInForm";
            this.Text = "SingInForm";
            this.Load += new System.EventHandler(this.SingInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSingIn;
        private System.Windows.Forms.TextBox SingInTextBoxLogin;
        private System.Windows.Forms.TextBox SingInTextBoxPass;
        private System.Windows.Forms.Label SingInLableGetLogin;
        private System.Windows.Forms.Label SingInLableGetPass;
        private System.Windows.Forms.Label LableSingIn;
        private System.Windows.Forms.Label LableCraeteAccount;
    }
}

       
   