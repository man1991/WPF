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

namespace WPF_Events
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

        //for Direct Events
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            ////this would work when mouse is hovered over button
            //MessageBox.Show("Button Mouse Enter");
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            ////this would not work when mouse is hovered over grid
            //MessageBox.Show("Grid Mouse Enter");
        }

        //for Bubbling Events
        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ////For Button_MouseDown right click on button when application is run
            //MessageBox.Show("Button Mouse Down Event");
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Grid Mouse Down Event");
        }

        //For Tunneling events
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("TextBox Preview KeyDown Event");
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Grid Preview KeyDown Event");

            //if you want to cancel the propagation means only Window and Grid should fire and TextBox should not fire
            //this can be done/ holds true for for Tunneling, Bubbling, Direct events
            e.Handled = true;//will not fire further events
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window Preview KeyDown Event");
        }
    }
}
