using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts.Provider
{
	[ExclusiveTo(typeof(ContactPickerUI)), Guid(3805025126u, 53094, 17348, 169, 106, 165, 161, 18, 219, 71, 70), Version(100794368u)]
	internal interface IContactPickerUI
	{
		event TypedEventHandler<ContactPickerUI, ContactRemovedEventArgs> ContactRemoved;
		IVectorView<string> DesiredFields
		{
			get;
		}
		ContactSelectionMode SelectionMode
		{
			get;
		}
		AddContactResult AddContact([In] string id, [In] Contact contact);
		void RemoveContact([In] string id);
		bool ContainsContact([In] string id);
	}
}
