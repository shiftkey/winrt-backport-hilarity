using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts.Provider
{
	[Version(100794368u)]
	public enum AddContactResult
	{
		Added,
		AlreadyAdded,
		Unavailable
	}
}
