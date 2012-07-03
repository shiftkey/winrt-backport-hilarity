using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
	[ExclusiveTo(typeof(WwwFormUrlDecoder))]
	internal interface IWwwFormUrlDecoderRuntimeClassFactory
	{
		WwwFormUrlDecoder CreateWwwFormUrlDecoder(string hstrWwwFormUrlDecoder);
	}
}
