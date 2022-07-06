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

        static public void NumberBasicLinq()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Each number multiplied by 3
            // Take all numbers, but 9
            // Order numbers by ascending

            var processedNumberList = numbers
                .Select(num => num * 3) // => [ 3, 6, 9 ]
                .Where(num => num != 9) // => [ all but the 9 ]
                .OrderBy(num => num); // => at the end, we order ascending
        }
    }
}