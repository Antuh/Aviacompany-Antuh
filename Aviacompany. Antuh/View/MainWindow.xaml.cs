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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Aviacompany.Antuh.View;

namespace Aviacompany.Antuh
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = tb_login.Text;
            string password = tb_password.Password;
            Entities1 m = new Entities1();
            var authorization = m.Authorization;


            var user = authorization.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
            if (user != null)
            {
                int idpost = user.Staff.ID_Post;
                switch (idpost)
                {
                    /*case 1:
                        Window1 f = new Window1();
                        f.Show();
                        break;
                    case 2:
                        Window2 f2 = new Window2();
                        f2.Show();
                        break;*/
                    case 3:
                        AgentRegistr f3 = new AgentRegistr();
                        f3.Show();
                        this.Close();
                        break;
                    case 5:
                        Meteorolog f4 = new Meteorolog();
                        f4.Show();
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }
    }
}


