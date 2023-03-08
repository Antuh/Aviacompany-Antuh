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
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        Entities1 m = new Entities1();
        Entities1 ms = Helper.getContext();
        public AddClient()
        {
            InitializeComponent();
        }
        
        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            string name = tb_name.Text;
            string surname = tb_surname.Text;
            string patronymic = tb_patronymic.Text;
            int discount = Convert.ToInt32(tb_discount.Text);
            string seriapasport = tb_seriapas.Text;
            string numberpassport = tb_nomerpasp.Text;
            string seriavisa = tb_seriavis.Text;
            string numbervisa = tb_nomervisa.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname)
                && string.IsNullOrEmpty(patronymic))
       
            {
                MessageBox.Show("Не все нужные данные введены");
            }
            else if (int.TryParse(name, out int n) || int.TryParse(surname, out int s)
                || int.TryParse(patronymic, out int p))
            {
                MessageBox.Show("Данные введены не корректно");
            }
            {
                int idpassport = Helper.GetLastIDPassport();
                int idvisa = Helper.GetLastIDVisa();
                int idclient = Helper.GetLastIDclient();
                Client client = new Client {ID_Client = idclient, Name = name, Surname = surname, Patronymic = patronymic, ID_Discount = discount };
                Passport passport = new Passport { ID_Passport = idpassport, Series = seriapasport, Number = numberpassport };
                Visa visa = new Visa { ID_Visa = idvisa, Series = seriavisa, Number = numbervisa };
                Helper.Create(client, passport, visa);
                MessageBox.Show("Клиент добавлен");
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Clients f3 = new Clients();
            f3.Show();
            this.Close();
        } 
    }
}
