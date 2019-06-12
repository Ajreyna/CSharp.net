using System;

using System.Collections.Generic;


namespace points
{
    class MainClass
    {
        // public static void Main(string[] args)

        


        public class Point2D
        {
            int x;
            int y;

            public Point2D()
            {
                // your code here
                int X;
                int Y;

            }

            public Point2D(int x, int y)
            {
                // your code here  
                X = x;
                Y = y;

            }

            public override bool Equals(object o)
            {
                if(o.GetType().Equals(this.GetType()))
                {
                    Point2D point = (Point2D)o;
                    return this.x = point.X && this.Y == point.Y;
                }
                else
                {
                    return false;
                }
            
            }

            public override string ToString()
            {
                return $"{(X), (Y)"};
            }



        }

        public class Point3D : Point2D
        {
            public Point3D()
            {
                //var Z = 0;
                // your code here
            }
            public Point3D(int x, int y, int z) : base(x, y)
            {
                // your code here
            }

            // your code here
        }

        public class Program
        {
            public static void Main(String[] args)
            {
                Point2D p1 = new Point2D();
                Point2D p2 = new Point2D(7, 5);
                Point2D p3 = new Point2D(-2, 4);
                Point2D p4 = new Point2D(7, 5);

                Console.WriteLine("p1 = {0}", p1);
                Console.WriteLine("p2 = {0}", p2);
                Console.WriteLine("p3 = {0}", p3);
                Console.WriteLine("p4 = {0}", p4);

                Console.WriteLine("p2 == p3? {0}", p2 == p3);
                Console.WriteLine("p2.Equals(p3)? {0}", Point2D.Equals(p2, p3));
                Console.WriteLine("p2 == p4? {0}", p2 == p4);
                Console.WriteLine("p2.Equals(p4)? {0}", Point2D.Equals(p2, p4));

                Console.WriteLine("========");

                Point3D p5 = new Point3D();
                Point3D p6 = new Point3D(7, 5, 12);
                Point3D p7 = new Point3D(-2, 4, -4);
                Point3D p8 = new Point3D(7, 5, 12);

                Console.WriteLine("p5 = {0}", p5);
                Console.WriteLine("p6 = {0}", p6);
                Console.WriteLine("p7 = {0}", p7);
                Console.WriteLine("p8 = {0}", p8);

                Console.WriteLine("p6 == p7? {0}", p6 == p7);
                Console.WriteLine("p6.Equals(p7)? {0}", Point2D.Equals(p6, p7));
                Console.WriteLine("p6 == p8? {0}", p6 == p8);
                Console.WriteLine("p6.Equals(p8)? {0}", Point2D.Equals(p6, p8));

                Console.WriteLine("========");
            }
        }

    }
}
