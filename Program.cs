using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tic_Tac_Toe
{
	class Program
	{
		static void Main(string[] args)
		{
			TicTacToeGame ticTacToeGame = new TicTacToeGame();
			char[] board = ticTacToeGame.Board();
			ticTacToeGame.Select();
			Console.ReadLine();

		}
	}
}
