using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[ExclusiveTo(typeof(KnownContactField)), Guid(772676370u, 54823, 20426, 186, 212, 31, 175, 22, 140, 125, 20), Version(100794368u)]
	internal interface IKnownContactFieldStatics
	{
		string Email
		{
			get;
		}
		string InstantMessage
		{
			get;
		}
		string Location
		{
			get;
		}
		string PhoneNumber
		{
			get;
		}
		ContactFieldType ConvertNameToType([In] string name);
		string ConvertTypeToName([In] ContactFieldType type);
	}
}
