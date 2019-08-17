using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF_MultiBinding_MultiConverter
{
    public class NameMultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string firstLastname = "";
            foreach(object x in values)
            {
                firstLastname = firstLastname + " " + x;
            }
            return firstLastname;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            string str = (string)value;
            string[] arr = str.Split(' ');
            return arr;
        }
    }
}
