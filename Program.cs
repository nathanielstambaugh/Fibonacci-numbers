// See https://aka.ms/new-console-template for more information
var fibonacciNumbers = new List<int>() {1,1};
Console.WriteLine("Please enter the fibonacci number count: ");
var input = Convert.ToInt64(Console.ReadLine());

while (fibonacciNumbers.Count < input)
{
    var n1 = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var n2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(n1 + n2);
}
for (int i = 0; i < fibonacciNumbers.Count; i++)
{
    Console.WriteLine(fibonacciNumbers[i] + " <---- " + (i+1));
}

