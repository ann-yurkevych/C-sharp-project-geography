namespace ConsoleApplication
{
    internal class Point
    {
        private int x;

        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get { return x; } }

        public int Y { get { return y; } }

        public override string ToString()
        {
            return "Coordinates:" + "X = " + x.ToString() + "  Y= " + y.ToString();
        }
    }
}