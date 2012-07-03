using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel
{
	[Version(100794368u)]
	public struct PackageVersion
	{
		public ushort Major;
		public ushort Minor;
		public ushort Build;
		public ushort Revision;
	}
}
