using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiConsoleApp
{
    class Player
    {
        public string player1 { get; private set; }
        public string player2 { get; private set; }

        public Player(string player)
        {
            if(player.Equals("W"))
            {
                this.player1 = player;
                this.player2 = "";
            }
            else
            {
                this.player2 = player;
                this.player1 = "";
            }
        }
    }
}
