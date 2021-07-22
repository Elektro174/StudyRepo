using Data;
using GUI.Models.ViewModels;
using Models;
using Repository;
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
            User userSingUp = null;
            //PracticeDbContext context = new PracticeDbContext
            /*using (PracticeDbContext context = new PracticeDbContext())
            {
                userSingUp = context.Users.Where(b => b.Login == singUpData.Login).FirstOrDefault();
            }*/
            PracticeDbContext context = new PracticeDbContext();
            UsersRepository usersRepository = new UsersRepository(context);
            List<User> users = usersRepository.GetAll().ToList();
            userSingUp = users.FirstOrDefault(b => b.Login == singUpData.Login);

            if (userSingUp == null)
            {
                User user = new User();
                user.FirstName = singUpData.FirstName;
                user.SecondName = singUpData.SecondName;
                user.CreationDate = DateTime.Now.ToString();
                user.Login = singUpData.Login;
                user.Pass = singUpData.Pass;

                UnitOfWork unitOfWork = new UnitOfWork(context);

                usersRepository.Create(user);

                unitOfWork.Save();

                this.Hide();
                SingInForm singInForm = new SingInForm();
                singInForm.Show();
            }
            else MessageBox.Show("Пользователь с таким логином уже существует");
        }

        private void LableCraeteAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingInForm singInForm = new SingInForm();
            singInForm.Show();
        }
    }
}
