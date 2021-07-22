using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Models.ViewModels
{
    public class SingInDataViewModel
    {


        public SingInDataViewModel() { }

        public SingInDataViewModel(string login, string pass)
        {
            Login = login;
            Pass = pass;
        }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string CurrentUserFirstName { get; set; }
        public string CurrentUserSecondName { get; set; }
        public int CurrentUserId { get; set; }
    }
}
