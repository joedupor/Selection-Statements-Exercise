namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            int favNum = 3;
            Console.WriteLine("Try to guess my favorite number");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < favNum )
            {
                Console.WriteLine("too low");
            }

           else if (userInput > favNum) 
            {
                Console.WriteLine("too high");
            }

           else 
            {
                Console.WriteLine("You're psychic!");
            }

        }
    }
}
