using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Freezer
    {
        //private int minTemperature;
        //private int maxTemperature;
        //private int height;
        //private int width;
        //private string model;
        private int capacity;
        //private string color;
        public string Model { get; set; }
        public string Color { get; set; }

        private int minTemperature;

        public int MinTemperature
        {
            get { return minTemperature; }
            set 
            { 
                if (value > -7 && value < 0)
                {
                    minTemperature = value;
                }
                else
                {
                    minTemperature = 0;
                }
            }
        }
        private int maxTemperature;

        public int MaxTemperature
        {
            get { return maxTemperature; }
            set
            { 
                if (value > 0)
                {
                    maxTemperature = value;
                }
                else
                {
                    maxTemperature = 0;
                }
            }
        }
        private int height;

        public int Height
        {
            get { return height; }
            set 
            { 
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    height = 0;
                }

            }
        }
        private int width;

        public int Width
        {
            get { return width; }
            set 
            { 
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    width = 0;
                }
            }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }



        private static int count;
        private static string TypeFreeze;
       // private static int price;
        static Freezer()
        {
            count = 0;          
            TypeFreeze = "dry freeze";

        }
        public override string ToString()
        {
            return $"Model : {Model}\nType freeze : {TypeFreeze}\nPrice : {price}\nCount : {count}";
        }
        public Freezer(string Model, string Color, int minTemp, int maxTemp, int h, int w, double p)
        {
            this.Model = Model ;
            this.Color = Color ;
            MinTemperature = minTemp;
            MaxTemperature = maxTemp;
            Height= h ;
            Width= w ;
            Price = p ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
