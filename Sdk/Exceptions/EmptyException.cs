using System;
using System.Collections;

namespace Xunit.Sdk
{
	/// <summary>
	/// Exception thrown when a collection is unexpectedly not empty.
	/// </summary>
#if XUNIT_VISIBILITY_INTERNAL
	internal
#else
	public
#endif
	class EmptyException : AssertActualExpectedException
	{
		/// <summary>
		/// Creates a new instance of the <see cref="EmptyException"/> class.
		/// </summary>
		public EmptyException(IEnumerable collection)
			: base("<empty>", ArgumentFormatter.Format(collection), "Assert.Empty() Failure")
		{
		}
	}
}
