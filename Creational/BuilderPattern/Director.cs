namespace BuilderPattern;

public class Director
{
    public Outfit CreateSportsOutfit(IBuilder<Outfit> Builder)
    {
        return Builder
            .AddHat()
            .AddGlasses()
            .AddShirt()
            .AddPants()
            .AddShoes()
            .GetProduct();
    }

    public Outfit CreateSmartCasualOutfit(IBuilder<Outfit> Builder)
    {
        return Builder
            .AddGlasses()
            .AddShirt()
            .AddPants()
            .AddShoes()
            .GetProduct();
    }
    
}