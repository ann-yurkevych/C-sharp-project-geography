namespace ConsoleApplication
{
    internal class River : GeographyObject
    {
        private readonly double length;

        private readonly double flowRate;

        public River(string name, Point point, string? description, double length, double flowRate) : base(name, point, description)
        {
            this.length = length;
            this.flowRate = flowRate;
        }

        public override void ShowInfoAboutObject()
        {
            base.ShowInfoAboutObject();
            Console.WriteLine("length:" + length + "km. flowrate:" + flowRate + "cm/s.");
        }
    }

}
