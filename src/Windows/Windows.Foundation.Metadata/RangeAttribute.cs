using System;
namespace Windows.Foundation.Metadata
{
	[AttributeUsage(AttributeTargets.Parameter), Version(100794368u)]
	public sealed class RangeAttribute : Attribute
	{
		public extern RangeAttribute(int minValue, int maxValue);
	}
}
