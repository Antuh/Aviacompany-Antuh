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
    /// Логика взаимодействия для AddBaggage.xaml
    /// </summary>
    public partial class AddBaggage : Window
    {
        public AddBaggage()
        {
            InitializeComponent();
        }
        Entities1 m = new Entities1();
        Entities1 ms = Helper.getContext();
        private void AddBaggage_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from client in m.Client select new { client.ID_Client, client.Surname, client.Name, client.Patronymic, client.ID_Discount };
            dataGridClient.ItemsSource = query.ToList();
            var query1 = from typebag in m.TypeBaggage select new { typebag.ID_TypeBaggage, typebag.Name, typebag.Cost, typebag.Description };
            dataGridtypebag.ItemsSource = query1.ToList();
        }

        private void btn_AddBag_Click(object sender, RoutedEventArgs e)
        {
            string code = tb_code.Text;
            int idclient = Convert.ToInt32(tb_idclient.Text);
            int idtypebag = Convert.ToInt32(tb_typebag.Text);
            string weight = tb_weight.Text;
            Baggage baggage = new Baggage {Code = code, ID_Client = idclient, ID_TypeBaggage = idtypebag, Weight = weight};
            Helper.CreateBaggage(baggage);
            MessageBox.Show("Багаж добавлен");
            
        }
        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Baggages f3 = new Baggages();
            f3.Show();
            this.Close();
        }
    }
}
