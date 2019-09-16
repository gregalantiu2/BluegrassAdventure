using System;
using System.Collections.Generic;
using System.Text;

namespace BluegrassAdventure
{
    class GameSettings
    {
        public List<Suspect> CreateSuspects(int numberOfSuspects)
        {
            List<Suspect> suspects = new List<Suspect>();
            var namesDB = GameSettings.GetDictionaryOfNames();

            Random NameSet = new Random();

            for(int i = 0; i < numberOfSuspects; i++)
            {
                Suspect suspect = new Suspect();
                int firstNameSelect = NameSet.Next(0, namesDB[0].Count);
                int lastNameSelect = NameSet.Next(0, namesDB[1].Count);

                suspect.FirstName = namesDB[0][firstNameSelect];
                suspect.LastName = namesDB[1][lastNameSelect];
                suspect.SuspectID = i + 1;
                suspects.Add(suspect);

            }

            return suspects;
        }
        public static List<List<string>> GetDictionaryOfNames()
        {
            List<List<string>> nameValues = new List<List<string>>();

            var firstNameDictionary = new List<string>
            {
                {"Greg"},
                {"Tom"},
                {"Silas"},
                {"Drew"},
                {"Mark"},
                {"Kylie"},
                {"Sara"},
                {"Rhonda"},
                {"Samara"},
                {"Ken"},
                {"Johny"},
                {"Paulie"},
                {"Sean"},
            };

            var lastNameDictionary = new List<string>
            {
                {"Tiu"},
                {"Jones"},
                {"Rodgers"},
                {"Fenner"},
                {"Lawrence"},
                {"Smith"},
                {"Turpin"},
                {"Harvey"},
                {"Ramirez"},
                {"Darnold"},
                {"Maze"},
                {"Cannon"},
                {"Newton"},
            };

            nameValues.Add(firstNameDictionary);
            nameValues.Add(lastNameDictionary);

            return nameValues;
        }
    }
}
