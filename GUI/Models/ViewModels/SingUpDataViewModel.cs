﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Models.ViewModels
{
    public class SingUpDataViewModel
    {
        public SingUpDataViewModel() { }

        public SingUpDataViewModel(string login, string pass, string firstName, string secondName)
        {
            Login = login;
            Pass = pass;
            FirstName = firstName;
            SecondName = secondName;
        }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}
