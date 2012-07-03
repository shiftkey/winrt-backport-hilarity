using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class BitmapCodecInformation : IBitmapCodecInformation
	{
		public extern Guid CodecId
		{
			get;
		}
		public extern IVectorView<string> FileExtensions
		{
			get;
		}
		public extern string FriendlyName
		{
			get;
		}
		public extern IVectorView<string> MimeTypes
		{
			get;
		}
	}
}
