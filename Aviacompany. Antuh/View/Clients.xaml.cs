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
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        Entities1 m = new Entities1();
        public Clients()
        {
            InitializeComponent();
        }
        private void Client_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from client in m.Client select new { client.ID_Client, client.Surname, client.Name, client.Patronymic, client.ID_Discount };
            dataGrid1.ItemsSource = query.ToList();
            var query1 = from passport in m.Passport select new { passport.ID_Passport, passport.Series, passport.Number };
            var query2 = from visa in m.Visa select new { visa.ID_Visa, visa.Series, visa.Number };
            var query3 = from discount in m.Discount select new { discount.ID_Discount, discount.Name, discount.Description };
            dataGrid1.ItemsSource = query.ToList();
            dataGridpassport.ItemsSource = query1.ToList();
            dataGridvisa.ItemsSource = query2.ToList();
            dataGriddiscount.ItemsSource = query3.ToList();
        }
        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            AgentRegistr f3 = new AgentRegistr();
            f3.Show();
            this.Close();
        }

        private void btn_addclient_Click(object sender, RoutedEventArgs e)
        {
            AddClient f3 = new AddClient();
            f3.Show();
        }

        private void btn_deleteclient_Click(object sender, RoutedEventArgs e)
        {
            int deletetoid = Convert.ToInt32(tb_deletetoid.Text);
            
        }
    }
}
