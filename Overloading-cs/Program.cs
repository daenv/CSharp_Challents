// See https://aka.ms/new-console-template for more information

using System;

namespace Overloading
{
    class Box
    {
        public double lenght;
        public double breadth;
        public double height;

        public void setHeight(double hei)
        {
            this.height = hei;
        }

        public void setBreadth(double bre)
        {
            this.breadth = bre;
        }

        public void setLenght(double len)
        {
            this.lenght = len;
        }

        public double getVolume()
        {
            return lenght * breadth * height;
        }

        // Overload + operator to add two Box Object

        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.height = b.height + c.height;
            box.lenght = b.lenght + c.lenght;
            box.breadth = b.breadth + c.breadth;
            return box;
        }

        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.lenght == rhs.lenght && lhs.breadth == rhs.breadth && lhs.height == rhs.height)
            {
                status = true;
            }

            return status;
        }

        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.lenght != rhs.lenght || lhs.breadth != rhs.breadth || lhs.height != rhs.height)
            {
                status = true;
            }

            return status;
        }

        public static bool operator <(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.lenght < rhs.lenght && lhs.breadth < rhs.breadth && lhs.height < rhs.height)
            {
                status = true;
            }

            return status;
        }

        public static bool operator >(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.lenght > rhs.lenght && lhs.breadth > rhs.breadth && lhs.height > rhs.height)
            {
                status = true;
            }

            return status;
        }

        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.lenght <= rhs.lenght && lhs.breadth <= rhs.breadth && lhs.height <= rhs.height)
            {
                status = true;
            }

            return status;
        }

        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.lenght >= rhs.lenght && lhs.breadth >= rhs.breadth && lhs.height >= rhs.height)
            {
                status = true;
            }

            return status;
        }

        public static bool operator !(Box lhs)
        {
            bool status = false;
            if (lhs.lenght == 0 && lhs.breadth == 0 && lhs.height == 0)
            {
                status = true;
            }

            return status;
        }

        public static Box operator ++(Box lhs)
        {
            lhs.lenght++;
            lhs.breadth++;
            lhs.height++;
            return lhs;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();
            double volume = 0.0;
            // set box1
            box1.setLenght(6.0);
            box1.setBreadth(7.0);
            box1.setHeight(5.0);

            // set box2
            box2.setLenght(12.0);
            box2.setBreadth(13.0);
            box2.setHeight(10.0);

            // set box 3
            volume = box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            volume = box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            // Add two object as follows:
            box3 = box1 + box2;
            volume = box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);
            Console.ReadKey();
            
            // == and != operator
            if (box1 == box2)
            {
                Console.WriteLine("Box1 is equal to Box2");
            }
            else
            {
                Console.WriteLine("Box1 is not equal to Box2");
            }
            
            if (box1 != box2)
            {
                Console.WriteLine("Box1 is not equal to Box2");
            }
            else
            {
                Console.WriteLine("Box1 is equal to Box2");
            }
            
            // > and < operator
            if (box1 > box2)
            {
                Console.WriteLine("Box1 is greater than Box2");
            }
            else
            {
                Console.WriteLine("Box1 is not greater than Box2");
            }
            
            if (box1 < box2)
            {
                Console.WriteLine("Box1 is less than Box2");
            }
            else
            {
                Console.WriteLine("Box1 is not less than Box2");
            }
            
            // >= and <= operator
            if (box1 >= box2)
            {
                Console.WriteLine("Box1 is greater than or equal to Box2");
            }
            else
            {
                Console.WriteLine("Box1 is not greater than or equal to Box2");
            }
        }
    }
};