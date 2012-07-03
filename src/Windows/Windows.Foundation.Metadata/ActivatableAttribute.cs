using System;
namespace Windows.Foundation.Metadata
{
	[AllowMultiple, AttributeUsage(AttributeTargets.RuntimeClass), Version(100794368u)]
	public sealed class ActivatableAttribute : Attribute
	{
		public extern ActivatableAttribute(uint version);
		public extern ActivatableAttribute(Type type, uint version);
	}
}
