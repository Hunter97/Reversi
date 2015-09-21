using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiConsoleApp
{
    class Reversi
    {
        private const string PLAYER1 = "W";
        private const string PLAYER2 = "B";
        private Dictionary<Player, Location> moves;

        public Reversi()
        {
            moves = new Dictionary<Player, Location>();

            moves.Add(new Player(PLAYER2), new Location(3, 3));
            moves.Add(new Player(PLAYER1), new Location(4, 3));
            moves.Add(new Player(PLAYER1), new Location(3, 4));
            moves.Add(new Player(PLAYER2), new Location(4, 4));
        }

        public Dictionary<Player, Location> getMoves()
        {
            return moves;
        }

        static void Main(string[] args)
        {
            Reversi reversi = new Reversi();
            Dictionary<Player, Location> nextMove = new Dictionary<Player, Location>();

            nextMove = reversi.getMoves();

            Console.WriteLine("{0} at location {1},{2}", nextMove.ElementAt(0).Key.player2.ToString(), nextMove.ElementAt(0).Value.X, nextMove.ElementAt(0).Value.Y);
            Console.WriteLine("{0} at location {1},{2}", nextMove.ElementAt(1).Key.player1.ToString(), nextMove.ElementAt(1).Value.X, nextMove.ElementAt(0).Value.Y);
            Console.WriteLine("{0} at location {1},{2}", nextMove.ElementAt(1).Key.player1.ToString(), nextMove.ElementAt(2).Value.X, nextMove.ElementAt(0).Value.Y);
            Console.WriteLine("{0} at location {1},{2}", nextMove.ElementAt(0).Key.player2.ToString(), nextMove.ElementAt(3).Value.X, nextMove.ElementAt(0).Value.Y);
            Console.WriteLine("press enter to close");
            Console.ReadLine();

        }
    }
}
