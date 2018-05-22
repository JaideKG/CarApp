using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarApp.Models
{
    public class Car
    {
        private string make;
        private string plate;
        private int year;

        public Car()
        {
            make = "";
            plate = "";
            year = 1907;
        }

        public Car(string make, string plate, int year)
        {
            this.make = make;
            this.plate = plate;
            this.year = year;
        }

        public string Make { get => make; set => make = value; }
        public string Plate { get => plate; set => plate = value; }
        public int Year { get => year; set => year = value; }
    }
}