using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers
{
	[Activatable(100794368u), Version(100794368u)]
	public sealed class FileSavePicker : IFileSavePicker
	{
		public extern string CommitButtonText
		{
			get;
			set;
		}
		public extern string DefaultFileExtension
		{
			get;
			set;
		}
		public extern IMap<string, IVector<string>> FileTypeChoices
		{
			get;
		}
		public extern string SettingsIdentifier
		{
			get;
			set;
		}
		public extern string SuggestedFileName
		{
			get;
			set;
		}
		public extern StorageFile SuggestedSaveFile
		{
			get;
			set;
		}
		public extern PickerLocationId SuggestedStartLocation
		{
			get;
			set;
		}
		public extern FileSavePicker();
		public extern IAsyncOperation<StorageFile> PickSaveFileAsync();
	}
}
