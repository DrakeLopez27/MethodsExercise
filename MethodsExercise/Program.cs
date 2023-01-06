namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hey, {userName}, what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"Cool, {color} is my favorite too. What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Wow, I love {animal}, what is your favorite band?");
            var band = Console.ReadLine();
        }
    }
}
