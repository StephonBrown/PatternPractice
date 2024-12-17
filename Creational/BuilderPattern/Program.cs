// See https://aka.ms/new-console-template for more information

using BuilderPattern;

var director = new Director();
Console.WriteLine($"Sports outfit: {director.CreateSportsOutfit(new SportOutfitBuilder())}");
Console.WriteLine($"Smart Casual outfit: {director.CreateSmartCasualOutfit(new SmartCasualOutfitBuilder())}");
