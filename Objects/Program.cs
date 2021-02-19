
using System;

namespace Objects
{
    class Program
    {
        public class Point
        {
            public int x;
            public int y;

            public Point(int x = 0, int y = 0) 
            {
                this.x = x;
                this.y = y;
            }

            public void pointPosition (int x, int y) 
            {  
                this.x = x;
                this.y = y;
            }

            public Point returnPosition() 
            {
                Point point = new Point();
                point.x = getX();
                point.y = getY();

                return point;
            }

            public void showPosition()
            {
                Console.WriteLine("Point x value is {0}, Point y value is {1}", x, y);
            }

            public int getX()
            {

                return x;

            }

            public int getY()
            {

                return y;

            }

        }

        static void Main(string[] args)
        {
            var firstPoint = new Point(10,10);
            var secondPoint = new Point(20, 20);

            firstPoint.showPosition();
            secondPoint.showPosition();
        }
    }
}