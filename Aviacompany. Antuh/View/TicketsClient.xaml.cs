using Aviacompany.Antuh.Model;
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
    /// Логика взаимодействия для TicketsClient.xaml
    /// </summary>
    public partial class TicketsClient : Window
    {
        public TicketsClient()
        {
            InitializeComponent();
        }
        Entities1 m = new Entities1();
        private void Ticket_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from client in m.Client select new { client.ID_Client, client.Surname, client.Name, client.Patronymic, client.ID_Discount };
            dataGridclient.ItemsSource = query.ToList();
            var query1 = from ticket in m.Ticket select new { ticket.ID_Ticket, ticket.ID_Client,ticket.ID_Flight, ticket.Place, ticket.ID_TypePlace, ticket.GeneralCost};
            var query2 = from flight in m.Flight select new { flight.ID_Flight, flight.ID_DeparturePoint, flight.ID_ArrivalPoint, flight.ID_Meteorology, flight.DepartureTime, flight.ArrivalTime };
            dataGridticket.ItemsSource = query1.ToList();
            dataGridflight.ItemsSource = query2.ToList();
            var query3 = from typepl in m.TypePlace select new { typepl.ID_TypePlace, typepl.Name, typepl.Cost };
            dataGridtypeplace.ItemsSource = query3.ToList();

        }

        private void btn_addticket_Click(object sender, RoutedEventArgs e)
        {
            AddTicket f3 = new AddTicket();
            f3.Show();
        }

        private void btn_deleteticket_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить билет", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                int num = Convert.ToInt32(tb_deletetoidtick.Text);
                var dRow = m.Ticket.Where(w => w.ID_Ticket == num).FirstOrDefault();
                m.Ticket.Remove(dRow);
                m.SaveChanges();
                var query = from ticket in m.Ticket select new { ticket.ID_Ticket, ticket.ID_Client, ticket.ID_Flight, ticket.Place, ticket.ID_TypePlace, ticket.GeneralCost };
                dataGridticket.ItemsSource = query.ToList();
            }
        }

        private void btn_redactcticket_Click(object sender, RoutedEventArgs e)
        {
            RedactirovanieTicket f3 = new RedactirovanieTicket();
            f3.Show();
        }

        private void btn_obnovit_Click(object sender, RoutedEventArgs e)
        {
            var query = from client in m.Client select new { client.ID_Client, client.Surname, client.Name, client.Patronymic, client.ID_Discount };
            dataGridclient.ItemsSource = query.ToList();
            var query1 = from ticket in m.Ticket select new { ticket.ID_Ticket, ticket.ID_Client, ticket.ID_Flight, ticket.Place, ticket.ID_TypePlace, ticket.GeneralCost };
            var query2 = from flight in m.Flight select new { flight.ID_Flight, flight.ID_DeparturePoint, flight.ID_ArrivalPoint, flight.ID_Meteorology, flight.DepartureTime, flight.ArrivalTime };
            dataGridticket.ItemsSource = query1.ToList();
            dataGridflight.ItemsSource = query2.ToList();
            var query3 = from typepl in m.TypePlace select new { typepl.ID_TypePlace, typepl.Name, typepl.Cost };
            dataGridtypeplace.ItemsSource = query3.ToList();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            AgentRegistr f3 = new AgentRegistr();
            f3.Show();
            this.Close();
        }
    }
}
