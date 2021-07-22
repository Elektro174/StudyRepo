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
    public partial class SingUpForm : Form
    {
        WindsorContainer _container;
        IUsersRepository _usersRepository;
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

            if (singUpData.Login.Length < 3 && singUpData.Login.Length > 25)
            {
                TextBoxLogin.BackColor = Color.FromArgb(209, 113, 113);
                MessageBox.Show("Логин не может быть меньше 3-х и больше 25-ти символов");
            }
            else if (singUpData.Pass.Length < 3 && singUpData.Pass.Length > 50)
            {
                TextBoxPass.BackColor = Color.FromArgb(209, 113, 113);
                MessageBox.Show("Пароль не может быть меньше 3-х и больше 50-ти символов");
            }
            else if (singUpData.FirstName.Length < 2 && singUpData.FirstName.Length > 25)
            {
                TextBoxFirstName.BackColor = Color.FromArgb(209, 113, 113);
                MessageBox.Show("Имя не может быть меньше 2-х и больше 25-ти символов");
            }
            else if (singUpData.SecondName.Length < 2 && singUpData.SecondName.Length > 25)
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

                User userSingUp = null;
                //PracticeDbContext context = new PracticeDbContext
                /*using (PracticeDbContext context = new PracticeDbContext())
                {
                    userSingUp = context.Users.Where(b => b.Login == singUpData.Login).FirstOrDefault();
                }*/
                //PracticeDbContext context = new PracticeDbContext();
                //UsersRepository usersRepository = new UsersRepository(context);
                List<User> users = _usersRepository.GetAll().ToList();
                userSingUp = users.FirstOrDefault(b => b.Login == singUpData.Login);

                if (userSingUp == null)
                {
                    User user = new User();
                    user.FirstName = singUpData.FirstName;
                    user.SecondName = singUpData.SecondName;
                    user.CreationDate = DateTime.Now.ToString();
                    user.Login = singUpData.Login;
                    user.Pass = singUpData.Pass;

                    //UnitOfWork unitOfWork = new UnitOfWork(context);

                    _usersRepository.Create(user);

                    //unitOfWork.Save();

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
