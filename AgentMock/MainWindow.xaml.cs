using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace AgentMock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            if (loginWindow.ShowDialog() == true)
            {
                MessageBox.Show($"Login ready\n\rLogin-{loginWindow.Login}\n\rPassword-{loginWindow.Password}");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DelayedWindow dw = new DelayedWindow(5000);
            dw.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PasswordChangeWindow cpWindow = new PasswordChangeWindow();
            if (cpWindow.ShowDialog() == true)
            {
                MessageBox.Show($"Login ready\n\rLogin-{cpWindow.Login}\n\rOld Password-{cpWindow.OldPassword}\n\rNew password-{cpWindow.NewPassword}\n\rNew repeat password-{cpWindow.NewRepeatPassword}");
            }
        }
    }
}