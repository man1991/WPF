using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerModel_Commands
{
    public class CustomerModel_Command
    {
        private string _CustomerName;
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        private double _Amount;
        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        private string _Married;
        public string Married
        {
            get { return _Married; }
            set { _Married = value; }
        }
        private double _Tax;
        public double Tax
        {
            get { return _Tax; }
        }
        public void CalculateTax()
        {
            _Tax = (_Amount * 0.10);
        }
    }
}
