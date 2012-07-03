using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[ExclusiveTo(typeof(ContactPicker)), Guid(235535761u, 17144, 16469, 144, 160, 137, 111, 150, 115, 137, 54), Version(100794368u)]
	internal interface IContactPicker
	{
		string CommitButtonText
		{
			get;
			set;
		}
		IVector<string> DesiredFields
		{
			get;
		}
		ContactSelectionMode SelectionMode
		{
			get;
			set;
		}
		IAsyncOperation<ContactInformation> PickSingleContactAsync();
		IAsyncOperation<IVectorView<ContactInformation>> PickMultipleContactsAsync();
	}
}
