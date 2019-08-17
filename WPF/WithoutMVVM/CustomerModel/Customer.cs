using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerModel
{
    public class Customer
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
    }
}
