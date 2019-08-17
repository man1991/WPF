using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CustomerModel_Commands;
using System.Windows.Input;

namespace CustomerViewModel_Commands
{
    public class CustomerViewModel_Commands : INotifyPropertyChanged
    {
        private CustomerModel_Command obj = new CustomerModel_Command();
        private btnClick ocommand;
        public CustomerViewModel_Commands()
        {
            ocommand = new btnClick(this);
        }
        public ICommand btnClick
        {
            get
            {
                return ocommand;
            }
        }
        public string txtCustomername
        {
            get { return obj.CustomerName; }
            set { obj.CustomerName = value; }
        }
        public string txtAmount
        {
            get { return obj.Amount.ToString(); }
            set
            {
                obj.Amount = Convert.ToInt16(value);
                Refresh("LblAmountColor");
            }
        }
        private void Refresh(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
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
        public string txtTax
        {
            get { return obj.Tax.ToString(); }
        }
        public void CalculateTax()
        {
            obj.CalculateTax();
            Refresh("txtTax");
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
    public class btnClick : ICommand
    {
        private CustomerViewModel_Commands obj;
        public btnClick(CustomerViewModel_Commands o)
        {
            obj = o;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)//validations
        {
            return true;
        }
        public void Execute(object parameter)//actual logic
        {
            obj.CalculateTax();
        }
    }

}
