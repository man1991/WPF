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

namespace WPF_Commands_INotifyPropertyChangedInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private MyCounter obj = new MyCounter();
        public MainWindow()
        {
            InitializeComponent();
        }
        ////It's clearly visible Increment() method is called twice in Window_KeyDown and BtnCounter_Click events.
        ////Different actions are invoking same kind of code, so we have duplicate code across these actions.
        ////What we can do here is take this duplicate code which is scattered across all the actions and put this is into some
        ////central location and than invoke that code from thier rather than repeating the code in every action.
        ////Also we want to get rid of behind codes like bindings wherein by just putting some XAML declarative we were able to
        ////pass data from UI to object
        ////we will write XAML programming to get rid of behind of codes and to acheive this we will use WPF Command class
    
        //private void Window_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.F1)
        //    {
        //        obj.Increment();
        //        Refresh();
        //    }
        //}
        //private void Refresh()
        //{
        //    txtCounter.Text = obj.Counter.ToString(); //takes the current value of the counter and sets it to textbox
        //}
        //private void BtnCounter_Click(object sender, RoutedEventArgs e)
        //{
        //    obj.Increment();
        //    Refresh();
        //}
    }
}
