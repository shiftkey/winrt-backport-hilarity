using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[Version(100794368u)]
	public enum ContactFieldType
	{
		Email,
		PhoneNumber,
		Location,
		InstantMessage,
		Custom
	}
}
