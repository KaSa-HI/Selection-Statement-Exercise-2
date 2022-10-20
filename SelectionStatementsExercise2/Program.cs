namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("What is your favourite school subject? ");
            string favSchoolSubject = Console.ReadLine(); 

            switch (favSchoolSubject)
            {
                case "Math":
                    Console.WriteLine($"{favSchoolSubject}");
                    Console.WriteLine("Ew.");
                    break;

                case "English":
                    Console.WriteLine($"{favSchoolSubject}");
                    Console.WriteLine("Lets eat grandma or Lets eat, grandma");
                    break;

                case "Science":
                    Console.WriteLine($"{favSchoolSubject}");
                    Console.WriteLine("WEIRD SCIENCE!!");
                    break;

                case "P.E":
                    Console.WriteLine($"{favSchoolSubject}");
                    Console.WriteLine("Health is important");
                    break;

                case "Study Hall":
                    Console.WriteLine($"{favSchoolSubject}");
                    Console.WriteLine("Snooze Break, nice.");
                    break;

                 default:
                    Console.WriteLine($"{favSchoolSubject}");
                    Console.WriteLine("Oh, you're playing hookie.");
                    break;
            }
        }
    }
}