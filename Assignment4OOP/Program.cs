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

            

        }
    }
}
