using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[Guid(4154012375u, 12255, 17406, 143, 24, 65, 137, 115, 144, 188, 254), Version(100794368u)]
	public interface IContactLocationFieldFactory
	{
		[Overload("CreateLocation_Default")]
		ContactLocationField CreateLocation([In] string unstructuredAddress);
		[Overload("CreateLocation_Category")]
		ContactLocationField CreateLocation([In] string unstructuredAddress, [In] ContactFieldCategory category);
		[Overload("CreateLocation_All")]
		ContactLocationField CreateLocation([In] string unstructuredAddress, [In] ContactFieldCategory category, [In] string street, [In] string city, [In] string region, [In] string country, [In] string postalCode);
	}
}
