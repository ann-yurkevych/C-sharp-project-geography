namespace ConsoleApplication
{
    internal class Mountain : GeographyObject
    {
        private readonly int highestPoint;

        public Mountain(string name, Point point, string? description, int highestPoint) : base(name, point, description)
        {
            this.highestPoint = highestPoint;
        }

        public override void ShowInfoAboutObject()
        {
            base.ShowInfoAboutObject();

            Console.WriteLine("highest peak:" + highestPoint + "m.");
        }

    }

}
