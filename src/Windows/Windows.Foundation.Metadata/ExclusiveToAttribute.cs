using System;
namespace Windows.Foundation.Metadata
{
	[AttributeUsage(AttributeTargets.Interface), Version(100794368u)]
	public sealed class ExclusiveToAttribute : Attribute
	{
		public extern ExclusiveToAttribute(Type typeName);
	}
}
