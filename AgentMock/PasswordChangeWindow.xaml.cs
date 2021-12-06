using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using AgentMock.Annotations;

namespace AgentMock
{
    /// <summary>
    /// Interaction logic for PasswordChangeScreen.xaml
    /// </summary>
    public partial class PasswordChangeWindow : Window, INotifyPropertyChanged
    {
        public string Login;
        public string OldPassword;
        public string NewPassword;
        public string NewRepeatPassword;

        private string _validationRegex = @"^(\d{1,5}|\d{0,5}\.\d{1,2})$";
        public bool IsPasswordError { get; set; }

        public PasswordChangeWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login = LoginBox.Text;
            OldPassword = PasswordBox.Password;
            NewPassword = NewPasswordBox.Password;
            NewRepeatPassword = NewRepeatPasswordBox.Password;
            DialogResult = true;
            Close();
        }

        private void NewPasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            IsPasswordError = ((PasswordBox) sender).Password.Contains('a');
            OnPropertyChanged(nameof(IsPasswordError));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
