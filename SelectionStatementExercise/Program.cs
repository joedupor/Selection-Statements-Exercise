namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            int favNum = 3;
            Console.WriteLine("Try to guess my favorite number!");
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


            Console.WriteLine("What is your favorite school subject? HISTORY, MATH, GYM, SCIENCE, or LANGUAGE? PLEASE use provided spelling and ALL CAPS when providing a response :)");
            string userFavSubj = Console.ReadLine();

            switch (userFavSubj)
            {
                case "HISTORY":
                    Console.WriteLine("My favorite too!");
                    break;

                case "MATH":
                    Console.WriteLine("Ah Math, the language of the cosmos!");
                    break;

                case "GYM":
                    Console.WriteLine("Good to stay fit!");
                    break;

                case "SCIENCE":
                    Console.WriteLine("Science, vital to humanity!");
                    break;

                case "LANGUAGE":
                    Console.WriteLine("But of course!");
                    break;

                    default: 
                    Console.WriteLine("Surely an interesting subject, but not a choice for this survey. Please try again!");
                    break;   

            }


        }
    }
}
