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
//using CustomerModel;

namespace WithoutMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowWithoutMVVM : Window
    {
        //private Customer obj = new Customer();
        public MainWindowWithoutMVVM()
        {
            InitializeComponent();
            //obj.CustomerName = "Manish";
            //obj.Amount = 2000;
            //obj.Married = "Married";
            //DisplayUi(obj);
        }
        //private void DisplayUi(Customer o)
        //{
        //    lblName.Content = o.CustomerName; //binding code
        //    lblAmount.Content = o.Amount; //binding code
        //    if(o.Amount > 2000) //conversion code + binding code = transformation code
        //    {
        //        lblBuyingHabits.Background = new SolidColorBrush(Colors.Blue);
        //    }
        //    else if(o.Amount > 1500)
        //    {
        //        lblBuyingHabits.Background = new SolidColorBrush(Colors.Red);
        //    }
        //    if(obj.Married == "Married") //conversion code +binding code = transformation code
        //    {
        //        chkMarried.IsChecked = true;
        //    }
        //    else
        //    {
        //        chkMarried.IsChecked = false;
        //    }
        //}
    }
}
