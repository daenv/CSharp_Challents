using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        public double getVolume()
        {
            return length * breadth * height;
        } 


        

    }

    class Tester
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();

            box1.setBreadth(5.3);
            box1.setHeight(2.3);
            box1.setLength(4.5);

                 
            Console.WriteLine("Volume of Box1 : {0}", box1.getVolume());
        }
    }
}