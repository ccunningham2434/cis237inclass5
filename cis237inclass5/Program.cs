﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass5
{
    class Program
    {
        static void Main(string[] args)
        {
            // >Make a new instance of the cars collection.
            CarsCCunninghamEntities ccunninghamEntities = new CarsCCunninghamEntities();

            //**************************************
            // List out all of the cars in the table
            //**************************************
            Console.WriteLine("Print the list");

            foreach (Car car in ccunninghamEntities.Cars)
            {
                Console.WriteLine(car.id + " " + car.model + " " + car.model);
            }
            Console.ReadLine();
        }
    }
}
