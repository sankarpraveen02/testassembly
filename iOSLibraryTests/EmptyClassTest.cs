using System;
using NUnit.Framework;
using iOSLibrary;

namespace iOSLibraryTests
{
	[TestFixture]
	public class EmptyClassTest
	{
		[Test]
		public void Pass ()
		{
//			Assert.True (true);
			// arrange
			var target = new EmptyClass ();
			var testString = "is this thing on?";
			var expected = true;
			
			// act
			var actual = target.TestMethod (testString);

			// assert

			Assert.AreEqual (expected, actual);
		}

	}
}
