using Assignment4OOP.InterfaceEx02;
using Assignment4OOP.Interfaces;
using Assignment4OOP.InterfacesEx01;
using System.Runtime.Intrinsics.X86;

namespace Assignment4OOP
{

    internal class Program
    {
        #region Part01-Interface Example 01
        //public static void Print10NumbersFromSeries(ISeries series)
        //{
        //    if (series == null)
        //        return;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current}\t");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //} 

        ////public static void Print10NumbersFromSeries(SeriesByThree series)
        ////{
        ////    if (series == null)
        ////        return;
        ////    for (int i = 0; i < 10; i++)
        ////    {
        ////        Console.Write($"{series.Current}\t");
        ////        series.GetNext();
        ////    }
        ////    series.Reset();
        ////    Console.WriteLine();
        ////}
        #endregion


        static void Main(string[] args)
        {
            #region Part01-Interface Example 01 
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //SeriesByThree seriesByThree = new SeriesByThree();

            //ISeries series = new SeriesByTwo();

            //Print10NumbersFromSeries(series);     
            #endregion

            #region Part01-Interface Example 02 (Implicitly Vs Explicitly)
            //Airplane airplane = new Airplane();

            //IMovable airplaneMovable = new Airplane();
            //IFlyable airplaneFlyable = new Airplane();

            //airplaneMovable.Forward();
            //airplaneFlyable.Forward(); 
            #endregion

            #region Part01 - (Deep Copy Vs Shallow Copy) [array of value type]
            int[] arr01 = { 1, 2, 3 };
            int[] arr02 = { 4, 5, 6 };

            Console.WriteLine($"Hash Code arr01 => {arr01.GetHashCode()}");
            Console.WriteLine($"Hash Code arr02 => {arr02.GetHashCode()}");

            #region Shallow Copy
            //// Shallow Copy
            //arr02 = arr01;
            //// the object { 1, 2, 3 } has 2 references
            //// the object { 4, 5, 6 } is unreachable
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"Hash Code arr01 => {arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Code arr02 => {arr02.GetHashCode()}");

            //arr02[0] = 100;
            //Console.WriteLine(arr01[0]); // 100 
            #endregion

            #region Deep Copy
            //arr02 = (int[]) arr01.Clone();
            //// Clone :
            //// - Will generate new object with new address
            //// - this object will have the same Data of Caller Object
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Hash Code arr01 => {arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Code arr02 => {arr02.GetHashCode()}");

            //arr02[0] = 100;
            //Console.WriteLine(arr01[0]); // 1 
            #endregion
            #endregion

            #region Part02
            #region Part02-Q1
            // Question 1:
            // What is the primary purpose of an interface in C#?
            //    a) To provide a way to implement multiple inheritance
            //    b) To define a blueprint for a class
            //    c) To declare abstract methods and properties
            //    d) To create instances of objects

            // Answer => b) To define a blueprint for a class
            #endregion

            #region Part02-Q2
            //Question 2:
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //    a) private
            //    b) protected
            //    c) internal
            //    d) public

            // Answer => a) Private (Except Default emplemented method) & b) Protected
            #endregion

            #region Part02-Q3
            //Question 3:
            //Can an interface contain fields in C#?
            //    a) Yes
            //    b) No
            //    c) Only if they are static
            //    d) Only if they are readonly

            // Answer => b) No

            #endregion

            #region Part02-Q4
            //Question 4:
            //In C#, can an interface inherit from another interface?
            //    a) No, interfaces cannot inherit from each other
            //    b) Yes, interfaces can inherit from multiple interfaces
            //    c) Yes, but only if they have the same methods
            //    d) Only if the interfaces are in the same namespace

            // Answer => b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            #region Part02-Q5
            //Question 5:
            //Which keyword is used to implement an interface in a class in C#?
            //    a) inherit
            //    b) use
            //    c) extends
            //    d) implements

            // Answer => None of the options are correct, as C# uses the : symbol to implement an interface in a class.
            #endregion

            #region Part02-Q6
            //Question 6:
            //Can an interface contain static methods in C#?
            //    a) Yes
            //    b) No
            //    c) Only if the interface is sealed
            //    d) Only if the methods are private

            // Answer => a) Yes
            #endregion

            #region Part02-Q7
            //Question 7:
            //In C#, can an interface have explicit access modifiers for its members?
            //    a) Yes, for all members
            //    b) No, all members are implicitly public
            //    c) Yes, but only for abstract members
            //    d) Only if the interface is sealed

            // Answer => b) No, all members are implicitly public
            #endregion

            #region Part02-Q8
            //Question 8:
            //What is the purpose of an explicit interface implementation in C#?
            //    a) To hide the interface members from outside access
            //    b) To provide a clear separation between interface and class members
            //    c) To allow multiple classes to implement the same interface
            //    d) To speed up method resolution

            // Answer => b) To provide a clear separation between interface and class members
            #endregion

            #region Part02-Q9
            //Question 9:
            //In C#, can an interface have a constructor?
            //    a) Yes, but it must be private
            //    b) No, interfaces cannot have constructors
            //    c) Yes, but only if the interface is sealed
            //    d) Only if the constructor is static

            // Answer => b) No, interfaces cannot have constructors
            #endregion

            #region Part02-Q10
            //Question 10:
            //How can a C# class implement multiple interfaces?
            //    a) By using the "implements" keyword
            //    b) By using the "extends" keyword
            //    c) By separating interface names with commas
            //    d) A class cannot implement multiple interfaces

            // Answer => c) By separating interface names with commas
            #endregion
            #endregion

        }
    }
}
