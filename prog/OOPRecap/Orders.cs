using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRecap
{
    internal class Orders
    {
        // Objects
        private string orderId;
        private string customerName;
        private int numberOfBurgers;
        private int numberOfDrinks;

        public Orders() { }

        public Orders(string orderId, string customerName, int numberOfBurgers, int numberOfDrinks)
        {
            this.orderId = orderId;
            this.customerName = customerName;
            this.numberOfBurgers = numberOfBurgers;
            this.numberOfDrinks = numberOfDrinks;
        }

        public string getOrderId { get { return orderId; } }
        public string getCustomerName { get { return customerName; } }
        public int getNumberOfBurgers { get { return numberOfBurgers; } }
        public int getNumberOfDrinks { get { return numberOfDrinks; } }

        public void setOrderId(string orderId)
        {
            this.orderId = orderId;
        }

        public void setCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        public void setNumberOfBurgers(int numberOfBurgers)
        {
            this.numberOfBurgers = numberOfBurgers;
        }

        public void setNumberOfDrinks(int numberOfDrinks)
        {
            this.numberOfDrinks = numberOfDrinks;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return "[OrderId: " + this.orderId + "; CustomerName: " +this.customerName + "; NumberOfBurgers: " + this.numberOfBurgers + "; NumberOfDrinks: " + this.numberOfDrinks + "]";
        }
    }
}
