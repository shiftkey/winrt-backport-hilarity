using System;
namespace Windows.Foundation.Metadata
{
	[AttributeUsage(AttributeTargets.InterfaceImpl), Version(100794368u)]
	public sealed class OverridableAttribute : Attribute
	{
		public extern OverridableAttribute();
	}
}
