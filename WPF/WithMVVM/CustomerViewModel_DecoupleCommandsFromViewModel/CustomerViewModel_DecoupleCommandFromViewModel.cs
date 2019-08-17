using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using CustomerModel_Commands;

namespace CustomerViewModel_DecoupleCommandsFromViewModel
{
    public class CustomerViewModel_DecoupleCommandFromViewModel : INotifyPropertyChanged
    {
        private CustomerModel_Command obj = new CustomerModel_Command();
        private btnClick ocommand;
        public CustomerViewModel_DecoupleCommandFromViewModel()
        {
            ocommand = new btnClick(CalculateTax, IsValid);
        }
        public bool IsValid()
        {
            if(obj.Amount < 0)
            {
                return false;
            }
            return true;
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
                ocommand.Refresh();//to refresh command
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
        private Action WhatToExecute;
        private Func<bool> WhenToExecute;
        public btnClick(Action What, Func<bool> When)
        {
            WhatToExecute = What;
            WhenToExecute = When;
        }
        public void Refresh()//to refresh command
        {
            if(CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)//validations
        {
            return WhenToExecute();
        }
        public void Execute(object parameter)//actual logic
        {
            WhenToExecute();
        }
    }
}

