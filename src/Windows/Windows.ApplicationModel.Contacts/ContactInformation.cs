using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.Contacts
{
	[Version(100794368u)]
	public sealed class ContactInformation : IContactInformation
	{
		public extern IVectorView<ContactField> CustomFields
		{
			get;
		}
		public extern IVectorView<ContactField> Emails
		{
			get;
		}
		public extern IVectorView<ContactInstantMessageField> InstantMessages
		{
			get;
		}
		public extern IVectorView<ContactLocationField> Locations
		{
			get;
		}
		public extern string Name
		{
			get;
		}
		public extern IVectorView<ContactField> PhoneNumbers
		{
			get;
		}
		public extern IAsyncOperation<IRandomAccessStreamWithContentType> GetThumbnailAsync();
		public extern IVectorView<ContactField> QueryCustomFields([In] string customName);
	}
}
