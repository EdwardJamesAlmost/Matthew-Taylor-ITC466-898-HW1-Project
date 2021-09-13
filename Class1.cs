using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Template
{
    public class Appointment : IPurchasable
    {
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double Price { get; set; }

        public void Purchase()
        {
            Console.WriteLine($"Payment for Appointment for {Name} from {StartDateTime} to {EndDateTime} for {Price.ToString("C0")}.");
            
        }
    }

    public class Book : IPurchasable, ITaxable, IShippable
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public double TaxRate { get; set; }

        // needed to add a ShippingRate property and Shio() method to implement the IShippable interface 
        public double ShippingRate { get; set; }

        public void Purchase()
        {
            Console.WriteLine($"Purchasing {Title} for {Price.ToString("C0")}.");
        }

        public double Tax()
        {
            var tax = Price * TaxRate;
            Console.WriteLine($"    TaxRate: {TaxRate.ToString("C2")} = {tax.ToString("C2")}");
            return tax;
        }

        public double Ship()
        {
            Console.WriteLine($"\tShip Rate: {ShippingRate.ToString("C2")}");
            return ShippingRate;

        }
    }

    public class TShirt : IPurchasable, ITaxable, IShippable
    {
        public double Price { get; set; }
        public string Size { get; set; }
        public double TaxRate { get; set; }

        public double ShippingRate { get; set; }
        public void Purchase()
        {
            Console.WriteLine($"Purchasing TShirt {Size} for {Price.ToString("C0")}.");
        }

        public double Tax()
        {
            var tax = Price * TaxRate;
            Console.WriteLine($"    TaxRate: {TaxRate.ToString("C2")} = {tax.ToString("C2")}");
            return tax;
        }

        public double Ship()
        {
            Console.WriteLine($"\tShip Rate: {ShippingRate.ToString("C2")}");
            return ShippingRate;
        }
    }

    public class Snack : IPurchasable
    {
        public double Price { get; set; }

        public void Purchase()
        {
            Console.WriteLine($"Purchasing a snack for {Price.ToString("C0")}.");
        }
    }

    interface IPurchasable
    {
        double Price { get; set; }

        void Purchase();
    }

    interface IShippable
    {
        double ShippingRate { get; set; }
        double Ship();
    }

    interface ITaxable
    {
        double TaxRate { get; set; }
        double Tax();
    }




}
