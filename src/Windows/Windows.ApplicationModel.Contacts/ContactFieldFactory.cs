using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ContactFieldFactory : IContactFieldFactory, IContactLocationFieldFactory, IContactInstantMessageFieldFactory
	{
		public extern ContactFieldFactory();
		[Overload("CreateField_Default")]
		public extern ContactField CreateField([In] string value, [In] ContactFieldType type);
		[Overload("CreateField_Category")]
		public extern ContactField CreateField([In] string value, [In] ContactFieldType type, [In] ContactFieldCategory category);
		[Overload("CreateField_Custom")]
		public extern ContactField CreateField([In] string name, [In] string value, [In] ContactFieldType type, [In] ContactFieldCategory category);
		[Overload("CreateLocation_Default")]
		public extern ContactLocationField CreateLocation([In] string unstructuredAddress);
		[Overload("CreateLocation_Category")]
		public extern ContactLocationField CreateLocation([In] string unstructuredAddress, [In] ContactFieldCategory category);
		[Overload("CreateLocation_All")]
		public extern ContactLocationField CreateLocation([In] string unstructuredAddress, [In] ContactFieldCategory category, [In] string street, [In] string city, [In] string region, [In] string country, [In] string postalCode);
		[Overload("CreateInstantMessage_Default")]
		public extern ContactInstantMessageField CreateInstantMessage([In] string userName);
		[Overload("CreateInstantMessage_Category")]
		public extern ContactInstantMessageField CreateInstantMessage([In] string userName, [In] ContactFieldCategory category);
		[Overload("CreateInstantMessage_All")]
		public extern ContactInstantMessageField CreateInstantMessage([In] string userName, [In] ContactFieldCategory category, [In] string service, [In] string displayText, [In] Uri verb);
	}
}
