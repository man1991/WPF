using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerModel;
using System.ComponentModel;

namespace CustomerViewModel_INotifyPropertyChange
{
    public class CustomerViewModel_INotifyPropertyChange : INotifyPropertyChanged
    {
        private Customer obj = new Customer();
        public string txtCustomername
        {
            get { return obj.CustomerName; }
            set { obj.CustomerName = value; }
        }
        public string txtAmount
        {
            get { return obj.Amount.ToString(); }
            set {
                obj.Amount = Convert.ToInt16(value);
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("LblAmountColor"));
                }
            }
        }
        public string LblAmountColor
        {
            get
            {
                if (obj.Amount > 2000)
                {
                    return "Blue";
                }
                else if (obj.Amount > 1500)
                {
                    return "Red";
                }
                return "Yellow";
            }
        }
        public bool IsMarried
        {
            set
            {
                if (value == true)
                {
                    obj.Married = "Married";
                }
                else
                {
                    obj.Married = "Unmarried";
                }
            }
            get
            {
                if (obj.Married == "Married")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
