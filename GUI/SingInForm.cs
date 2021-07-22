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
    public partial class SingInForm : Form
    {
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
               
            User userSingIn = null;
            //PracticeDbContext context = new PracticeDbContext
            /*using (PracticeDbContext context = new PracticeDbContext())
            {
                userSingUp = context.Users.Where(b => b.Login == singUpData.Login).FirstOrDefault();
            }*/
            PracticeDbContext context = new PracticeDbContext();
            UsersRepository usersRepository = new UsersRepository(context);
            List<User> users = usersRepository.GetAll().ToList();
            userSingIn = users.FirstOrDefault(b => b.Login == singInData.Login && b.Pass == singInData.Pass);

            if (userSingIn != null)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else MessageBox.Show("Введите правильные логин и пароль или зарегистрируйтесь");
        }

        private void LableCraeteAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingUpForm singUpForm = new SingUpForm();
            singUpForm.Show();
        }
    }
}
