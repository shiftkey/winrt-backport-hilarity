using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[Version(100794368u)]
	public sealed class FileSavePickerUI : IFileSavePickerUI
	{
		public extern event TypedEventHandler<FileSavePickerUI, object> FileNameChanged
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<FileSavePickerUI, TargetFileRequestedEventArgs> TargetFileRequested
		{
			add;
			remove;
		}
		public extern IVectorView<string> AllowedFileTypes
		{
			get;
		}
		public extern string FileName
		{
			get;
		}
		public extern string SettingsIdentifier
		{
			get;
		}
		public extern string Title
		{
			get;
			set;
		}
		public extern SetFileNameResult TrySetFileName([In] string value);
	}
}
