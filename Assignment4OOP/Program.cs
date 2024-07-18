using Assignment4OOP.IClonable;
using Assignment4OOP.InterfaceEx02;
using Assignment4OOP.Interfaces;
using Assignment4OOP.InterfacesEx01;
using Assignment4OOP.Part03Q01;
using Assignment4OOP.Part03Q02;
using Assignment4OOP.Part03Q03;
using System;
using System.Data;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            //int[] arr01 = { 1, 2, 3 };
            //int[] arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Hash Code arr01 => {arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Code arr02 => {arr02.GetHashCode()}");

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

            #region Part01 - (Deep Copy Vs Shallow Copy) [array of Reference type (String)]
            //string[] name01 = new string[] { "omar" };
            //string[] name02 = new string[1];

            //Console.WriteLine($"Hash Code name01 => {name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code name02 => {name02.GetHashCode()}");

            #region Shallow Copy
            //name02 = name01;
            //Console.WriteLine($"Hash Code name01 => {name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code name02 => {name02.GetHashCode()}");

            //Console.WriteLine(name01[0]); // omar
            //Console.WriteLine(name02[0]); // omar

            //name02[0] = "mona";
            //Console.WriteLine(name01[0]); // mona
            //Console.WriteLine(name02[0]); // mona
            #endregion

            #region Deep Copy
            //name02 = (string[]) name01.Clone();
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Hash Code name01 => {name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code name02 => {name02.GetHashCode()}");

            //Console.WriteLine(name01[0]); // omar
            //Console.WriteLine(name02[0]); // omar

            //name02[0] = "mona";
            //Console.WriteLine("After change");
            //Console.WriteLine(name01[0]); // omar
            //Console.WriteLine(name02[0]); // mona
            #endregion
            #endregion

            #region Part01 - (Deep Copy Vs Shallow Copy) [array of Reference type (StringBuilder)]
            //StringBuilder[] name01 = new StringBuilder[1];
            ////name01[0].Append("omar"); // null ref exception
            //name01[0] = new StringBuilder("Omar");

            //StringBuilder[] name02 = new StringBuilder[1];

            //Console.WriteLine($"Hash Code name01 => {name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code name02 => {name02.GetHashCode()}");

            #region Shallow Copy
            //name02 = name01;
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"Hash Code name01 => {name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code name02 => {name02.GetHashCode()}");

            //Console.WriteLine(name01[0]); // omar
            //Console.WriteLine(name02[0]); // omar

            //name02[0].Append( " Ahmed" );
            //Console.WriteLine("After change");
            //Console.WriteLine(name01[0]); // Omar Ahmed
            //Console.WriteLine(name02[0]); // Omar Ahmed
            #endregion

            #region Deep Copy
            //name02 = (StringBuilder[]) name01.Clone();
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Hash Code name01 => {name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code name02 => {name02.GetHashCode()}");

            //Console.WriteLine(name01[0]); // omar
            //Console.WriteLine(name02[0]); // omar

            //name02[0].Append(" Ahmed");
            //Console.WriteLine("After change");
            //Console.WriteLine(name01[0]); // Omar Ahmed
            //Console.WriteLine(name02[0]); // Omar Ahmed
            #endregion
            #endregion

            #region Part01 - IClonable
            //Employee emp01 = new Employee()
            //{
            //    Id = 10,
            //    Name = "Ali",
            //    Salary = 3_000
            //};

            //Employee emp02 = new Employee()
            //{
            //    Id = 20,
            //    Name = "Mona",
            //    Salary = 5_000
            //};

            //Console.WriteLine($"Hash Code emp01 => {emp01.GetHashCode()}");
            //Console.WriteLine($"Hash Code emp02 => {emp02.GetHashCode()}");

            ////Employee emp03 = emp01; // Shallow Copy

            //Employee emp03 = (Employee)emp01.Clone(); // Deep Copy
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Hash Code emp01 => {emp01.GetHashCode()}");
            //Console.WriteLine($"Hash Code emp03 => {emp03.GetHashCode()}");

            //Console.WriteLine(emp01);
            //Console.WriteLine(emp03);
            #endregion

            #region Part01 - IComparable
            //int[] Numbers = { 7, 2, 8, 66, 5 };

            //Array.Sort( Numbers );

            //Employee[] employees =
            //{
            //    new Employee() {Id = 10, Name = "omar", Salary = 3_000},
            //    new Employee() {Id = 20, Name = "ali", Salary = 6_000},
            //    new Employee() {Id = 30, Name = "mona", Salary = 7_000},
            //};

            //Array.Sort(employees);

            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}
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


            // Question 01:
            // Define an interface named IShape with a property Area and a method DisplayShapeInfo.
            // Create two interfaces, ICircle and IRectangle, that inherit from IShape.
            // Implement these interfaces in classes Circle and Rectangle.
            // Test your implementation by creating instances of both classes and displaying their shape information.
            #region Part03Q01
            //// Create instances of Circle and Rectangle
            //Circle circle = new Circle(5.0);
            //Rectangle rectangle = new Rectangle(4.0, 3.0);

            //// Display shape information
            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo(); 
            #endregion


            // Question 02:
            // In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser.
            // The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
            // In the BasicAuthenticationService class,
            // the AuthenticateUser method compares the provided username and password with the stored credentials.
            // It returns true if the user is authenticated and false otherwise.
            // The AuthorizeUser method checks if the user with the given username has the specified role.
            // It returns true if the user is authorized and false otherwise.
            // In the Main method,
            // we create an instance of the BasicAuthenticationService class
            // and assign it to the authService variable of type IAuthenticationService.
            // We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.
            // This implementation allows you to switch the authentication service implementation easily
            // by creating a new class that implements the IAuthenticationService interface
            // and providing the desired logic for authentication and authorization.
            #region Part03Q02
            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "Ahmed";
            //string password = "123";
            //string role = "admin";

            //// Authenticate user
            //bool isAuthenticated = authService.AuthenticateUser(username, password);
            //Console.WriteLine($"Authentication result for {username}: {isAuthenticated}");

            //// Authorize user
            //bool isAuthorized = authService.AuthorizeUser(username, role);
            //Console.WriteLine($"Authorization result for {username} with role {role}: {isAuthorized}");

            //// Test with another role
            //role = "editor";
            //isAuthorized = authService.AuthorizeUser(username, role);
            //Console.WriteLine($"Authorization result for {username} with role {role}: {isAuthorized}");

            //// Test with a non-existing role
            //role = "manager";
            //isAuthorized = authService.AuthorizeUser(username, role);
            //Console.WriteLine($"Authorization result for {username} with role {role}: {isAuthorized}");

            #endregion

            // Question 03:
            // we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
            // We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.
            // In each implementation, we provide the logic to send notifications through the respective communication channel:
            // The EmailNotificationService class simulates sending an email by outputting a message to the console.
            // The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
            // The PushNotificationService class simulates sending a push notification by outputting a message to the console.
            // In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.
            // This implementation allows you to easily switch between different notification channels
            // by creating new classes that implement the INotificationService interface and provide the specific logic for each channel.
            #region Part03Q03
            //// Create instances of each notification service
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //// Sample recipient and message
            //string recipient = "user@example.com";
            //string message = "This is a test notification.";

            //// Send notifications using each service
            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification("123-456-7890", message);
            //pushService.SendNotification("user123", message);

            #endregion
        }
}
}
