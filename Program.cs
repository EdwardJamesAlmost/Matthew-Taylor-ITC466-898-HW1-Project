



using static System.Console;
using System.Collections.Generic;
using System;

namespace Homework_Template
{
    /// <summary>
    /// Repository Link: 
    ///
    /// EX 1 video link:
    ///
    /// EX 2 video link:
    /// 
    /// EX 3 video link:
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");

        }
        public static string DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Homework ?");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine("Hit [5] to run Exercise 5.");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;


        }
        private static bool Run(string exeArg)

        {
            switch (exeArg.ToLower())
            {

                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "4":
                    DoExe4();
                    return true;

                case "5":
                    DoExe5();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }

        private static void DoExe1()
        {
            
            // this one neede dot have changes made to thte 
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            //the virtual method animalSound is overridden by the override methods for Pig and Dog objects
            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            //throw new NotImplementedException();
        }


        private static void DoExe2()
        {
            var player = new Player() { Name = "Bob", Strength = 20 };
            var warrior = new Warrior() { Name = "Baltek", Strength = 100, Bonus = 10 };
            var wizard = new Wizard() { Name = "Pentagorn", Strength = 50, Energy = 50 };

            var players = new List<Player>();
            players.Add(player);
            players.Add(warrior);
            players.Add(wizard);


            // the DoBattle method is modified
            DoBattle(players);

            Console.ReadLine();
        }


        //throw new NotImplementedException();
    

    private static void DoExe3()
    {
            // Add code for Exercise 2 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            var appointment = new Appointment()
            {
                Name = "Bob",
                StartDateTime = DateTime.Now.AddHours(1),
                EndDateTime = DateTime.Now.AddHours(2),
                Price = 100D
            };

            var book = new Book()
            {
                Title = "How to Implement Interfaces",
                Price = 50D,
                TaxRate = 0.0825D,
                ShippingRate = 5D
            };

            var snack = new Snack()
            {
                Price = 2D
            };

            var tshirt = new TShirt()
            {
                Size = "2X",
                Price = 25D,
                TaxRate = 0.0625D,
                ShippingRate = 2D
            };

            var items = new List<IPurchasable>();
            items.Add(appointment);
            items.Add(book);
            items.Add(snack);
            items.Add(tshirt);

            var taxableItems = new List<ITaxable>();
            foreach (var item in items)
            {
                if (item is ITaxable)
                {
                    taxableItems.Add(item as ITaxable);
                }
            }


            var taxAmount = CalculateTax(taxableItems);
            // also outputs individual line items as directed in the Tax() methods of classes that implement ITaxable

            Console.WriteLine($"Total tax amount: {taxAmount.ToString("C2")}");


            var shippableItems = new List<IShippable>();
            foreach (var item in items)
            {
                if (item is IShippable)
                {
                    shippableItems.Add(item as IShippable);
                }
            }
            var shippingAmount = CalculateShipping(shippableItems);
            Console.WriteLine($"Total shipping amount: {shippingAmount.ToString("C2")}");



            double invoice_total = CompleteTransaction(items);

            Console.WriteLine("=========================");
            invoice_total += (shippingAmount + taxAmount);
            string grand_total = invoice_total.ToString("C2");
            Console.WriteLine($"Grand Total: {grand_total}");

            Console.ReadLine();



            //throw new NotImplementedException();
        }

   

    private static void DoExe4()
    {
        // Add code for Exercise 4 here
        // Remove "throw new NotImplementedException()" line of code 
        //  once you add your code.
        throw new NotImplementedException();
    }

    private static void DoExe5()
    {
        // Add code for Exercise 5 here
        // Remove "throw new NotImplementedException()" line of code 
        //  once you add your code.
        throw new NotImplementedException();
    }


    static void DoBattle(List<Player> players)
    {
        foreach (var player in players)
        {
            // this is the polymorphic behavior. Objects of the Player class are passed to the PlayerAttack method, which is a static method of the Player class that takes a Player object as a parameter. The parameter then calls the Attack method, whose implementation depends on whether the Player object is actually a subclass.

            Player.PlayerAttack(player);
            Console.WriteLine("");
        }
    }


        static double CalculateTax(List<ITaxable> items)
        {
            double tax = 0D;

            foreach (var item in items)
            {
                tax += item.Tax();
            }

            return tax;

        }

        static double CalculateShipping(List<IShippable> items)
        {
            double shipping = 0D;
            // missing from starter code
            foreach (var item in items)
            {
                shipping += item.Ship();
            }

            return shipping;
        }

        static double CompleteTransaction(List<IPurchasable> items)
        {
            double total = 0;
            items.ForEach(p => p.Purchase());

            // added a total variable and a foreach loop to aggregate the invoice total of a list of items.
            foreach (var item in items)
            {
                total += item.Price;
            }

            return total;

        }

    }// end Program class


} //end homework_template namespace


/*

Contact GitHub
Pricing
API
Training
Blog
About*/