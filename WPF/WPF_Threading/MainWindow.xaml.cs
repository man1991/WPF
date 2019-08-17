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
using System.Threading;

namespace WPF_Threading
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread obj = new Thread(new ThreadStart(SetText));
            obj.Start();
        }
        private void SetText()
        {
            //Modifying variables, strings, custom objects, .NET objects is allowed

            // this code has to be executed via dispatcher as txt1 is created by Main()
            //WPF UI objects like TextBox, Grid, Buttons this objects has to be executed via an dispatcher
            this.Dispatcher.Invoke(() =>
                                        { txt1.Text = "Set Text By Threading"; });
        }
    }
}
