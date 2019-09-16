using System;

namespace BluegrassAdventure
{

    class Program
    {
        static void Main(string[] args)
        {
            GameFlow flow = new GameFlow();

            flow.GameStart();
            flow.GamePlay();
        }
    }
}
