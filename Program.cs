using ConsoleApp;

RealEstate elmStreet = new()
{
    Address = "Elm Street",
    SquareFootage = 1300,
    Price = 300000,

};

var result = elmStreet.CalculatePricePerSquareFoot();
Console.WriteLine(result);

var priceInCent = elmStreet.PriceInCents();
Console.WriteLine(priceInCent + " Cents");