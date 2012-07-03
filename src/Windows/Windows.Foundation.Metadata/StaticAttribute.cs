using System;
namespace Windows.Foundation.Metadata
{
	[AllowMultiple, AttributeUsage(AttributeTargets.RuntimeClass), Version(100794368u)]
	public sealed class StaticAttribute : Attribute
	{
		public extern StaticAttribute(Type type, uint version);
	}
}
