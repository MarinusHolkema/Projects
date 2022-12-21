
Console.WriteLine("Enter a number");
var answer1 = Console.ReadLine();
Console.WriteLine("Enter another number");
var answer2 = Console.ReadLine();
int.TryParse(answer1, out int number1);
int.TryParse(answer2, out int number2);
Console.WriteLine("The sum of these numbers is");
Console.WriteLine(number1 + number2);

