namespace BuilderPattern;

public class SportOutfitBuilder : IBuilder<Outfit>
{
    private Outfit outfit { get; set; } = new();

    public void ResetBuilder()
    {
        outfit = new Outfit();
    }

    public IBuilder<Outfit> AddHat()
    {
        outfit.Hat = "Snapback hat";
        return this;
    }

    IBuilder<Outfit> IBuilder<Outfit>.AddGlasses()
    {
        outfit.Glasses = "Basketball Nike Glasses";
        return this;    
    }

    IBuilder<Outfit> IBuilder<Outfit>.AddShirt()
    {
        outfit.Shirt = "Nike Shirt";
        return this;        
    }

    IBuilder<Outfit> IBuilder<Outfit>.AddPants()
    {
        outfit.Pants = "B-ball Shorts";
        return this;
    }

    IBuilder<Outfit> IBuilder<Outfit>.AddShoes()
    {
        outfit.Shoes = "Jordan 5s";
        return this;
        
    }

    public Outfit GetProduct()
    {
        return outfit;
    }
}