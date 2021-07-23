using Castle.Windsor;
using Data;
using GUI.Models.ViewModels;
using Models;
using Repository;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SingInForm : Form
    {
        WindsorContainer _container;
        IUsersRepository _usersRepository;
        public SingInForm()
        {
            InitializeComponent();
        }

        private void SingInForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSingIn_Click(object sender, EventArgs e)
        {
            SingInDataViewModel singInData = new SingInDataViewModel(SingInTextBoxLogin.Text, SingInTextBoxPass.Text);

            if (singInData.Login.Length < 3 && singInData.Login.Length > 25)
            {
                SingInTextBoxLogin.BackColor = Color.FromArgb(209, 113, 113);
                MessageBox.Show("Логин не может быть меньше 3-х и больше 25-ти символов");
            }
            else if (singInData.Pass.Length < 3 && singInData.Pass.Length > 50)
            {
                SingInTextBoxPass.BackColor = Color.FromArgb(209, 113, 113);
                MessageBox.Show("Пароль не может быть меньше 3-х и больше 50-ти символов");
            }
            else
            {
                SingInTextBoxLogin.BackColor = SystemColors.Window;
                SingInTextBoxPass.BackColor = SystemColors.Window;

                _container = Bootstrap.BuildContainer();
                _usersRepository = _container.Resolve<IUsersRepository>();

                User userSingIn = null;               
                List<User> users = _usersRepository.GetAll().ToList();
                userSingIn = users.FirstOrDefault(b => b.Login == singInData.Login && b.Pass == singInData.Pass);

                if (userSingIn != null)
                {
                   
                    SingInDataViewModel.CurrentUserId = userSingIn.Id;
                   
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else MessageBox.Show("Введите правильные логин и пароль или зарегистрируйтесь");
            }
        }

        private void LableCraeteAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingUpForm singUpForm = new SingUpForm();
            singUpForm.Show();
        }
    }
}
