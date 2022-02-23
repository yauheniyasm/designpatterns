namespace Builder
{
    public  class RealEstateAgency
    {
        public void Construct(ApartmentBuilder apartmentBuilder)
        {
            apartmentBuilder.SpecifyFloor();
            apartmentBuilder.SpecifyBuildingName();
            apartmentBuilder.SpecifyBalcony();
            apartmentBuilder.SpecifyBedroomsNumber();
        }
    }
}
