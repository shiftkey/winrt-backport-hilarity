using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[Activatable(typeof(IContactInstantMessageFieldFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ContactInstantMessageField : IContactInstantMessageField, IContactField
	{
		public extern string DisplayText
		{
			get;
		}
		public extern Uri LaunchUri
		{
			get;
		}
		public extern string Service
		{
			get;
		}
		public extern string UserName
		{
			get;
		}
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
		public extern ContactInstantMessageField([In] string userName);
		public extern ContactInstantMessageField([In] string userName, [In] ContactFieldCategory category);
		public extern ContactInstantMessageField([In] string userName, [In] ContactFieldCategory category, [In] string service, [In] string displayText, [In] Uri verb);
	}
}
