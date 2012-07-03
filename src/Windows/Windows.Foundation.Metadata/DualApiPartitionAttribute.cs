using System;
namespace Windows.Foundation.Metadata
{
	[AttributeUsage(AttributeTargets.RuntimeClass), Version(100794368u)]
	public sealed class DualApiPartitionAttribute : Attribute
	{
		public uint version;
		public extern DualApiPartitionAttribute();
	}
}
