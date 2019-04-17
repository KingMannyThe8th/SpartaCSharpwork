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

namespace lab_14_wpf_demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        
        
        
      


        void Initialise()
        {
            Label01.FontSize = 8; //font of label 
            Button1.FontSize = 40;//font of button
            Button1.Content = "Click Here"; //"Click here written on button"
        }

        int counter = 0;//initialisation of counter, set to zero

        private void Button1_Click(object sender, RoutedEventArgs e) //click button function
        {
            counter++;//increments the value of counter with each click
            Label01.Content = $"Hey you clicked {counter} times";//text within box
            ListBox01.Items.Add($"Hey you clicked {counter}times");//causes text to be repeated on seperate lines
            ListBox01.FontSize++;//INCREMENT SIZE OF FONT IN LIST BOXES 
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            counter = 0; //resets number of clicks to zero after clearing
            ListBox01.Items.Clear();//clears contents of box
        }
    }
}
