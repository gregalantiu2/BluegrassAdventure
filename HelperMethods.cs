using System;
using System.Collections.Generic;
using System.Text;

namespace BluegrassAdventure
{
    class HelperMethods
    {
        public static void LineBreaks(int length)
        {
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine("");
            }
        }
        public static void ListSuspects(List<Suspect> suspects)
        {
            Console.Clear();
            Console.WriteLine("List of suspects");
            Console.WriteLine("---------------------------------------");

            foreach (Suspect s in suspects)
            {
                Console.WriteLine(s.SuspectID + ") " + s.FirstName + " " + s.LastName);
            }
        }
    }
}
