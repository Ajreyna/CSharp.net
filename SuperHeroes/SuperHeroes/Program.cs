using System;

namespace SuperHeroes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            point2d p = new point2d();
        }
    class point2d
    {
            //public int x { get; set; }

            private int _x;

            public int x
            {
                get
                {
                    return _x;
                }
                set
                {
                    _x = value;
                }
            }
    }


    }
}
