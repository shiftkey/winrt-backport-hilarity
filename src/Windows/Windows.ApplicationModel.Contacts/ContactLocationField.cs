using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[Activatable(typeof(IContactLocationFieldFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ContactLocationField : IContactLocationField, IContactField
	{
		public extern string City
		{
			get;
		}
		public extern string Country
		{
			get;
		}
		public extern string PostalCode
		{
			get;
		}
		public extern string Region
		{
			get;
		}
		public extern string Street
		{
			get;
		}
		public extern string UnstructuredAddress
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
		public extern ContactLocationField([In] string unstructuredAddress);
		public extern ContactLocationField([In] string unstructuredAddress, [In] ContactFieldCategory category);
		public extern ContactLocationField([In] string unstructuredAddress, [In] ContactFieldCategory category, [In] string street, [In] string city, [In] string region, [In] string country, [In] string postalCode);
	}
}
