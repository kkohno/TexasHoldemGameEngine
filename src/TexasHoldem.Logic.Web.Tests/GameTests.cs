using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TexasHoldem.Logic.Web.Tests
{
	public class GameTests
	{
		[Test]
		public async Task Test1()
		{
			var players = new List<WebPlayer> {
				new("1", 1000),
				new("2", 1000),
				new("3", 1000)
			};
			var game = new WebTexasHoldem(players, 100);
			await game.Start();
			//var winner = await Task.Run(game.Start);
			//Console.WriteLine($"winner: {winner.Name}");
		}
	}
}