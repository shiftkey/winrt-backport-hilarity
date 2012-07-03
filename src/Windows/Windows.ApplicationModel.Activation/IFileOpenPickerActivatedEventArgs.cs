using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;
namespace Windows.ApplicationModel.Activation
{
	[Guid(1921151106u, 21797, 19442, 188, 9, 31, 80, 149, 212, 150, 77), Version(100794368u)]
	public interface IFileOpenPickerActivatedEventArgs : IActivatedEventArgs
	{
		FileOpenPickerUI FileOpenPickerUI
		{
			get;
		}
	}
}
