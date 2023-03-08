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
    /// Логика взаимодействия для RedactirovanieClient.xaml
    /// </summary>
    public partial class RedactirovanieClient : Window
    {
        Entities1 m = new Entities1();
        Entities1 ms = Helper.getContext();
        public RedactirovanieClient()
        {
            InitializeComponent();
        }

        private void btn_redact_Click(object sender, RoutedEventArgs e)
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
            }
            int num = Convert.ToInt32(tb_redacttoid.Text);
            var uRow = m.Client.Where(w => w.ID_Client == num).FirstOrDefault();
            var pRow = m.Passport.Where(w => w.ID_Passport == num).FirstOrDefault();
            var vRow = m.Visa.Where(w => w.ID_Visa == num).FirstOrDefault();
            uRow.Name = tb_name.Text;
            uRow.Surname = tb_surname.Text;
            uRow.Patronymic = tb_patronymic.Text;
            uRow.ID_Discount = Convert.ToInt32(tb_discount.Text);
            pRow.Number = tb_nomerpasp.Text;
            pRow.Series = tb_seriapas.Text;
            vRow.Number = tb_nomervisa.Text;
            vRow.Series = tb_seriavis.Text;
            m.SaveChanges();
            
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Clients f3 = new Clients();
            f3.Show();
        }
    }
}
