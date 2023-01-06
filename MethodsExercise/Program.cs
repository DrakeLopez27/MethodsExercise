namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2, int num3) 
        {
            return num1 * num2 * num3;  
        }
        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            var amountx = Multiply(60, 2, 4);
            Console.WriteLine (amountx);
            
           



            {       //EXCERCISE 1
                Console.WriteLine("What is your name?");
                var userName = Console.ReadLine();

                Console.WriteLine($"Hey, {userName}, what is your favorite color?");
                var color = Console.ReadLine();

                Console.WriteLine($"Cool, {color} is my favorite too. What is your favorite animal?");
                var animal = Console.ReadLine();

                Console.WriteLine($"Wow, I love {animal}, what is your favorite band?");
                var band = Console.ReadLine();

                Console.WriteLine($"Thanks, {userName}, here is your profile!");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Name: {userName}");
                Console.WriteLine($"Favorite Color: {color}");
                Console.WriteLine($"Favorite Animal: {animal}");
                Console.WriteLine($"Favorite Band: {band}");


            }

        }
    }
}
