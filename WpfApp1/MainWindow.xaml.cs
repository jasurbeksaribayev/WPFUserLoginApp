using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using WpfApp1.Data.GenericRepositories;
using WpfApp1.Data.IGenericRepositories;
using WpfApp1.Domain.Entities;
using WpfApp1.Extensions;
using WpfApp1.Windows;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IGenericRepository<User> userRepository;

        public MainWindow()
        {
            InitializeComponent();
            this.userRepository = new GenericRepository<User>();
            LoadRememberedCredentials();
            Closing += MainWindow_Closing;

            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 0;
            doubleAnimation.To = 100;
            doubleAnimation.Duration = TimeSpan.FromSeconds(1.5);
            loginButton.BeginAnimation(Button.WidthProperty, doubleAnimation);
            registerButton.BeginAnimation(Button.WidthProperty, doubleAnimation);

        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var existUser = userRepository.GetAll().Any(u => u.Login == logintxt.Text & u.Password == passwordtxt.Password.Trim().Encrypt());

            if (!existUser)
            {
                MessageBox.Show("User not found");
            }

            else
            {
                UserMainWindow userMainWindow = new UserMainWindow();
                userMainWindow.userName.Text += logintxt.Text.Trim();

                userMainWindow.Show();
                Close();

                IsClickRememberCheckBox();
            }
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IsClickRememberCheckBox();
        }

            private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            new RegisterWindow().Show();
            Close();
        }

        private void IsClickRememberCheckBox()
        {
            if (rememberCheckBox.IsChecked == true)
            {
                RememberCredentials(logintxt.Text, passwordtxt.Password);
            }
            else
            {
                ClearRememberedCredentials();
            }
        }
        private void RememberCredentials(string login, string password)
        {
            Properties.Settings.Default.LoginDefault = login;
            Properties.Settings.Default.PasswordDefault = password;
            Properties.Settings.Default.Save();
        }

        private void ClearRememberedCredentials()
        {
            Properties.Settings.Default.LoginDefault = string.Empty;
            Properties.Settings.Default.PasswordDefault = string.Empty;
            Properties.Settings.Default.Save();
        }

        private void LoadRememberedCredentials()
        {
            string rememberedLogin = Properties.Settings.Default.LoginDefault;
            string rememberedPassword = Properties.Settings.Default.PasswordDefault;

            if (!string.IsNullOrEmpty(rememberedLogin) && !string.IsNullOrEmpty(rememberedPassword))
            {
                logintxt.Text = rememberedLogin;
                passwordtxt.Password = rememberedPassword;
                rememberCheckBox.IsChecked = true;
            }
        }

        private void rememberCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}