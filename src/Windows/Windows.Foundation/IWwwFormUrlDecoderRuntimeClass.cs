using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[ExclusiveTo(typeof(WwwFormUrlDecoder)), Guid(3562669137u, 61989, 17730, 146, 150, 14, 29, 245, 210, 84, 223), Version(100794368u)]
	internal interface IWwwFormUrlDecoderRuntimeClass : IIterable<IWwwFormUrlDecoderEntry>, IVectorView<IWwwFormUrlDecoderEntry>
	{
		string GetFirstValueByName([In] string name);
	}
}
