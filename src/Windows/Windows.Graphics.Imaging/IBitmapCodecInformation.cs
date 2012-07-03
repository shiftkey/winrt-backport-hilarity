using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[ExclusiveTo(typeof(BitmapCodecInformation)), Guid(1074572018u, 50352, 17298, 163, 176, 111, 111, 155, 169, 92, 180), Version(100794368u)]
	internal interface IBitmapCodecInformation
	{
		Guid CodecId
		{
			get;
		}
		IVectorView<string> FileExtensions
		{
			get;
		}
		string FriendlyName
		{
			get;
		}
		IVectorView<string> MimeTypes
		{
			get;
		}
	}
}
