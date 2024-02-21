//Expresion Lambda

var numbers = new int[] { 2, 3, 4, 5, 6, 7, 8 };
var count = numbers.Count(x => x == 5);
Console.WriteLine(count);

//Statement Lambda

List<int> numbers2 = new List<int> { 2, 4, 3, 1, 2, 3 };
var count2 = numbers.Count(x =>
{
    return x == 5;
});
Console.WriteLine(count2);

