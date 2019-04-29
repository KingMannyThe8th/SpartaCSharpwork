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

namespace lab_52_WPF_Grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Customer> customers; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "Clicked";



            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();

                foreach (var customer in customers)
                {
                    //ListBox01.Items.Add(customer.ContactName); 
                }

                ListBox02.ItemsSource = db.Customers.ToList(); 

            }


        }





    }
}
