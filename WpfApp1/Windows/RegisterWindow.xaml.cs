using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using WpfApp1.Data.GenericRepositories;
using WpfApp1.Domain.Entities;
using WpfApp1.Extensions;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private readonly User users;
        private readonly GenericRepository<User> userRepository;

        public RegisterWindow()
        {
            InitializeComponent();
            users = new User();
            userRepository = new GenericRepository<User>();
            
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 0;
            doubleAnimation.To = 250;
            doubleAnimation.Duration = TimeSpan.FromSeconds(1.5);
            registerButton.BeginAnimation(Button.WidthProperty, doubleAnimation);
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            string login = loginBox.Text.Trim();
            string password = regPassword.Password.Trim();
            string repeatedPassword = regRepeatPassword.Password.Trim();

            if (!IsValidLogin(login))
            {
                loginBox.ToolTip = "Invalid login. Only Latin letters and numbers are allowed and at least 8 characters.";
                loginBox.Foreground = Brushes.Red;
            }

            else if (!IsValidPassword(password))
            {
                regPassword.ToolTip = "Invalid password.It should have 8 characters with at least one uppercase letter and one number.";
                regPassword.Foreground = Brushes.Red;
            }

            else if (repeatedPassword != password)
            {
                regRepeatPassword.ToolTip = "Password does not match. Please enter the password again.";
                regRepeatPassword.Foreground = Brushes.Red;
            }

            else 
            {
                loginBox.ToolTip = "";
                loginBox.Background = Brushes.Transparent;

                regPassword.ToolTip = "";
                regPassword.Background = Brushes.Transparent;

                regRepeatPassword.ToolTip = "";
                regRepeatPassword.Background = Brushes.Transparent;

                var existUser = userRepository.GetAll().Any(u => u.Login == login);

                if(existUser)
                {
                    MessageBox.Show("User with this login already exists. Please choose a different login.");
                }

                else
                {
                    users.CreatedTime = DateTime.UtcNow;
                    users.Login = login;
                    users.Password = password.Encrypt();

                    userRepository.AddAsync(users);

                    OpenMainWindow(login,password);
                }
            }
        }

        private bool IsValidLogin(string login)
        {
            // Check length
            if (login.Length < 8)
                return false;

            // Regular expression to allow only Latin letters and numbers
            string pattern = @"^[a-zA-Z0-9]+$";
            return Regex.IsMatch(login, pattern);
        }

        private bool IsValidPassword(string password)
        {
            // Check length
            if (password.Length < 8)
                return false;

            // Check for at least one uppercase letter
            if (!password.Any(char.IsUpper))
                return false;

            // Check for at least one number
            if (!password.Any(char.IsDigit))
                return false;

            // Check for only Latin letters and numbers
            string pattern = @"^[a-zA-Z0-9]+$";
            return Regex.IsMatch(password, pattern);
        }

        private void OpenMainWindow(string login,string password)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.logintxt.Text = login;
            mainWindow.passwordtxt.Password = password;
            mainWindow.Show();
            Close();
        }

        private void registerLoginButton_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
    }
}
