using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[Activatable(typeof(IContactFieldFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ContactField : IContactField
	{
		public extern ContactFieldCategory Category
		{
			get;
		}
		public extern string Name
		{
			get;
		}
		public extern ContactFieldType Type
		{
			get;
		}
		public extern string Value
		{
			get;
		}
		public extern ContactField([In] string value, [In] ContactFieldType type);
		public extern ContactField([In] string value, [In] ContactFieldType type, [In] ContactFieldCategory category);
		public extern ContactField([In] string name, [In] string value, [In] ContactFieldType type, [In] ContactFieldCategory category);
	}
}
