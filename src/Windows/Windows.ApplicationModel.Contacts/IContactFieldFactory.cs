using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[Guid(2246218047u, 3658, 19006, 137, 148, 64, 106, 231, 237, 100, 110), Version(100794368u)]
	public interface IContactFieldFactory
	{
		[Overload("CreateField_Default")]
		ContactField CreateField([In] string value, [In] ContactFieldType type);
		[Overload("CreateField_Category")]
		ContactField CreateField([In] string value, [In] ContactFieldType type, [In] ContactFieldCategory category);
		[Overload("CreateField_Custom")]
		ContactField CreateField([In] string name, [In] string value, [In] ContactFieldType type, [In] ContactFieldCategory category);
	}
}
