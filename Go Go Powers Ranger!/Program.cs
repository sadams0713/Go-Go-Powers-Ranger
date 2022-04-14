namespace Powers_Ranger
{
    public class Program
    {
        public static void Main()
        {
            bool ContinueRunning;

            Console.WriteLine(" Welcome Powers Ranger! This app will help you learn your squares and cubes.");
            Console.WriteLine(" Please enter your name. ");
            string name = Console.ReadLine();

            do
            {
                Console.WriteLine(" Welcome here Ranger " + name + "!");

                Console.WriteLine(" Up to what number would you like to see the powers of?");
                Console.WriteLine("We'll show you every number up to the number you choose! (Please enter an integer.)");
                string number = Console.ReadLine();
                int num = int.Parse(number);

                if (num > 0 && num <= 1290)
                {

                    Console.WriteLine("Thanks " + name + ". Here are your numbers powers!");

                    Console.WriteLine();
                    Console.WriteLine("\t---------------------------");
                    Console.WriteLine(" \t| Number | Squared | Cubed| ");
                    Console.WriteLine("\t---------------------------");

                    for (int start = 1; start <= num; start++)
                    { Console.WriteLine("\t\t" + start + "\t  " + (start * start) + "\t  " + (start * start * start)); 
                                         }
                }
                else if (num <= 0)
                {
                    Console.WriteLine($" Sorry {name}, that number doesn't work. Zero is zero is zero.");
                }
                else if (num > 1290)
                {
                    Console.WriteLine($" Sorry {name}, that number cubed is too big to fit in an integer. ");
                }
            back_here:
                Console.WriteLine(" Would you like to see another numbers powers " + name + "? Type yes or no. ");
                var input = (Console.ReadLine());

                if (input.ToLower() == "y" || input.ToLower() == "yes")
                {
                    ContinueRunning = true;
                }
                else if (input.ToLower() == "no" || input.ToLower() == "n")
                {
                    ContinueRunning = false;
                }
                else
                {
                    Console.WriteLine($" Sorry {name} I don't understand that. ");
                    goto back_here;
                }
            }


            while (ContinueRunning == true);



            Console.WriteLine(" Thanks for using the Powers Ranger App " + name + "!");
        }
    }
}