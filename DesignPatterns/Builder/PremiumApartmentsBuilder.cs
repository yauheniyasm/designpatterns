namespace Builder
{
    public class PremiumApartmentsBuilder : ApartmentBuilder
    {
        public PremiumApartmentsBuilder()
        {
            apartment = new Apartment();
        }

        public override void SpecifyBalcony()
        {
            apartment.HasBalcony = true;
        }

        public override void SpecifyBedroomsNumber()
        {
            apartment.BedroomsNumber = 2;
        }

        public override void SpecifyBuildingName()
        {
            apartment.BuildingName = "Premium House";
        }

        public override void SpecifyFloor()
        {
            apartment.Floor = 5;
        }
    }
}
