using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_07_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        void initialize()
        {

         


        }

        int counter = 0; 
        private void Button1_Click(object sender, EventArgs e)
        {
            counter++;//add one to counter

            //display
            label1.Text = "You clicked"    + counter +     "times";
        }

         

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

}
