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

namespace Aviacompany.Antuh.View
{
    /// <summary>
    /// Логика взаимодействия для AgentRegistr.xaml
    /// </summary>
    public partial class AgentRegistr : Window
    {
        public AgentRegistr()
        {
            InitializeComponent();
        }

        private void btn_client_Click(object sender, RoutedEventArgs e)
        {
            Clients f3 = new Clients();
            f3.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow f3 = new MainWindow();
            f3.Show();
            this.Close();
        }

        private void btn_baggage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ticket_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
