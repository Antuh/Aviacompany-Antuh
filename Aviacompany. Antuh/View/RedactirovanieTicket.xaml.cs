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
    /// Логика взаимодействия для RedactirovanieTicket.xaml
    /// </summary>
    public partial class RedactirovanieTicket : Window
    {
        public RedactirovanieTicket()
        {
            InitializeComponent();
        }
        Entities1 m = new Entities1();

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            TicketsClient f3 = new TicketsClient();
            f3.Show();
        }

        private void btn_RedactTick_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(tb_redacttickettoid.Text);
            var uRow = m.Ticket.Where(w => w.ID_Ticket == num).FirstOrDefault();
            uRow.ID_Client = Convert.ToInt32(tb_idclient.Text);
            uRow.ID_Flight = Convert.ToInt32(tb_idflight.Text);
            uRow.Place = tb_place.Text;
            uRow.ID_TypePlace = Convert.ToInt32(tb_idtypeplace.Text);
            uRow.GeneralCost = Convert.ToDecimal(tb_cost.Text);
            m.SaveChanges();
        }
    }
}
