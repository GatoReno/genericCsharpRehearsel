using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace GenericsRehearsel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animals! \n ----- \n");

            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Animal(){ Name = "Dragon" });
            animalList.Add(new Animal(){ Name = "Cat" });
            animalList.Add(new Animal(){ Name = "Crow" });

            animalList.Insert(0, new Animal() { Name = "Turtle" });

            foreach (var item in animalList)
            {
                Console.WriteLine(item.Name);
            }

            int x = 5, y = 4;
            Animal.GetSum(ref x, ref y);
            string stX = "4", stY = "5";
            Animal.GetSum(ref stX, ref stY);

            //Stack<T> st = new Stack<T>();

            Rectangle<int> rec1 = new Rectangle<int>(2,5);

            Console.WriteLine(rec1.GetArea());

            // delegate object

            Arithmethic add, sub, addSub;

            add = new Arithmethic(Add);
            sub = new Arithmethic(Subtraction);
            
            addSub = add + sub;
            //sub = addSub - add;

            Console.WriteLine($"add 6 & 10 ");
            add(6, 10);

            Console.WriteLine($"add 20 & 10 ");
            sub(20, 10);

            Console.ReadLine();
        }

        // T refers to the Generic Class
        public struct Rectangle<T> {
            private T width;
            private T length;
            public T Width { 
                get { return width; }
                set { width = value; }
            }

            public T Length
            {
                get { return length; }
                set { length = value; }
            }

            public Rectangle(T w , T l) {
                width = w;
                length = l;
            }

            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(Width);
                double dblLength = Convert.ToDouble(Length);

                double res = dblLength * dblWidth;
                return "Rectangle Area : "+res.ToString();
            }
        }


        //Delegates

        public delegate void Arithmethic(double num1, double num2);

        // this delegate can asign methods that are void and resive 2 params 

        public static void Add(double num1, double num2) {
            Console.WriteLine($" {num1} + {num2} = {num1 + num2} ");
        }

        public static void Subtraction(double num1, double num2)
        {
            Console.WriteLine($" {num1} - {num2} = {num1 - num2} ");
        }


    }
}
