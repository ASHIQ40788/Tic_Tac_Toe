﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame tictactoeGame = new TicTacToeGame();
            tictactoeGame.Board();
            Console.ReadLine();
        }
    }
}
