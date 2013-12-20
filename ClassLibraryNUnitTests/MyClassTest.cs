using NUnit.Framework;
using System;
using ClassLibrary;

namespace ClassLibraryNUnitTests
{
	[TestFixture ()]
	public class MyClassTest
	{
		[Test ()]
		public void FooBar_123_Succeeds ()
		{
			// arrange
			MyClass target = new MyClass();
			var expected = "123";
			var testNumber = 123;

			// act
			var actual = target.FooBar (testNumber);

			//assert
			Assert.AreEqual (expected, actual);

		}
	}
}

