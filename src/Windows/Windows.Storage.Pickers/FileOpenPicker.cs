using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers
{
	[Activatable(100794368u), Version(100794368u)]
	public sealed class FileOpenPicker : IFileOpenPicker
	{
		public extern string CommitButtonText
		{
			get;
			set;
		}
		public extern IVector<string> FileTypeFilter
		{
			get;
		}
		public extern string SettingsIdentifier
		{
			get;
			set;
		}
		public extern PickerLocationId SuggestedStartLocation
		{
			get;
			set;
		}
		public extern PickerViewMode ViewMode
		{
			get;
			set;
		}
		public extern FileOpenPicker();
		public extern IAsyncOperation<StorageFile> PickSingleFileAsync();
		public extern IAsyncOperation<IVectorView<StorageFile>> PickMultipleFilesAsync();
	}
}
