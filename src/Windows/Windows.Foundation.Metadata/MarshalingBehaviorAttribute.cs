using System;
namespace Windows.Foundation.Metadata
{
	[AttributeUsage(AttributeTargets.RuntimeClass), Version(100794368u)]
	public sealed class MarshalingBehaviorAttribute : Attribute
	{
		public extern MarshalingBehaviorAttribute(MarshalingType behavior);
	}
}
