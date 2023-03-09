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
    /// Логика взаимодействия для RedactirovanieBaggage.xaml
    /// </summary>
    public partial class RedactirovanieBaggage : Window
    {
        public RedactirovanieBaggage()
        {
            InitializeComponent();
        }
        Entities1 m = new Entities1();
        private void RedactBaggage_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from client in m.Client select new { client.ID_Client, client.Surname, client.Name, client.Patronymic, client.ID_Discount };
            dataGridClient.ItemsSource = query.ToList();
            var query1 = from typebag in m.TypeBaggage select new { typebag.ID_TypeBaggage, typebag.Name, typebag.Cost, typebag.Description };
            dataGridtypebag.ItemsSource = query1.ToList();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Baggages f3 = new Baggages();
            f3.Show();
        }

        private void btn_RedactBag_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(tb_redactbaggagetoid.Text);
            var uRow = m.Baggage.Where(w => w.ID_Baggage == num).FirstOrDefault();
            uRow.Code = tb_code.Text;
            uRow.ID_Client = Convert.ToInt32(tb_idclient.Text);
            uRow.ID_TypeBaggage = Convert.ToInt32(tb_typebag.Text);
            uRow.Weight = tb_weight.Text;
            m.SaveChanges();

        }
    }
}
