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
    /// Логика взаимодействия для Baggages.xaml
    /// </summary>
    public partial class Baggages : Window
    {
        public Baggages()
        {
            InitializeComponent();
        }
        Entities1 m = new Entities1();
        private void Baggage_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from client in m.Client select new { client.ID_Client, client.Surname, client.Name, client.Patronymic, client.ID_Discount };
            dataGridClient.ItemsSource = query.ToList();
            var query1 = from baggage in m.Baggage select new { baggage.ID_Baggage, baggage.Code, baggage.ID_Client, baggage.ID_TypeBaggage, baggage.Weight };
            var query2 = from typebag in m.TypeBaggage select new { typebag.ID_TypeBaggage, typebag.Name, typebag.Cost,typebag.Description };
            dataGridbaggage.ItemsSource = query1.ToList();
            dataGridtypebaggage.ItemsSource = query2.ToList();
            

        }
        private void btn_deletebaggage_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить багаж", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                int num = Convert.ToInt32(tb_baggagetoid.Text);
                var dRow = m.Baggage.Where(w => w.ID_Baggage == num).FirstOrDefault();
                m.Baggage.Remove(dRow);
                m.SaveChanges();
                var query = from baggage in m.Baggage select new { baggage.ID_Baggage, baggage.Code, baggage.ID_Client, baggage.ID_TypeBaggage, baggage.Weight };
                dataGridbaggage.ItemsSource = query.ToList();
            }
        }
    
        private void btn_obnovitbaggage_Click(object sender, RoutedEventArgs e)
        {
            var query = from client in m.Client select new { client.ID_Client, client.Surname, client.Name, client.Patronymic, client.ID_Discount };
            dataGridClient.ItemsSource = query.ToList();
            var query1 = from baggage in m.Baggage select new { baggage.ID_Baggage, baggage.Code, baggage.ID_Client, baggage.ID_TypeBaggage, baggage.Weight };
            var query2 = from typebag in m.TypeBaggage select new { typebag.ID_TypeBaggage, typebag.Name, typebag.Cost, typebag.Description };
            dataGridbaggage.ItemsSource = query1.ToList();
            dataGridtypebaggage.ItemsSource = query2.ToList();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            AgentRegistr f3 = new AgentRegistr();
            f3.Show();
            this.Close();
        }

        private void btn_addbaggage_Click(object sender, RoutedEventArgs e)
        {
            AddBaggage f3 = new AddBaggage();
            f3.Show();
            this.Close();
        }

        private void btn_redactbaggage_Click(object sender, RoutedEventArgs e)
        {
            RedactirovanieBaggage f3 = new RedactirovanieBaggage();
            f3.Show();
        }
    }
}
