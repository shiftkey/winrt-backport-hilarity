using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;
namespace Windows.ApplicationModel.Activation
{
	[Guid(2176949489u, 29926, 17287, 130, 235, 187, 143, 214, 75, 67, 70), Version(100794368u)]
	public interface IFileSavePickerActivatedEventArgs : IActivatedEventArgs
	{
		FileSavePickerUI FileSavePickerUI
		{
			get;
		}
	}
}
