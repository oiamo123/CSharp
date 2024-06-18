// See https://aka.ms/new-console-template for more information
var John = new Person(12.75m);
var calcChange = new CoinMachine().calcChange;
var change = calcChange(John.change);

Console.WriteLine(change);

public class Person(decimal change)
{
    public decimal change = change;
}

public class CoinMachine()
{
    public decimal calcChange(decimal change)
    {
        return change;
    }
}

