using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerModel;

/// <summary>
/// Whatever data you are exposing from ViewModel it should be of least denominator datatype 
/// Look at the naming convention how they are reflecting UI properties e.g. txtCustomername -> Customer Name, IsMarried -> Married
/// </summary>
namespace CustomerViewModel
{
    //all the hits from View will come to CustomerViewModel and CustomerViewModel will then send requests to Customer class
    public class CustomerViewModel
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
            set { obj.Amount = Convert.ToInt16(value); }
        }
        public string LblAmountColor
        {
            get
            {
                if(obj.Amount > 2000)
                {
                    return "Blue";
                }
                else if(obj.Amount > 1500)
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
                if(value == true)
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
                if(obj.Married == "Married")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
