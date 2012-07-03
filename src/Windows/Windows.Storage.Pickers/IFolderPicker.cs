using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers
{
	[ExclusiveTo(typeof(FolderPicker)), Guid(139425689u, 62459, 16394, 153, 177, 123, 74, 119, 47, 214, 13), Version(100794368u)]
	internal interface IFolderPicker
	{
		string CommitButtonText
		{
			get;
			set;
		}
		IVector<string> FileTypeFilter
		{
			get;
		}
		string SettingsIdentifier
		{
			get;
			set;
		}
		PickerLocationId SuggestedStartLocation
		{
			get;
			set;
		}
		PickerViewMode ViewMode
		{
			get;
			set;
		}
		IAsyncOperation<StorageFolder> PickSingleFolderAsync();
	}
}
