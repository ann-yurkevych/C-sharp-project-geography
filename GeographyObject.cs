namespace ConsoleApplication
{
    internal abstract class GeographyObject : IGeoObject
    {
        private readonly Point point;
        private readonly string name;
        private readonly string? description;

        protected GeographyObject(string name, Point point, string? description)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
            }
            if (point is null)
            {
                throw new ArgumentNullException(nameof(point));
            }
            this.name = name;
            this.point = point;
            this.description = description;
        }

        public virtual void ShowInfoAboutObject()
        {
            Console.WriteLine("Name:" + name + " " + point + " Description:" + description);
        }
    }
}
