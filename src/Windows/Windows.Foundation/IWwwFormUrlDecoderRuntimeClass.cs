using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
	[ExclusiveTo(typeof(WwwFormUrlDecoder))]
	internal interface IWwwFormUrlDecoderRuntimeClass : IIterable<IWwwFormUrlDecoderEntry>, IVectorView<IWwwFormUrlDecoderEntry>
	{
		string GetFirstValueByName(string name);
	}
}
