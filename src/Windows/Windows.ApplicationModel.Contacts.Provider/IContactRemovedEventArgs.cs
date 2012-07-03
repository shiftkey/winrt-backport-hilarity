using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts.Provider
{
	[ExclusiveTo(typeof(ContactRemovedEventArgs)), Guid(1865761592u, 13058, 19731, 173, 141, 173, 204, 15, 249, 228, 124), Version(100794368u)]
	internal interface IContactRemovedEventArgs
	{
		string Id
		{
			get;
		}
	}
}
