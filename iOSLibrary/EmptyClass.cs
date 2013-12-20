using System;

namespace iOSLibrary
{
	public class EmptyClass
	{
		public EmptyClass ()
		{
		}

		public int Age {
			get;
			private set;
		}

		public bool TestMethod(string message)
		{
			if (string.IsNullOrWhiteSpace(message)) {
				throw new ArgumentNullException ("message");
			}

			return true;
		}
	}
}

