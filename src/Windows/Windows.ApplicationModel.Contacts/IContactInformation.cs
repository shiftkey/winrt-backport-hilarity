using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.Contacts
{
	[ExclusiveTo(typeof(ContactInformation)), Guid(660518612u, 27182, 17016, 169, 20, 228, 96, 213, 240, 136, 246), Version(100794368u)]
	internal interface IContactInformation
	{
		IVectorView<ContactField> CustomFields
		{
			get;
		}
		IVectorView<ContactField> Emails
		{
			get;
		}
		IVectorView<ContactInstantMessageField> InstantMessages
		{
			get;
		}
		IVectorView<ContactLocationField> Locations
		{
			get;
		}
		string Name
		{
			get;
		}
		IVectorView<ContactField> PhoneNumbers
		{
			get;
		}
		IAsyncOperation<IRandomAccessStreamWithContentType> GetThumbnailAsync();
		IVectorView<ContactField> QueryCustomFields([In] string customName);
	}
}
