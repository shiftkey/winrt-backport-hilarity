using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[ExclusiveTo(typeof(ContactInstantMessageField)), Guid(3437443895u, 3461, 16890, 180, 61, 218, 89, 156, 62, 176, 9), Version(100794368u)]
	internal interface IContactInstantMessageField : IContactField
	{
		string DisplayText
		{
			get;
		}
		Uri LaunchUri
		{
			get;
		}
		string Service
		{
			get;
		}
		string UserName
		{
			get;
		}
	}
}
