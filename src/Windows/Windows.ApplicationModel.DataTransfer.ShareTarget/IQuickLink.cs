using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
	[ExclusiveTo(typeof(QuickLink)), Guid(1614693128u, 61630, 19164, 172, 201, 139, 39, 171, 156, 245, 86), Version(100794368u)]
	internal interface IQuickLink
	{
		string Id
		{
			get;
			set;
		}
		IVector<string> SupportedDataFormats
		{
			get;
		}
		IVector<string> SupportedFileTypes
		{
			get;
		}
		RandomAccessStreamReference Thumbnail
		{
			get;
			set;
		}
		string Title
		{
			get;
			set;
		}
	}
}
