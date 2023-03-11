using System;
using System.Text;
using System.Collections.Generic;

namespace CollectionsLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "Monopoly", "Trouble", "Scrabble", "Sorry!", "Yahtzee" };
            LinkedList<string> gamesList = new LinkedList<string>(games);
            string firstGame = gamesList.First();
            string lastGame = gamesList.Last();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"The first game on the list is {firstGame}");
            Console.WriteLine($"The last game on the list is {lastGame}");


            LinkedListNode<string> middleLocation = gamesList.Find("Scrabble");
            gamesList.AddAfter(middleLocation, "Battleship");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"We've added some options to the list. There are {gamesList.Count} games. Here is the list of games:");
            foreach (string game in gamesList)
            {
                Console.WriteLine(game);
            }

            gamesList.RemoveFirst();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"We've removed some options from the list. There are now {gamesList.Count} games. Here is the updated list of games:");
            foreach (string game in gamesList)
            {
                Console.WriteLine(game);
            }
        }
    }
}