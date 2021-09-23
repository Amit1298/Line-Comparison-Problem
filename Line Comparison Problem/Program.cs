using System;

namespace Line_Comparison_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartesian_system LenghtLine = new Cartesian_system();
            CompareLineLength lineCompare = new CompareLineLength();
            comparingLineSize compareSize = new comparingLineSize();
            Console.WriteLine("Welcome to Line Comparison Problem");
            // LenghtLine.Cartesion();
            //lineCompare.compareLine();
            compareSize.lineSize();
            Console.ReadLine();
        }
    }
}
