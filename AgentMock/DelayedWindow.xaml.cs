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
using System.Windows.Shapes;

namespace AgentMock
{
    /// <summary>
    /// Interaction logic for DelayedWindow.xaml
    /// </summary>
    public partial class DelayedWindow : Window
    {
        private int _delay;

        public DelayedWindow() : this(5000)
        {

        }

        public DelayedWindow(int delay)
        {
            InitializeComponent();
            _delay = delay;
        }


        async Task OpenLoginWindow(int delay)
        {
            await Task.Delay(delay);

            LoginWindow lw = new LoginWindow();
            lw.Title = "DelayedLoginWindow";
            lw.Show();
            Close();
        }

        private void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)
        {
            OpenLoginWindow(_delay);
        }
    }
}
