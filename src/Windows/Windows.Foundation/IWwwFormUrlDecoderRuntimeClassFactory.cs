using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[ExclusiveTo(typeof(WwwFormUrlDecoder)), Guid(1535929149u, 9390, 16821, 161, 191, 240, 195, 213, 68, 132, 91), Version(100794368u)]
	internal interface IWwwFormUrlDecoderRuntimeClassFactory
	{
		WwwFormUrlDecoder CreateWwwFormUrlDecoder([In] string hstrWwwFormUrlDecoder);
	}
}
