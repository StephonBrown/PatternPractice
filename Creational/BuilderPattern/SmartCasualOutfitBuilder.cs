namespace BuilderPattern;

public class SmartCasualOutfitBuilder : IBuilder<Outfit>
{
    private Outfit outfit { get; set; } = new();

    public void ResetBuilder()
    {
        outfit = new Outfit();
    }
    
    public IBuilder<Outfit> AddHat()
    {
        return this;    
    }

    IBuilder<Outfit> IBuilder<Outfit>.AddGlasses()
    {
        outfit.Glasses = "Tinted Glasses";
        return this;    
    }

    IBuilder<Outfit> IBuilder<Outfit>.AddShirt()
    {
        outfit.Shirt = "ButtonUp";
        return this;
    }

    IBuilder<Outfit> IBuilder<Outfit>.AddPants()
    {
        outfit.Pants = "Slacks";
        return this;
    }

    IBuilder<Outfit> IBuilder<Outfit>.AddShoes()
    {
        outfit.Shoes = "Dress shoes";
        return this;
    }

    public Outfit GetProduct()
    {
        return outfit;
    }
}