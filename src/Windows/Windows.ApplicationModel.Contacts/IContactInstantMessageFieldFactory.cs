using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[Guid(3121309588u, 37283, 19378, 177, 185, 105, 165, 223, 240, 186, 9), Version(100794368u)]
	public interface IContactInstantMessageFieldFactory
	{
		[Overload("CreateInstantMessage_Default")]
		ContactInstantMessageField CreateInstantMessage([In] string userName);
		[Overload("CreateInstantMessage_Category")]
		ContactInstantMessageField CreateInstantMessage([In] string userName, [In] ContactFieldCategory category);
		[Overload("CreateInstantMessage_All")]
		ContactInstantMessageField CreateInstantMessage([In] string userName, [In] ContactFieldCategory category, [In] string service, [In] string displayText, [In] Uri verb);
	}
}
