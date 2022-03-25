using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Game(5,7));
        }

        public static int Game(int noOfPlayers, int noOfRounds)
        {
            List<int> Players = new List<int>();
            for (int i = 1; i <= noOfPlayers; i++)
            {
                Players.Add(i);
            }
            int count = Players.Count;
            int newIndex = noOfRounds - 1;
            for (int i = 0; i < count; i++)
            {
                if (Players.Count > 1)
                {

                    if (Players.Count > newIndex)
                    {
                        Players.RemoveAt(newIndex);
                        newIndex += (noOfRounds - 1);
                    }
                    else if (Players.Count <= newIndex)
                    {
                        newIndex = newIndex % Players.Count;
                        Players.RemoveAt(newIndex);
                        newIndex += (noOfRounds - 1);
                    }
                }
            }

            return Players[0];
        }
    }
}
