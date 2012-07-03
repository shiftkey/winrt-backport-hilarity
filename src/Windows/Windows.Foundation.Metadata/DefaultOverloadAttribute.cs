using System;
namespace Windows.Foundation.Metadata
{
	[AttributeUsage(AttributeTargets.Method), Version(100794368u)]
	public sealed class DefaultOverloadAttribute : Attribute
	{
		public extern DefaultOverloadAttribute();
	}
}
