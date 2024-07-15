// define data sources
double[] numbers = { 1.7, 9.3, -7.7, 0, 10.5, 0.8, -2.5, 6.9, 4.2, 0.1, -2.5};

// define query
var numbersQuery = from num in numbers
                   where num > 0
                   orderby num descending
                   select num;

// query executes first time we references numbersQuery
foreach (var n in numbersQuery)
{
    Console.WriteLine(n + "\t");
}