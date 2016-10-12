using System;
using NUnit.Framework;
namespace BattleShips
{
	[TestFixture()]
	public class NUnitTestPlayerAI
	{
		[Test()]
		public void TestPerformMenuAction()
		{
			GameController.StartGame ();
			Assert.Equals (GameController.ComputerPlayer, typeof(AIEasyPlayer));
		}
	}
}

