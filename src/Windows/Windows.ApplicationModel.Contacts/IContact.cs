using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.Contacts
{
	[ExclusiveTo(typeof(Contact)), Guid(3959452403u, 8472, 16457, 158, 188, 23, 240, 171, 105, 43, 100), Version(100794368u)]
	internal interface IContact
	{
		IVector<IContactField> Fields
		{
			get;
		}
		string Name
		{
			get;
			set;
		}
		IRandomAccessStreamReference Thumbnail
		{
			get;
			set;
		}
	}
}
