using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqSnippets
{
    public class Snippets
    {
        static public void StringBasicLinq()
        {
            string[] cars = { "Raptor", "Ferrari", "BMW" };

            // SELECT * of Cars (SELECT ALL Cars)
            var allCars = from car in cars select car;
            foreach (var car in allCars)
            {
                Console.WriteLine(car);
            }

            // SELECT WHERE car is BWM (SELECT BMWs)
            var bmwList = from car in cars where car.Contains("BMW") select car;
            foreach (var bmw in bmwList)
            {
                Console.WriteLine(bmw);
            }
        }
    }
}