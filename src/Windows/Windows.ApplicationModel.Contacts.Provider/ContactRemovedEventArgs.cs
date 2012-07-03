using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts.Provider
{
	[Version(100794368u)]
	public sealed class ContactRemovedEventArgs : IContactRemovedEventArgs
	{
		public extern string Id
		{
			get;
		}
	}
}
