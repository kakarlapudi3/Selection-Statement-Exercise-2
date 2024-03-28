namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            string favSubject = Console.ReadLine();

            switch(favSubject) {

                case "English":
                Console.WriteLine("English - not my favorite");
                break;

                case "Science":
                Console.WriteLine("Science - not my favorite");
                break;

                case "History":
                Console.WriteLine("History - not my favorite");
                break;

                case "Accounting":
                Console.WriteLine("Accounting- not my favorite");
                break;

                case "Math":
                Console.WriteLine("Math- not my favorite");
                break;

            }


        }
    }
}