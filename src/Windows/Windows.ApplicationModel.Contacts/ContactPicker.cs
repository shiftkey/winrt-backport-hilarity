using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[Activatable(100794368u), Version(100794368u)]
	public sealed class ContactPicker : IContactPicker
	{
		public extern string CommitButtonText
		{
			get;
			set;
		}
		public extern IVector<string> DesiredFields
		{
			get;
		}
		public extern ContactSelectionMode SelectionMode
		{
			get;
			set;
		}
		public extern ContactPicker();
		public extern IAsyncOperation<ContactInformation> PickSingleContactAsync();
		public extern IAsyncOperation<IVectorView<ContactInformation>> PickMultipleContactsAsync();
	}
}
