using System;
namespace Windows.Foundation.Metadata
{
	[AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Interface), Version(100794368u)]
	public sealed class GuidAttribute : Attribute
	{
		public extern GuidAttribute(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k);
	}
}
