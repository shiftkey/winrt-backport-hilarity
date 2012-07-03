using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.Contacts
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class Contact : IContact
	{
		public extern IVector<IContactField> Fields
		{
			get;
		}
		public extern string Name
		{
			get;
			set;
		}
		public extern IRandomAccessStreamReference Thumbnail
		{
			get;
			set;
		}
		public extern Contact();
	}
}
