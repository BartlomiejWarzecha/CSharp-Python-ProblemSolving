using System;

namespace Objects
{
    class Program
    {
        public class Point  
        {
            public int x;
            public int y;

            public void showPosition()
            {
                Console.WriteLine("Point x value is {0}, Point y value is {1}", x, y);
            }

        }

        static void Main(string[] args)
        {
            Point firstPoint = new Point();

            firstPoint.x = 10;
            firstPoint.y = 10;

            firstPoint.showPosition();

        }
    }
}
