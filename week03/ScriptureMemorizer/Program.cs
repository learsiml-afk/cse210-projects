using System;

class Program
{
    static void Main(string[] args)
    {
       DateTime startTime = DateTime.Now;

        Scripture escritura = new Scripture(new Reference("Proverbios", 3, 5, 6),"Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        
        while (!escritura.IsCompletelyHidden())
        {   
            Console.Clear();

            Console.WriteLine(escritura.GetDisplayText());
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();



            if (input == "")
            {
                
                escritura.HideRandomWords(3);
            }

            else if(input.ToLower() == "quit")
            {
            break;
            }

            if (escritura.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(escritura.GetDisplayText());
                Console.ReadLine();
                break;
            }
        }

        DateTime endTime = DateTime.Now;
        TimeSpan elapsedTime = endTime - startTime;
        Console.WriteLine("Time you have spend on the program:  " + elapsedTime.ToString(@"hh\:mm\:ss"));
    }
}