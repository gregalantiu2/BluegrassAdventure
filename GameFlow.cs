using System;
using System.Collections.Generic;
using System.Text;

namespace BluegrassAdventure
{
    class GameFlow
    {
        public Player player = new Player();
        public List<Suspect> suspects = new List<Suspect>();
        public GameAttributes settings = new GameAttributes();
        public HelperMethods helper = new HelperMethods();
        Random rnd = new Random();
 
        public void GameStart()
        {
            settings.NumberOfSuspects = rnd.Next(3, 7);
            Console.WriteLine("Bluegrass Adventure!");
            HelperMethods.LineBreaks(2);
            Console.WriteLine("Please enter your name:");
            HelperMethods.LineBreaks(1);
            player.FirstName = Console.ReadLine(); //add validation here
            HelperMethods.LineBreaks(2);
            Console.Write("Ok " + player.FirstName + " lets get started");
            HelperMethods.LineBreaks(2);
            Console.WriteLine("Detective " + player.FirstName + ", there has been a murder. We are putting you on the case.");
            Console.WriteLine("So far the police have identified " + settings.NumberOfSuspects.ToString() + " Suspects");
            Console.WriteLine("You will need to interview suspects and determine which one is the killer.");
            Console.WriteLine("Some of them will lie to you. It doesn't mean they are guilty but it is up to you to dig deeper");
            Console.WriteLine("You have " + settings.RemainingDays.ToString() + " days to solve the case before it is closed");
            HelperMethods.LineBreaks(1);
            Console.WriteLine("Here are the list of suspects:");
            suspects = settings.CreateSuspects(settings.NumberOfSuspects);

            foreach(Suspect s in suspects)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName);
            }

            HelperMethods.LineBreaks(2);
            Console.WriteLine("Go out there and find that killer");
            Console.WriteLine("Press any key to continue...............");
            Console.ReadKey();
        }
        public void GamePlay()
        {
            
            HelperMethods.ListSuspects(suspects);


        }
    }
}
