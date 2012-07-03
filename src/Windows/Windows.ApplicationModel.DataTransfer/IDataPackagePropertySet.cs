using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(DataPackagePropertySet)), Guid(3441202155u, 19532, 17466, 168, 211, 245, 194, 65, 233, 22, 137), HasVariant, Version(100794368u)]
	internal interface IDataPackagePropertySet : IMap<string, object>, IIterable<IKeyValuePair<string, object>>
	{
		Uri ApplicationListingUri
		{
			get;
			set;
		}
		string ApplicationName
		{
			get;
			set;
		}
		string Description
		{
			get;
			set;
		}
		IVector<string> FileTypes
		{
			get;
		}
		IRandomAccessStreamReference Thumbnail
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
