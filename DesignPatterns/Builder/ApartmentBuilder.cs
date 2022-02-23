namespace Builder
{
    public abstract class ApartmentBuilder
    {
        protected Apartment apartment;

        public Apartment Apartment
        {
            get { return apartment; }
        }

        public abstract void SpecifyFloor();

        public abstract void SpecifyBuildingName();

        public abstract void SpecifyBalcony();

        public abstract void SpecifyBedroomsNumber();
    }
}
