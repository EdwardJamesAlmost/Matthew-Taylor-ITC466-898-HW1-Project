using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal  // Base class (parent) 
{

    // the animalSound() method needed to be declared virtual to allow for subclass override methods. 
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public override void animalSound() // the method signature may need to be modified
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

