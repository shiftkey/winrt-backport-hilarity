using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IKnownContactFieldStatics), 100794368u), Version(100794368u)]
	public static class KnownContactField
	{
		public static extern string Email
		{
			get;
		}
		public static extern string InstantMessage
		{
			get;
		}
		public static extern string Location
		{
			get;
		}
		public static extern string PhoneNumber
		{
			get;
		}
		public static extern ContactFieldType ConvertNameToType([In] string name);
		public static extern string ConvertTypeToName([In] ContactFieldType type);
	}
}
