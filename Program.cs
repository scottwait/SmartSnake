﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			//make a game
			Game game = new Game(20, 10, 3);
			//make a ga and give it a game
            GA ga = new GA(game, 50);
            // SET PROPERTIES
            ga.NumRuns = 5;
            ga.ProbMutate = 0.8;
            ga.StdDev = 1d;
            ga.SelectMod = 0.30d;
			//train ga for 1000 iterations
			ga.TrainFor(1000);
			//give game correct controller for best chromosome
			ga.SetUpBestGame();
			//display the game
            while (true)
            {
                game.Play(30);
                Console.ReadKey();
            }
		}
	}
}