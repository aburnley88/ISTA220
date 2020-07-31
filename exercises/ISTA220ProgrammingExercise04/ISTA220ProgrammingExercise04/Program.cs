using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ISTA220ProgrammingExercise04
{
    class Program
    {

        static void Main(string[] args)
        {
            Pig Babe = new Pig();
            Babe.sayName("Babe");
            Babe.Speak();
            Babe.Eat();
            Babe.benefit();

            Horse Ed = new Horse();
            Ed.sayName("Mr. Ed to you!");
            Ed.Speak();
            Ed.Eat();
            Ed.benefit();

            Cow Isis = new Cow();
            Isis.sayName("Isis the Goddess");
            Isis.Speak();
            Isis.Eat();
            Isis.benefit();

            Rabbit bugs = new Rabbit();
            bugs.sayName("Sir Bugguswald Bunny");
            bugs.Speak();
            bugs.Eat();
            bugs.benefit();

            Horse SB = new Horse();
            SB.sayName("SeaBiscuit the prize horse!!");
            SB.Speak();
            SB.Eat();
            SB.benefit();

            Rabbit PR = new Rabbit();
            PR.sayName("The young Peter Rabbit");
            PR.Speak();
            PR.Eat();
            PR.benefit();

        }
        class Animal
        {

            public virtual void Speak()
            {
                Console.WriteLine("rawr");
            }
            public virtual void sayName(string name)
            {
                Console.WriteLine($"My name is {name}");
            }
            public virtual void Eat()
            {
                Console.WriteLine("I like to eat yum-yums");
            }
            public virtual void benefit()
            {
                Console.WriteLine("I am a blessing to society!");
            }
        }


        class Pig : Animal
        {
            public Pig()
            {

            }
            public override void Speak()
            {
                Console.WriteLine(" I say oink");
            }
            public override void sayName(string name)
            {
                Console.WriteLine($"My name is {name}");
            }
            public override void Eat()
            {
                Console.WriteLine("I like to eat slop!");
            }
            public override void benefit()
            {
                Console.WriteLine("I feed the world with bacon and other pork products");
            }

        }
        class Horse : Animal
        {
            public Horse()
            {

            }
            public override void Speak()
            {
                Console.WriteLine(" I say naaay");
            }
            public override void sayName(string name)
            {
                Console.WriteLine($"My name is {name}");
            }
            public override void Eat()
            {
                Console.WriteLine("I like to eat oats!");
            }
            public override void benefit()
            {
                Console.WriteLine("I have been used for centuries in warefare, sport, and transportation!");
            }

        }
        class Cow : Animal
        {
            public Cow()
            {

            }
            public override void Speak()
            {
                Console.WriteLine(" I say moooo");
            }
            public override void sayName(string name)
            {
                Console.WriteLine($"My name is {name}");
            }
            public override void Eat()
            {
                Console.WriteLine("I like to eat grass");
            }
            public override void benefit()
            {
                Console.WriteLine("What don't I do? From beef to dairy to spiritual nourishment--I do it all!");
            }

        }
        class Rabbit : Animal
        {
            public Rabbit()
            {

            }
            public override void Speak()
            {
                Console.WriteLine(" I say \"Whats up doc?");
            }
            public override void sayName(string name)
            {
                Console.WriteLine($"My name is {name}");
            }
            public override void Eat()
            {
                Console.WriteLine("I like to eat grass");
            }
            public override void benefit()
            {
                Console.WriteLine("You hunt me, worship me, and keep me as pets!");
            }

        }
    }
}