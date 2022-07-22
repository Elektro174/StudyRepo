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
        /// <summary>
        /// Логин
        /// </summary>
        public static string Login { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public static string Pass { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public static string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public static string SecondName { get; set; }
    }
}
