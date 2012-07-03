using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts.Provider
{
	[Version(100794368u)]
	public sealed class ContactPickerUI : IContactPickerUI
	{
		public extern event TypedEventHandler<ContactPickerUI, ContactRemovedEventArgs> ContactRemoved
		{
			add;
			remove;
		}
		public extern IVectorView<string> DesiredFields
		{
			get;
		}
		public extern ContactSelectionMode SelectionMode
		{
			get;
		}
		public extern AddContactResult AddContact([In] string id, [In] Contact contact);
		public extern void RemoveContact([In] string id);
		public extern bool ContainsContact([In] string id);
	}
}
