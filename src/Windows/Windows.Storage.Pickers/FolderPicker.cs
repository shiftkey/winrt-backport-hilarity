using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers
{
	[Activatable(100794368u), Version(100794368u)]
	public sealed class FolderPicker : IFolderPicker
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
		public extern FolderPicker();
		public extern IAsyncOperation<StorageFolder> PickSingleFolderAsync();
	}
}
