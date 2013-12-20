using System;

namespace ClassLibrary
{
	public class MyClass
	{
		public MyClass ()
		{
		}

		public string FooBar(int pickAnyNumber)
		{
			var retVal = pickAnyNumber.ToString ();
			return retVal;
		}
	}
}

