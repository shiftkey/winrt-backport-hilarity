using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[ExclusiveTo(typeof(FileSavePickerUI)), Guid(2522268135u, 15958, 17356, 138, 57, 51, 199, 61, 157, 84, 43), Version(100794368u)]
	internal interface IFileSavePickerUI
	{
		event TypedEventHandler<FileSavePickerUI, object> FileNameChanged;
		event TypedEventHandler<FileSavePickerUI, TargetFileRequestedEventArgs> TargetFileRequested;
		IVectorView<string> AllowedFileTypes
		{
			get;
		}
		string FileName
		{
			get;
		}
		string SettingsIdentifier
		{
			get;
		}
		string Title
		{
			get;
			set;
		}
		SetFileNameResult TrySetFileName([In] string value);
	}
}
