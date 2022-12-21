namespace Swap
{
    internal class Program
    {
        static void Main()
        {
        
            Console.Write("\nInput the First Number : ");
            var answer = Console.ReadLine();

            _ = int.TryParse(answer, out int number1);

            Console.Write("\nInput the Second Number : ");
            answer = Console.ReadLine();
            _ = int.TryParse(answer, out int number2);
            Swap(ref number1, ref number2);
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);

        }

        private static void Swap(ref int number1, ref int number2)
        {
            (number2, number1) = (number1, number2);
        }
    }
}