using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(DataPackagePropertySetView)), Guid(3108826113u, 3098, 19543, 190, 85, 117, 208, 18, 137, 115, 93), HasVariant, Version(100794368u)]
	internal interface IDataPackagePropertySetView : IMapView<string, object>, IIterable<IKeyValuePair<string, object>>
	{
		Uri ApplicationListingUri
		{
			get;
		}
		string ApplicationName
		{
			get;
		}
		string Description
		{
			get;
		}
		IVectorView<string> FileTypes
		{
			get;
		}
		RandomAccessStreamReference Thumbnail
		{
			get;
		}
		string Title
		{
			get;
		}
	}
}
