﻿using Castle.Windsor;
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
    public partial class SingUpForm : Form
    {
        WindsorContainer _container;
        IUsersRepository _usersRepository;
        IUnitOfWork _unitOfWork;
        public SingUpForm()
        {
            InitializeComponent();
        }

        private void SingUpForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSingUp_Click(object sender, EventArgs e)
        {
            SingUpDataViewModel singUpData = new SingUpDataViewModel(TextBoxLogin.Text, TextBoxPass.Text, TextBoxFirstName.Text, TextBoxSecondName.Text);

            if (SingUpDataViewModel.Login.Length < 3 || SingUpDataViewModel.Login.Length > 25)
            {
                TextBoxLogin.BackColor = Color.FromArgb(209, 113, 113);
                MessageBox.Show("Логин не может быть меньше 3-х и больше 25-ти символов");
            }
            else if (SingUpDataViewModel.Pass.Length < 3 || SingUpDataViewModel.Pass.Length > 50)
            {
                TextBoxPass.BackColor = Color.FromArgb(209, 113, 113);
                MessageBox.Show("Пароль не может быть меньше 3-х и больше 50-ти символов");
            }
            else if (SingUpDataViewModel.FirstName.Length < 2 || SingUpDataViewModel.FirstName.Length > 25)
            {
                TextBoxFirstName.BackColor = Color.FromArgb(209, 113, 113);
                MessageBox.Show("Имя не может быть меньше 2-х и больше 25-ти символов");
            }
            else if (SingUpDataViewModel.SecondName.Length < 2 || SingUpDataViewModel.SecondName.Length > 25)
            {
                TextBoxSecondName.BackColor = Color.FromArgb(209, 113, 113);
                MessageBox.Show("Фамилия не может быть меньше 2-х и больше 25-ти символов");
            }
            else
            {
                TextBoxLogin.BackColor = SystemColors.Window;
                TextBoxPass.BackColor = SystemColors.Window;
                TextBoxFirstName.BackColor = SystemColors.Window;
                TextBoxSecondName.BackColor = SystemColors.Window;

                _container = Bootstrap.BuildContainer();
                _usersRepository = _container.Resolve<IUsersRepository>();
                _unitOfWork = _container.Resolve<IUnitOfWork>();

                User userSingUp = null;
                
                List<User> users = _usersRepository.GetAll().ToList();
                userSingUp = users.FirstOrDefault(b => b.Login == SingUpDataViewModel.Login);

                if (userSingUp == null)
                {
                    User user = new User();
                    user.FirstName = SingUpDataViewModel.FirstName;
                    user.SecondName = SingUpDataViewModel.SecondName;
                    user.CreationDate = DateTime.Now.ToString();
                    user.Login = SingUpDataViewModel.Login;
                    user.Pass = SingUpDataViewModel.Pass;

                    _usersRepository.Create(user);
                    _unitOfWork.Save();

                    this.Hide();
                    SingInForm singInForm = new SingInForm();
                    singInForm.Show();
                }
                else MessageBox.Show("Пользователь с таким логином уже существует");
            }
        }

        private void LableCraeteAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingInForm singInForm = new SingInForm();
            singInForm.Show();
        }
    }
}
