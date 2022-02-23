using Builder;

ApartmentBuilder builder;

RealEstateAgency shop = new();

builder = new BudgetApartmentsBuilder();
shop.Construct(builder);
builder.Apartment.Show();

builder = new PremiumApartmentsBuilder();
shop.Construct(builder);
builder.Apartment.Show();

Console.ReadKey();
