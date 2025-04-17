using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Customer : IComparable
    {
        private string name, address;
        private int age;
        private float amountOwed;

        public Customer(string name, int age, string address, float amountOwed)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.amountOwed = amountOwed;
        }
        public Customer() : this("Unknown", 0, "Unknown", 0.0f)
        { }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public float AmountOwed
        {
            get { return amountOwed; }
            set { amountOwed = (float)Math.Round(value, 2); }
        }

        public string GetInformation()
        {
            return "* Name: " + name + ", Age: " + age + ", Address: " + address + ", Amount Owed (GBP £): " + amountOwed;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Customer customerToCompare = obj as Customer;
            if (customerToCompare != null)
            {
                if ((Name.CompareTo(customerToCompare.Name) == 0) & (Address.CompareTo(customerToCompare.Address) == 0) & (Age == customerToCompare.Age) & (AmountOwed == customerToCompare.AmountOwed))
                    return 1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Object is not a Customer");
        }

        public bool isLessThan(Customer customerToCompare)
        {
            return (this.CompareTo(customerToCompare) == 0 & customerToCompare.AmountOwed < AmountOwed);
        }
        public bool isGreaterThan(Customer customerToCompare)
        {
            return (this.CompareTo(customerToCompare) == 0 & customerToCompare.AmountOwed > AmountOwed);
        }
    }
}
