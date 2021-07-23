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
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string Pass { get; set; }
        /// <summary>
        /// Id авторизованного пользователя
        /// </summary>
        public static int CurrentUserId { get; set; }
    }
}
