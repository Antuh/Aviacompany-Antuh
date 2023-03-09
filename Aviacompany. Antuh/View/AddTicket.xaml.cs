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
    /// Логика взаимодействия для AddTicket.xaml
    /// </summary>
    public partial class AddTicket : Window
    {
        public AddTicket()
        {
            InitializeComponent();
        }
        Entities1 m = new Entities1();
        Entities1 ms = Helper.getContext();

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            TicketsClient f3 = new TicketsClient();
            f3.Show();
            this.Close();
        }

        private void btn_AddTick_Click(object sender, RoutedEventArgs e)
        {
            int idclient = Convert.ToInt32(tb_idclient.Text);
            int idflight = Convert.ToInt32(tb_idflight.Text);
            int idtypeplace = Convert.ToInt32(tb_idtypeplace.Text);
            string place = tb_place.Text;
            decimal cost = Convert.ToDecimal(tb_cost.Text);
            Ticket ticket = new Ticket { ID_Client = idclient, ID_Flight = idflight, ID_TypePlace = idtypeplace, Place = place, GeneralCost = cost };
            Helper.CreateTicket(ticket);
            MessageBox.Show("Билет добавлен");
        }
    }
}
