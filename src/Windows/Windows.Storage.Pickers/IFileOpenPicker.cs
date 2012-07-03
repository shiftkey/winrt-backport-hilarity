using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers
{
	[ExclusiveTo(typeof(FileOpenPicker)), Guid(749217674u, 4805, 19551, 137, 119, 148, 84, 119, 147, 194, 65), Version(100794368u)]
	internal interface IFileOpenPicker
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
		IAsyncOperation<StorageFile> PickSingleFileAsync();
		IAsyncOperation<IVectorView<StorageFile>> PickMultipleFilesAsync();
	}
}
