using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    static class StringExtensions   //extension
    {
        public static bool IsContatinsDigit(this string str)
        {
            return str.Any(char.IsDigit);   //number constraint
        }
    }

    abstract class Person   //base class
    {
        protected string Name;

        public Person(string name)
        {
            if (name.IsContatinsDigit())
            {
                throw new ArgumentException("Name cannot contain digits!");
            }
            Name = name;
        }
    }
    class Customer : Person  //class customer            
    {
        private string PhoneNumber;

        public Customer(string name, string phoneNumber) : base(name) 
        {
            if (phoneNumber.IsContatinsDigit())
            {
                throw new ArgumentException("Phone number cannot contain digits!");
            }
            PhoneNumber = phoneNumber;
        }

        public static bool operator ==(Customer cust1, Customer cust2) => cust1.Equals(cust2);
        public static bool operator !=(Customer cust1, Customer cust2) => !cust1.Equals(cust2);

        public override string ToString()
        {
            return $"Name: {Name}, PhoneNumber: {PhoneNumber}";
        }
    }

    class Cash { };

    class Cart { };     

    abstract class Delivery<TPayment>
    {
        public TPayment Payment { get; set; }
        public string Address;
        public static int DeliveyPhoneNumbe;// = ...
    }

    class HomeDelivery<T> : Delivery<T> where T : Cart
    {
        public DateTime DeliveryTime { get; set; }
    }

    class PickPointDelivery<T> : Delivery<T>
    {
        public string PickPointId { get; set; }
    }

    class ShopDelivery<T> : Delivery<T>
    {
        public string ShopName { get; set; }
    }

    class Order<TDelivery, TPayment> where TDelivery : Delivery<TPayment>
    {
        public Customer customer;
        public TDelivery Delivery;
        public int Number;
        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
    }
}