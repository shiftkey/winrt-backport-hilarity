using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(StandardDataFormats)), Guid(2127987105u, 43136, 16585, 180, 237, 11, 238, 30, 21, 245, 73), Version(100794368u)]
	internal interface IStandardDataFormatsStatics
	{
		string Bitmap
		{
			get;
		}
		string Html
		{
			get;
		}
		string Rtf
		{
			get;
		}
		string StorageItems
		{
			get;
		}
		string Text
		{
			get;
		}
		string Uri
		{
			get;
		}
	}
}
