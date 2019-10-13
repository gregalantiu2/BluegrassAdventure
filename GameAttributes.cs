using System;
using System.Collections.Generic;
using System.Text;

namespace BluegrassAdventure
{
    class GameAttributes : GameSettings
    {
        public int NumberOfSuspects { get; set; }
        public int GameStatus { get; set; } = 0;
        public int RemainingDays { get; set; } = 15;

    }
}
