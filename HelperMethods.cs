﻿using System;
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
        public static void ListSuspects(List<Suspect> suspects, GameAttributes setting)
        {
            
            Console.Clear();
            Console.WriteLine("List of suspects                                             Days Remaining: " + setting.RemainingDays.ToString());
            Console.WriteLine("---------------------------------------");

            foreach (Suspect s in suspects)
            {
                Console.WriteLine(s.SuspectID + ") " + s.FirstName + " " + s.LastName);
            }
        }
        public void ListDaysRemaining(GameAttributes attributes)
        {
            Console.WriteLine("Days Remaining: " + attributes.RemainingDays.ToString());
            HelperMethods.LineBreaks(3);
        }
    }
}
