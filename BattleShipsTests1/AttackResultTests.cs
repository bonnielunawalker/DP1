using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class AttackResultTests
    {
        [TestMethod()]
		public void AttackResultToString ()
		{
			AttackResult attackResult = new AttackResult (ResultOfAttack.GameOver, "Game over", 0, 0);

			string actual = attackResult.ToString ();
			string expected = "Game over";
			Assert.AreEqual (expected, actual, "Error: AttackResultToString");
		}

		[TestMethod()]
		public void AttackResultToStringWithShip ()
		{
			Ship ship = new Ship (ShipName.AircraftCarrier);
			AttackResult attackResult = new AttackResult (ResultOfAttack.GameOver, ship, "Game over", 0, 0);

			string actual = attackResult.ToString ();
			string expected = "Game over " + ship.Name;

			Assert.AreEqual (expected, actual, "Error: AttackResultToStringWithShip");
		}
    }
}