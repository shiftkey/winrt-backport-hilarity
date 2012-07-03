using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(308180017u, 63096, 20110, 182, 112, 32, 169, 176, 108, 81, 45), Version(100794368u)]
	public interface IWwwFormUrlDecoderEntry
	{
		string Name
		{
			get;
		}
		string Value
		{
			get;
		}
	}
}
