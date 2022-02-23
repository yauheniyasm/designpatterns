namespace Builder
{
    public class Apartment
    {
        public int Floor { get; set; }

        public string BuildingName { get; set; }

        public bool HasBalcony { get; set; }

        public int BedroomsNumber { get; set; }

        public void Show()
        {
            Console.WriteLine("\n");

            Console.WriteLine($"Building name: {BuildingName}");

            Console.WriteLine($"Floor : {Floor}");

            Console.WriteLine($"Has Balcony : {HasBalcony}");

            Console.WriteLine($"Bedrooms number: {BedroomsNumber}");
        }
    }
}
