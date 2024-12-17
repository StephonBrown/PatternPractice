namespace BuilderPattern;

public interface IBuilder<T> where T: class
{
    void ResetBuilder();
    IBuilder<T> AddHat();
    IBuilder<T> AddGlasses();
    IBuilder<T> AddShirt();
    IBuilder<T> AddPants();
    IBuilder<T> AddShoes();
    T GetProduct();

}