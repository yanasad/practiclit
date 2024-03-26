using sadovnikovapractika.classes;
using sadovnikovapractika.windows;
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

namespace sadovnikovapractika.windows
{
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void zarega_Click(object sender, RoutedEventArgs e)
        {
            var login = log.Text;
            var password = passw.Text;
            var Email = email.Text;
            var repitt = repit.Text;
            var context = new AppDbContext();
            var user_exists = context.Users.FirstOrDefault(x => x.Login == login);
            if (user_exists != null)
            {
                MessageBox.Show("Логин меняй, уже есть такой");
                  return;
            }
            var user = new User { Login = login, Password = password, Email = Email };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("теперь ты в тиме умников и умниц");

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
       
           MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

      
    }

}
