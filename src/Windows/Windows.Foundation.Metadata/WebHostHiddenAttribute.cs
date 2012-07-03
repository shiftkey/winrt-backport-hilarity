using System;
namespace Windows.Foundation.Metadata
{
	//[AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.RuntimeClass | AttributeTargets.Struct), Version(100794368u)]
    [AttributeUsage(AttributeTargets.All)]
	public sealed class WebHostHiddenAttribute : Attribute
	{
		public extern WebHostHiddenAttribute();
	}
}
