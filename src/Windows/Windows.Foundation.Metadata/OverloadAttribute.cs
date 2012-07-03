using System;
namespace Windows.Foundation.Metadata
{
	[AttributeUsage(AttributeTargets.Method), Version(100794368u)]
	public sealed class OverloadAttribute : Attribute
	{
		public extern OverloadAttribute(string method);
	}
}
