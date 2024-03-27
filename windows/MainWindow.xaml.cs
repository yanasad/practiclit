using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic.Logging;
using sadovnikovapractika.classes;
using sadovnikovapractika.windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace sadovnikovapractika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void registrac_Click(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();

            reg.Show();

            this.Hide();
         
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        { 
           Environment.Exit(0);
        }

        private void vxod_Click(object sender, RoutedEventArgs e)
        {
            var login = log.Text;
            var password = passw.Text;
            var context = new AppDbContext();
            var user = context.Users.SingleOrDefault(x => x.Login == login || x.Email == login && x.Password == password);
            if (user != null)
            {
                MessageBox.Show("Такого пользователя не существует(");
                return;

            }
            Pusto pusto = new Pusto();
            pusto.Show();
            this.Hide();


        }
        
    }
}