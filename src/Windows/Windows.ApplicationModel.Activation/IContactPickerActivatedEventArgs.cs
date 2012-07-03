using System;
using Windows.ApplicationModel.Contacts.Provider;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[Guid(3461851879u, 25673, 17831, 151, 31, 209, 19, 190, 122, 137, 54), Version(100794368u)]
	public interface IContactPickerActivatedEventArgs : IActivatedEventArgs
	{
		ContactPickerUI ContactPickerUI
		{
			get;
		}
	}
}
