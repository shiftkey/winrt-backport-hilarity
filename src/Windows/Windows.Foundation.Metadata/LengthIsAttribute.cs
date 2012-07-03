using System;
namespace Windows.Foundation.Metadata
{
	[AttributeUsage(AttributeTargets.Parameter), Version(100794368u)]
	public sealed class LengthIsAttribute : Attribute
	{
		public extern LengthIsAttribute(int indexLengthParameter);
	}
}
