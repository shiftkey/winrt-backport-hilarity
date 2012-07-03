using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers
{
	[ExclusiveTo(typeof(FileSavePicker)), Guid(847708107u, 24959, 19653, 175, 106, 179, 253, 242, 154, 209, 69), Version(100794368u)]
	internal interface IFileSavePicker
	{
		string CommitButtonText
		{
			get;
			set;
		}
		string DefaultFileExtension
		{
			get;
			set;
		}
		IMap<string, IVector<string>> FileTypeChoices
		{
			get;
		}
		string SettingsIdentifier
		{
			get;
			set;
		}
		string SuggestedFileName
		{
			get;
			set;
		}
		StorageFile SuggestedSaveFile
		{
			get;
			set;
		}
		PickerLocationId SuggestedStartLocation
		{
			get;
			set;
		}
		IAsyncOperation<StorageFile> PickSaveFileAsync();
	}
}
