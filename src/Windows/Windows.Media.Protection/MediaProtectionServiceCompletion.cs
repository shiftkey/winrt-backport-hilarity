using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class MediaProtectionServiceCompletion : IMediaProtectionServiceCompletion
	{
		public extern void Complete([In] bool success);
	}
}
