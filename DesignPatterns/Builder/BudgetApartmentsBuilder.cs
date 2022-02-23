namespace Builder
{
    public class BudgetApartmentsBuilder : ApartmentBuilder
    {
        public BudgetApartmentsBuilder()
        {
            apartment = new Apartment();
        }

        public override void SpecifyBalcony()
        {
            apartment.HasBalcony = false;
        }

        public override void SpecifyBedroomsNumber()
        {
            apartment.BedroomsNumber = 1;
        }

        public override void SpecifyBuildingName()
        {
            apartment.BuildingName = "Budget House";
        }

        public override void SpecifyFloor()
        {
            apartment.Floor = 1;
        }
    }
}
